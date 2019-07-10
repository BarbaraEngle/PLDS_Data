using System;
using System.ComponentModel.DataAnnotations;

namespace PLDS_Data.Entities.Transfer
{
    public class TransferEntity
    {
        public int TransferId { get; set; }

        public int ServicePackId { get; set; }

        public int TransferStatusId { get; set; }

        public int ProcessId { get; set; }

        public bool IsComplete { get; set; }

        public DateTime CreateDate { get; set; }
    }

    public class TransferDisplayItem
    {
        public int TransferId { get; set; }

        [Display(Name = "TransferReference No")]
        public string JobReferenceNo { get; set; }

        [Display(Name = "Transfer Status")]
        public string JobTransferStatus { get; set; }

        [Display(Name = "Process")]
        public string ProcessDescription { get; set; }

        [Display(Name = "Date and Time Created")]
        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }

        [Display(Name = "Is the Transfer Complete")]
        public string TransferComplete { get; set; }
    }

}
