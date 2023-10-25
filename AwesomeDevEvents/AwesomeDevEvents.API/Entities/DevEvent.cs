namespace AwesomeDevEvents.API.Entities
{
    public class DevEvent
    {
        public DevEvent()
        {
            Speakers = new List<DevEventSpeaker>();
            IsDeleted = false;
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<DevEventSpeaker> Speakers { get; set; }
        public bool IsDeleted { get; set; }

        public void Udpate(string title,string descripton, DateTime startDate,DateTime endDate)
        {
            Title = title;
            Description = descripton;
            StartDate = startDate;
            EndDate = endDate;
        }
        public void Delete()
        {
            IsDeleted = true;
        }
    }
}
