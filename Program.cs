using Work_space;
namespace decorator
{
    public class Program
    {
        static void Main()
        {
            var logger = Logger.GetLoggerInstance();
            logger.Write("letMeLet", LogType.Error);
            logger.Write("letMeLet", LogType.Message);
            Logger.GetLoggerInstance().Write("", LogType.Message);
            Console.WriteLine("< End >");
            Console.Read();
        }
    }
}