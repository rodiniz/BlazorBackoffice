using System;

namespace BackOffice.Dtos
{
    public class MatchingTransactionSearchCriteriaDto
    {
        public string OrderId { get; set; }
        public DateTime? ValidityStartDate { get; set; }
        public DateTime? ValidityEndDate { get; set; }
        public DateTime? ReceptionDate { get; set; }
        public string OperationStatus { get; set; }
    }
}
