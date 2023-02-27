namespace Work_space
{
    public abstract class LoggerRecordDecorator
    {
        protected string _file = @"./txt.txt";
        public abstract bool IsWriteMany { set; }
        public virtual void WriteRecord(string msg)
        {
            using (StreamWriter sw = new StreamWriter(_file, append: true))
            {
                sw.WriteLine(msg);
            }
        }
        public virtual async Task WriteAsyncRecord(string msg)
        {
            using (StreamWriter sw = new StreamWriter(_file, append: true))
            {
                await sw.WriteLineAsync(msg);
            }
        }
        protected static string NowDateTime()
        {
            return $"{DateTime.Now:MM/dd/yy H:mm:ss zzz}";
        }
    }
}