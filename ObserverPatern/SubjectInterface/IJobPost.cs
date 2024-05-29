using ObserverPaternJobListings.ObserverInterface;
using ObserverPaternJobListings.Subject;

namespace ObserverPaternJobListings.SubjectInterface
{
    internal interface IJobPost
    {
        void Attach(IJobSeeker jobSeeker);
        void Detach(IJobSeeker jobSeeker);
        void Notify(Job job);
    }
}
