using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Infrastructure.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MHM.Accountancy.Business.Infrastructure.Extensions
{
    public static partial class Extension
    {
        //public static bool ShowErrorInfo(this User user)
        //{
        //    if (user.ErrorID < 0)
        //    {
        //        Message.ShowErrorMessageBox(string.Format("Xəta baş vermişdir.Xəta ilə əlaqədar \nProgramçılara müraciət edərkən xəta kodundan istifadə edin.\nERROR({0})", -1 * user.ErrorID));
        //        user.ErrorID = 0;
        //        return true;
        //    }
        //    return false;
        //}

        public static int ExecuteProcedure(this User user, string commandText, List<SqlParameter> parameters = null,
            CommandType commandType = CommandType.Text, string connectionString = "")
        {
            using (DataTable table = new DataTable())
            {
                try
                {
                    return ExecuteProcedure(user, table, commandText, parameters, true, commandType, connectionString);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return -1;
        }


        public static int ExecuteProcedure<T>(this User user, T dataTable, string commandText, List<SqlParameter> parameters = null,
       bool clearBeforeFill = true,
           CommandType commandType = CommandType.Text, string connectionString = "")
           where T : DataTable
        {
            return ExecuteProcedure(user, dataTable, commandText, parameters, clearBeforeFill, commandType, string.IsNullOrWhiteSpace(connectionString) ? user.CurrentConnection : new SqlConnection(connectionString));
        }

        public static int ExecuteProcedure<T>(User user, T dataTable, string commandText, List<SqlParameter> parameters = null,
       bool clearBeforeFill = true,
           CommandType commandType = CommandType.Text, SqlConnection connection = null)
           where T : DataTable
        {
            if (user == null && connection == null)
                throw new ArgumentNullException("connection");

            using (SqlDataAdapter adp = new SqlDataAdapter())
            using (SqlCommand cmd = new SqlCommand(commandText, connection != null ? connection : user.CurrentConnection)
            {
                CommandType = commandType,
                CommandTimeout = 30
            })
            {
                try
                {
                    if (cmd.Connection.State != ConnectionState.Closed)
                        cmd.Connection.Close();

                    adp.SelectCommand = cmd;

                    if (commandType == CommandType.StoredProcedure)
                    {
                        parameters = parameters == null ? new List<SqlParameter>() : parameters;

                        //---------- Emeliyyati icra edenin melumati prosedura gonderilir
                        if (parameters.Count(prm => prm.ParameterName == "@userId") == 0 && user != null)
                            parameters.Add("@userId", user.Id);

                        if (parameters.Count(prm => prm.ParameterName == "@RETURN_VALUE") == 0)
                            parameters.Add("@RETURN_VALUE", -1, ParameterDirection.ReturnValue);

                        //if (parameters.Count(prm => prm.ParameterName == "@outErrorID") == 0)
                        //    parameters.Add("@outErrorID", 0, ParameterDirection.Output);
                    }

                    if (parameters != null && parameters.Count > 0)
                        cmd.Parameters.AddRange(parameters.ToArray());

                    if (clearBeforeFill)
                        dataTable.Clear();

                    adp.Fill(dataTable);

                    if (commandType == CommandType.StoredProcedure)
                    {
                        //var outErrorID = parameters.Find(prm => prm.ParameterName == "@outErrorID").Value;
                        //user.ErrorID = outErrorID == DBNull.Value ? 0 : Convert.ToInt32(outErrorID);
                        return Convert.ToInt32(parameters.Find(prm => prm.ParameterName == "@RETURN_VALUE").Value);
                    }
                    return 0;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return -1;
            }
        }

        public static T? ExecuteScalar<T>(this User user, string commandText, List<SqlParameter> parameters = null, SqlConnection connection = null)
            where T : struct
        {
            if (user == null)
                throw new ArgumentNullException("connection");

            using (SqlCommand cmd = new SqlCommand(commandText, connection == null ? user.CurrentConnection : connection)
            {
                CommandType = CommandType.Text,
                CommandTimeout = 30
            })
            {
                try
                {
                    if (cmd.Connection.State != ConnectionState.Open)
                        cmd.Connection.Open();
                    if (parameters != null && parameters.Count > 0)
                        cmd.Parameters.AddRange(parameters.ToArray());

                    var result = cmd.ExecuteScalar();

                    if (result == DBNull.Value || result == null)
                        return (T?)null;

                    return (T)result;
                }
                catch (InvalidCastException ex)
                {
                    return null;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return default(T);
        }

        public static T GetNewDocNumber<T>(this User user, string sequenceName)
        {
            if (user == null)
                throw new ArgumentNullException("connection");

            if (string.IsNullOrWhiteSpace(sequenceName))
                throw new ArgumentNullException("sequenceName");

            using (SqlCommand cmd = new SqlCommand(string.Format("select next value for {0}", sequenceName), user.CurrentConnection)
            {
                CommandType = CommandType.Text,
                CommandTimeout = 30
            })
            {
                try
                {
                    if (cmd.Connection.State != ConnectionState.Open)
                        cmd.Connection.Open();

                    var result = cmd.ExecuteScalar();
                    return (T)result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return default(T);
        }
    }
}
