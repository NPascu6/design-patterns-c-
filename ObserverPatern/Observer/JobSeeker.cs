using ObserverPaternJobListings.ObserverInterface;
using ObserverPaternJobListings.Subject;

namespace ObserverPaternJobListings.Observer
{
    internal class JobSeeker : IJobSeeker
    {
        public string Name { get; set; }

        public JobSeeker(string name)
        {
            Name = name;
        }

        public void Notify(Job job)
        {
            Console.WriteLine($"Hi {Name}, new job posted: {job.Description}");
        }
    }
}
