namespace BackOffice.Dtos
{
    public class MatchingTransactionDto
    {
        public string Partner { get; set; }
        public string PartnerDomain { get; set; }
        public string AppUserId { get; set; }
        public string OrderId { get; set; }
        public string OperationType { get; set; }
        public string ValueDate { get; set; }
        public string ValueHour { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal NetAmount { get; set; }
        public string OperationStatus { get; set; }
        public string MatchStatus { get; set; }
        public string MatchDate { get; set; }
        public decimal Commission { get; set; }
        public string FileReceptionDate { get; set; }
    }
}
