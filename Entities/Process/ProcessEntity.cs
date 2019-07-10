namespace PLDS_Data.Entities.Process
{
    public class ProcessTypeEntity
    {
        public int ProcessTypeId { get; set; }
        public string ProcessTypeDescription { get; set; }
        public bool IsSystemProcessType { get; set; } = false;
    }
    public class ProcessEntity
    {
        public int ProcessId { get; set; }

        public string ProcessDescription { get; set; }

        public int ProcessTypeId { get; set; }

        public int ProcessSequence { get; set; }

        public bool IsSystemProcess { get; set; } = false;

    }
    public class ProcessStepEntity
    {
        public int ProcessStepId { get; set; }

        public string ProcessStepDescription { get; set; }

        public int ProcessStepSequenceNo { get; set; }

        public bool IsSystemStep { get; set; } = false;

        public int ProcessId { get; set; }
    }
}
