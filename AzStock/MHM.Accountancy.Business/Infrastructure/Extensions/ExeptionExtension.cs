
using MHM.Accountancy.Business.Infrastructure.Common;
using MHM.Accountancy.Business.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace MHM.Accountancy.Business.Infrastructure.Extensions
{
    /// <summary>
    ///  Extension methods for Exception class.
    /// </summary>   
    public static partial class Extension
    {
        /// <summary>
        ///  Provides full stack trace for the exception that occurred.
        /// </summary>
        /// <param name="exception">Exception object.</param>
        /// <param name="environmentStackTrace">Environment stack trace, for pulling additional stack frames.</param>
        public static string ToLogString(this Exception exception, string environmentStackTrace)
        {
            List<string> environmentStackTraceLines = Extension.GetUserStackTraceLines(environmentStackTrace);
            environmentStackTraceLines.RemoveAt(0);

            List<string> stackTraceLines = Extension.GetStackTraceLines(exception.StackTrace);
            stackTraceLines.AddRange(environmentStackTraceLines);

            string fullStackTrace = String.Join("; ", stackTraceLines);

            string logMessage = exception.Message + Environment.NewLine + fullStackTrace;
            return logMessage;
        }

        public static string GetStackTrace(this Exception exception, string environmentStackTrace)
        {
            List<string> environmentStackTraceLines = Extension.GetUserStackTraceLines(environmentStackTrace);

            if (environmentStackTraceLines.Count > 0)
                environmentStackTraceLines.RemoveAt(0);

            //List<string> stackTraceLines = Extension.GetStackTraceLines(exception.StackTrace);
            //stackTraceLines.AddRange(environmentStackTraceLines);

            string fullStackTrace = String.Join("; ", environmentStackTraceLines);

            return fullStackTrace;
        }

        /// <summary>
        ///  Gets a list of stack frame lines, as strings.
        /// </summary>
        /// <param name="stackTrace">Stack trace string.</param>
        private static List<string> GetStackTraceLines(string stackTrace)
        {
            return stackTrace.Split(new[] { Environment.NewLine }, StringSplitOptions.None).ToList();
        }

        /// <summary>
        ///  Gets a list of stack frame lines, as strings, only including those for which line number is known.
        /// </summary>
        /// <param name="fullStackTrace">Full stack trace, including external code.</param>
        private static List<string> GetUserStackTraceLines(string fullStackTrace)
        {
            List<string> outputList = new List<string>();
            Regex regex = new Regex(@"([^\)]*\)) in (.*):line (\d)*$");

            List<string> stackTraceLines = Extension.GetStackTraceLines(fullStackTrace);
            foreach (string stackTraceLine in stackTraceLines)
            {
                if (!regex.IsMatch(stackTraceLine))
                    continue;

                outputList.Add(stackTraceLine);
            }

            return outputList;
        }

        static public void InvokeAction(this IManager manager, Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (MHMException ex)
            {
                MHMMessage.ShowErrorMessageBox(GetBaseException(ex).Message);
            }
            catch (MHMWarning ex)
            {
                MHMMessage.ShowWarningMessageBox(GetBaseException(ex).Message);
            }
            catch (MHMInformation ex)
            {
                MHMMessage.ShowInformationMessageBox(GetBaseException(ex).Message);
            }
            catch (Exception ex)
            {
                if (typeof(SqlException).IsInstanceOfType(ex) && (ex as SqlException).Number >= 500001)
                {
                    MHMMessage.ShowErrorMessageBox(GetBaseException(ex).Message);
                    return;
                }

                //var errorId = manager.MHMContainer.SendError(ex, manager);

                //if (errorId != -1)
                //    MHMMessage.ShowErrorMessageBox("Problem aşkarlandı.Xəta nömrəsini qeyd edib sistem mühəndisləinə bildirin.(Xəta nömrəsi: {0})", errorId);
                //else
                //{
                //    EventLog.WriteEntry("ERP-Intelect", "Problem aşkarlandı.Az sonra yenidən cəhd edin.", EventLogEntryType.Error, manager.Id);
                //    MHMMessage.ShowErrorMessageBox("Problem aşkarlandı.Az sonra yenidən cəhd edin.");
                //}
            }
        }

        static public void InvokeAction(this IContainer container, Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (MHMException ex)
            {
                MHMMessage.ShowErrorMessageBox(GetBaseException(ex).Message);
            }
            catch (MHMWarning ex)
            {
                MHMMessage.ShowWarningMessageBox(GetBaseException(ex).Message);
            }
            catch (MHMInformation ex)
            {
                MHMMessage.ShowInformationMessageBox(GetBaseException(ex).Message);
            }
            catch (Exception ex)
            {
                if (typeof(SqlException).IsInstanceOfType(ex) && (ex as SqlException).Number >= 500001)
                {
                    MHMMessage.ShowErrorMessageBox(GetBaseException(ex).Message);
                    return;
                }

                var errorId = container.SendError(ex, null);

                if (errorId != -1)
                    MHMMessage.ShowErrorMessageBox("Problem aşkarlandı.Xəta nömrəsini qeyd edib sistem mühəndisləinə bildirin.(Xəta nömrəsi: {0})", errorId);
                else
                {
                    EventLog.WriteEntry("ERP-Intelect", "Problem aşkarlandı.Az sonra yenidən cəhd edin.", EventLogEntryType.Error, 0);
                    MHMMessage.ShowErrorMessageBox("Problem aşkarlandı.Az sonra yenidən cəhd edin.");
                }
            }
        }

        static Exception GetBaseException(Exception ex)
        {
            while (ex.InnerException != null)
                ex = ex.InnerException;

            return ex;
        }
    }
}
