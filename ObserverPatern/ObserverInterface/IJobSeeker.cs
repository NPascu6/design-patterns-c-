using ObserverPaternJobListings.Subject;

namespace ObserverPaternJobListings.ObserverInterface
{
    internal interface IJobSeeker
    {
        void Notify(Job job);
    }
}
