using PLDS_Data.Entities.Client;
using PLDS_Data.Entities.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace PLDS_Data.Entities.Job
{
    public class JobEntity
    {
        public int JobId { get; set; }

        public string JobReferenceNo { get; set; }

        public int? AssignedToId { get; set; }

        public UserEntity AssignedTo { get; set; } = new UserEntity();

        public DateTime CreateDate { get; set; }

        public string ClientReference { get; set; }

        public int ClientId { get; set; }

        public int? ClientContactId { get; set; }

    }

    public class JobDisplayItem
    {
        public int JobId { get; set; }

        public int ClientId { get; set; }

        [Display(Name = "Job Reference No")]
        public string JobReferenceNo { get; set; }

        [Display(Name = "Client")]
        public string ClientName { get; set; }

        [Display(Name ="Client Reference")]
        public string ClientReference { get; set; }

        [Display(Name = "Job Assigned To")]
        public string AssignedToName { get; set; }

        [Display(Name = "Date Created")]
        [DataType(DataType.DateTime)]
        public string CreateDate { get; set; }

        [Display(Name = "Job Status")]
        public string Status { get; set; }

        [Display(Name = "Job Status Date")]
        [DataType(DataType.DateTime)]
        public DateTime StatusDate { get; set; }

        public ButtonDefinition ActionButton { get; set; }

        public ButtonDefinition ConfirmButton { get; set; }

        public ButtonDefinition CancelButton { get; set; }

    }
}
