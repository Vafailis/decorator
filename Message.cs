namespace Work_space
{
    public class Message : LoggerRecordDecorator
    {
        public override bool IsWriteMany
        {
            set
            {
                if (value)
                {
                    _file = @"./message.txt";
                }
            }
        }
        public Message()
        {
        }
        public Message(bool writeToMany)
        {
            if (writeToMany)
                _file = @"./message.txt";
        }
        public override void WriteRecord(string msg)
        {
            base.WriteRecord($"[Message]\t{NowDateTime()}\t{msg}");
        }
        public override async Task WriteAsyncRecord(string msg)
        {
            await base.WriteAsyncRecord($"[Message]\t{NowDateTime()}\t{msg}");
        }
    }
}