namespace Work_space
{
    public class LogType
    {
        public static LoggerRecordDecorator Message
        {
            get
            {
                return new Message();
            }
        }
        public static LoggerRecordDecorator Error
        {
            get
            {
                return new Error();
            }
        }
    }
}