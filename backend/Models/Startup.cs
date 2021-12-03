namespace Models
{
    public class Startup
    {
        public Guid Id { get; set; }

        public string ImageSrc { get; set; }

        public string TeamName { get; set; }

        public string ReadyStage { get; set; }

        public string Description { get; set; }

        public string ProductUsageStage { get; set; }

        public string ProductBenefit { get; set; }

        public string MoscowTransportOrganosation { get; set; }

        public string RequestAccelerator { get; set; }

        public bool IsNeedSertification { get; set; }

        public bool PilotProjectExists { get; set; }

        public Guid ContactId { get; set; }

        public Contact Contact { get; set; }

        public Guid AccountId { get; set; }

        public Account Account { get; set; }
        
        public string Site { get; set; }
    }
}
