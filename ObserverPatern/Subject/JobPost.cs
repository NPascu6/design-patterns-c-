using ObserverPaternJobListings.ObserverInterface;
using ObserverPaternJobListings.SubjectInterface;

namespace ObserverPaternJobListings.Subject
{
    internal class JobPost : IJobPost
    {
        private List<IJobSeeker> _seekers = new List<IJobSeeker>();

        public void Attach(IJobSeeker jobSeeker)
        {
            _seekers.Add(jobSeeker);
        }

        public void Detach(IJobSeeker jobSeeker)
        {
            _seekers.Remove(jobSeeker);
        }

        public void Notify(Job job)
        {
            foreach (var jobSeeker in _seekers)
            {
                jobSeeker.Notify(job);
            }
        }

        public void AddJob(Job job)
        {
            Console.WriteLine($"Job posted: {job.Description}");
            Console.WriteLine("Notifying job seekers..." + _seekers.Count);
            Notify(job);
        }
    }
}
