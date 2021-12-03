namespace Models
{
    public class PilotProject
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<Contact> Team { get; set; }

        public DateTime InitializationDate { get; set; }

        public Guid ProjectStageId { get; set; }

        public ProjectStage ProjectStage { get; set; }

        public Guid PilotTestingPhaseId { get; set; }

        public PilotTestingPhase PilotTestingPhase { get; set; }

        public string SubordinateOrganization { get; set; }
    }
}
