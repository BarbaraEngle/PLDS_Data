using System;
using System.Collections.Generic;
using System.Text;

namespace PLDS_Data.Entities.Status
{
    public class StatusEntity
    {
        public int StatusId { get; set; }
        public string StatusDescription {get;set;}
        public int StatusSequenceNo { get; set; }

        public int ProcessStepId { get; set; }
        
        public bool IsBillable { get; set; }
    }

    public class StatusSuccessEntity
    {
        public int StatusSuccessId { get; set; }

        public int StatusId { get; set; }

        public int ContentTypeId { get; set; }

        public string Content { get; set; }

        public bool IsMandatory { get; set; }
    }

    public class StatusQueryEntity
    {
        public int StatusQueryId { get; set; }

        public int StatusId { get; set; }

        public int ContentTypeId { get; set; }

        public string Content { get; set; }

        public bool IsMandatory { get; set; }
    }

}
