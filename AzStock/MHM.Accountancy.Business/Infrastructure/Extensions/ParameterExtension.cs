using MHM.Accountancy.Business.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MHM.Accountancy.Business.Infrastructure.Extensions
{
    //public static partial class Extension
    //{
    //    static public List<SqlParameter> InitParameters()
    //    {
    //        return new List<SqlParameter>();
    //    }

    //    static public List<SqlParameter> Add(this List<SqlParameter> parameters, string parameterName, OperationType value, ParameterDirection direction = ParameterDirection.Input)
    //    {
    //        parameters.Add(new SqlParameter(parameterName, SqlDbType.TinyInt) { Value = (byte)value, Direction = direction });
    //        return parameters;
    //    }

    //    static public List<SqlParameter> Add(this List<SqlParameter> parameters, string parameterName, bool? value, ParameterDirection direction = ParameterDirection.Input)
    //    {
    //        if (value.HasValue)
    //            parameters.Add(new SqlParameter(parameterName, SqlDbType.Bit) { Value = value.Value, Direction = direction });
    //        return parameters;
    //    }

    //    /// <summary>
    //    /// Int tipli parameter elave etmek ucun
    //    /// </summary>
    //    /// <param name="parameters">Parameterler siyahisi</param>
    //    /// <param name="parameterName">Parameter adi</param>
    //    /// <param name="value">Parameter deyeri</param>
    //    /// <param name="direction">Parameter novu</param>
    //    /// <returns>parameter siyahisinin son veziyyeti qaytarilir</returns>
    //    static public List<SqlParameter> Add(this List<SqlParameter> parameters, string parameterName, int value, ParameterDirection direction = ParameterDirection.Input)
    //    {
    //        parameters.Add(new SqlParameter(parameterName, SqlDbType.Int) { Value = value, Direction = direction });
    //        return parameters;
    //    }

    //    /// <summary>
    //    /// Nullable Int tipli parameter elave etmek ucun
    //    /// </summary>
    //    /// <param name="parameters">Parameterler siyahisi</param>
    //    /// <param name="parameterName">Parameter adi</param>
    //    /// <param name="value">Parameter deyeri</param>
    //    /// <param name="direction">Parameter novu</param>
    //    /// <returns>parameter siyahisinin son veziyyeti qaytarilir</returns>
    //    static public List<SqlParameter> Add(this List<SqlParameter> parameters, string parameterName, int? value, ParameterDirection direction = ParameterDirection.Input)
    //    {
    //        //eger null deyilse
    //        if (value.HasValue)
    //            parameters.Add(parameterName, value.Value, direction);

    //        return parameters;
    //    }

    //    /// <summary>
    //    /// long tipli parameter elave etmek ucun
    //    /// </summary>
    //    /// <param name="parameters">Parameterler siyahisi</param>
    //    /// <param name="parameterName">Parameter adi</param>
    //    /// <param name="value">Parameter deyeri</param>
    //    /// <param name="direction">Parameter novu</param>
    //    /// <returns>parameter siyahisinin son veziyyeti qaytarilir</returns>
    //    static public List<SqlParameter> Add(this List<SqlParameter> parameters, string parameterName, long value, ParameterDirection direction = ParameterDirection.Input)
    //    {
    //        parameters.Add(new SqlParameter(parameterName, SqlDbType.BigInt) { Value = value, Direction = direction });
    //        return parameters;
    //    }

    //    /// <summary>
    //    /// Nullable long tipli parameter elave etmek ucun
    //    /// </summary>
    //    /// <param name="parameters">Parameterler siyahisi</param>
    //    /// <param name="parameterName">Parameter adi</param>
    //    /// <param name="value">Parameter deyeri</param>
    //    /// <param name="direction">Parameter novu</param>
    //    /// <returns>parameter siyahisinin son veziyyeti qaytarilir</returns>
    //    static public List<SqlParameter> Add(this List<SqlParameter> parameters, string parameterName, long? value, ParameterDirection direction = ParameterDirection.Input)
    //    {
    //        //eger null deyilse
    //        if (value.HasValue)
    //            parameters.Add(parameterName, value.Value, direction);

    //        return parameters;
    //    }

    //    /// <summary>
    //    /// DateTime tipli parameter elave etmek ucun
    //    /// </summary>
    //    /// <param name="parameters">Parameterler siyahisi</param>
    //    /// <param name="parameterName">Parameter adi</param>
    //    /// <param name="value">Parameter deyeri</param>
    //    /// <param name="direction">Parameter novu</param>
    //    /// <returns>parameter siyahisinin son veziyyeti qaytarilir</returns>
    //    static public List<SqlParameter> Add(this List<SqlParameter> parameters, string parameterName, DateTime value, ParameterDirection direction = ParameterDirection.Input)
    //    {
    //        parameters.Add(new SqlParameter(parameterName, SqlDbType.DateTime) { Value = value, Direction = direction });
    //        return parameters;
    //    }

    //    /// <summary>
    //    /// Nullable DateTime tipli parameter elave etmek ucun
    //    /// </summary>
    //    /// <param name="parameters">Parameterler siyahisi</param>
    //    /// <param name="parameterName">Parameter adi</param>
    //    /// <param name="value">Parameter deyeri</param>
    //    /// <param name="direction">Parameter novu</param>
    //    /// <returns>parameter siyahisinin son veziyyeti qaytarilir</returns>
    //    static public List<SqlParameter> Add(this List<SqlParameter> parameters, string parameterName, DateTime? value, ParameterDirection direction = ParameterDirection.Input)
    //    {
    //        //eger null deyilse
    //        if (value.HasValue)
    //            parameters.Add(parameterName, value.Value, direction);

    //        return parameters;
    //    }
    //    /// <summary>
    //    /// Decimal tipli parameter elave etmek ucun
    //    /// </summary>
    //    /// <param name="parameters">Parameterler siyahisi</param>
    //    /// <param name="parameterName">Parameter adi</param>
    //    /// <param name="value">Parameter deyeri</param>
    //    /// <param name="direction">Parameter novu</param>
    //    /// <returns>parameter siyahisinin son veziyyeti qaytarilir</returns>
    //    static public List<SqlParameter> Add(this List<SqlParameter> parameters, string parameterName, decimal value, ParameterDirection direction = ParameterDirection.Input)
    //    {
    //        parameters.Add(new SqlParameter(parameterName, SqlDbType.Decimal) { Value = value, Direction = direction });
    //        return parameters;
    //    }

    //    /// <summary>
    //    /// Nullable Decimal tipli parameter elave etmek ucun
    //    /// </summary>
    //    /// <param name="parameters">Parameterler siyahisi</param>
    //    /// <param name="parameterName">Parameter adi</param>
    //    /// <param name="value">Parameter deyeri</param>
    //    /// <param name="direction">Parameter novu</param>
    //    /// <returns>parameter siyahisinin son veziyyeti qaytarilir</returns>
    //    static public List<SqlParameter> Add(this List<SqlParameter> parameters, string parameterName, decimal? value, ParameterDirection direction = ParameterDirection.Input)
    //    {
    //        //eger null deyilse
    //        if (value.HasValue)
    //            parameters.Add(parameterName, value.Value, direction);

    //        return parameters;
    //    }

    //    /// <summary>
    //    /// Double tipli parameter elave etmek ucun
    //    /// </summary>
    //    /// <param name="parameters">Parameterler siyahisi</param>
    //    /// <param name="parameterName">Parameter adi</param>
    //    /// <param name="value">Parameter deyeri</param>
    //    /// <param name="direction">Parameter novu</param>
    //    /// <returns>parameter siyahisinin son veziyyeti qaytarilir</returns>
    //    static public List<SqlParameter> Add(this List<SqlParameter> parameters, string parameterName, double value, ParameterDirection direction = ParameterDirection.Input)
    //    {
    //        parameters.Add(new SqlParameter(parameterName, SqlDbType.Decimal) { Value = value, Direction = direction });
    //        return parameters;
    //    }

    //    /// <summary>
    //    /// Nullable Double tipli parameter elave etmek ucun
    //    /// </summary>
    //    /// <param name="parameters">Parameterler siyahisi</param>
    //    /// <param name="parameterName">Parameter adi</param>
    //    /// <param name="value">Parameter deyeri</param>
    //    /// <param name="direction">Parameter novu</param>
    //    /// <returns>parameter siyahisinin son veziyyeti qaytarilir</returns>
    //    static public List<SqlParameter> Add(this List<SqlParameter> parameters, string parameterName, double? value, ParameterDirection direction = ParameterDirection.Input)
    //    {
    //        //eger null deyilse
    //        if (value.HasValue)
    //            parameters.Add(parameterName, value.Value, direction);

    //        return parameters;
    //    }

    //    /// <summary>
    //    /// String tipli parameter elave etmek ucun
    //    /// </summary>
    //    /// <param name="parameters">Parameterler siyahisi</param>
    //    /// <param name="parameterName">Parameter adi</param>
    //    /// <param name="value">Parameter deyeri</param>
    //    /// <param name="direction">Parameter novu</param>
    //    /// <returns>parameter siyahisinin son veziyyeti qaytarilir</returns>
    //    public static List<SqlParameter> Add(this List<SqlParameter> parameters, string paramName, string value, int size = 200, ParameterDirection direction = ParameterDirection.Input)
    //    {
    //        if (!string.IsNullOrWhiteSpace(value))
    //            parameters.Add(new SqlParameter(paramName, SqlDbType.NVarChar, size) { Value = value, Direction = direction });
    //        return parameters;
    //    }

    //    /// <summary>
    //    /// Binary tipli parameter elave etmek ucun
    //    /// </summary>
    //    /// <param name="parameters">Parameterler siyahisi</param>
    //    /// <param name="parameterName">Parameter adi</param>
    //    /// <param name="value">Parameter deyeri</param>
    //    /// <param name="direction">Parameter novu</param>
    //    /// <returns>parameter siyahisinin son veziyyeti qaytarilir</returns>
    //    public static List<SqlParameter> Add(this List<SqlParameter> parameters, string paramName, byte[] value)
    //    {
    //        if (value.Length > 0)
    //            parameters.Add(new SqlParameter(paramName, SqlDbType.VarBinary, value.Length) { Value = value });
    //        return parameters;
    //    }

    //    public static List<SqlParameter> Add<T>(this List<SqlParameter> parameters, string paramName, string typeName, T table)
    //        where T : DataTable
    //    {
    //        if (table != null)
    //            parameters.Add(new SqlParameter(paramName, SqlDbType.Structured) { TypeName = typeName, Value = table });
    //        return parameters;
    //    }
    //}
}
