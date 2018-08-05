using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crownbet_Common
{
    public interface ILogger
    {
        void WriteInfo(string message);
        void WriteDebug(string message);
    }
    public class Logger : ILogger
    {
        private static readonly log4net.ILog log =
            log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void WriteInfo(string message)
        {
            log.Info(message);
        }

        public void WriteDebug(string message)
        {
            log.Debug(message);
        }
    }
}
