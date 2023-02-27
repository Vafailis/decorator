using System.Threading.Tasks;
namespace Work_space
{
    public class Logger
    {
        private Logger(bool writeToMany)
        {
            _writeToMany = writeToMany;
        }
        public static Logger GetLoggerInstance(bool writeToMany = false)
        {
            if (_loggerInstance is null)
            {
                _loggerInstance = new Logger(writeToMany);
            }
            return _loggerInstance;
        }

        private static Logger _loggerInstance;
        private static LoggerRecordDecorator _loggerRecordDecorator;
        private readonly bool _writeToMany;
        public void Write(string msg, LoggerRecordDecorator type)
        {
            _loggerRecordDecorator = type;
            _loggerRecordDecorator.IsWriteMany = _writeToMany;
            _loggerRecordDecorator.WriteRecord(msg);
        }
        public async Task WriteAsync(string msg, LoggerRecordDecorator type)
        {
            _loggerRecordDecorator = type;
            _loggerRecordDecorator.IsWriteMany = _writeToMany;
            await _loggerRecordDecorator.WriteAsyncRecord(msg);
        }
    }
}