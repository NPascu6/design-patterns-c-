namespace ObserverPaternJobListings.Subject
{
    internal class Job
    {
        public string Description { get; set; }

        public Job(string description)
        {
            Description = description;
        }
    }
}
