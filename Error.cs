using System.Threading.Tasks;
namespace Work_space
{
    public class Error : LoggerRecordDecorator
    {
        public override bool IsWriteMany
        {
            set
            {
                if (value)
                    _file = @"./error.txt";
            }
        }
        public Error()
        {
        }

        public Error(bool writeToMany)
        {
            if (writeToMany)
                _file = @"./error.txt";
        }
        public override void WriteRecord(string msg)
        {
            base.WriteRecord($"[Error]\t{NowDateTime()}\t{msg}");
        }
        public override async Task WriteAsyncRecord(string msg)
        {
            await base.WriteAsyncRecord($"[Error]\t{NowDateTime()}\t{msg}");
        }
    }
}