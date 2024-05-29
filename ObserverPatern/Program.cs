
using ObserverPaternJobListings.Observer;
using ObserverPaternJobListings.Subject;

JobPost jobPost = new JobPost();

var seekers = new List<string> { "Alex", "Diana", "Eva", "George", "Frank" };

AddJobSeekers(seekers);

jobPost.AddJob(new Job("Software Engineer"));

RemoveJobSeeker("Diana");
RemoveJobSeeker("Eva");

jobPost.AddJob(new Job("DevOps Engineer"));

AddJobSeeker("George");
AddJobSeeker("Hannah");
AddJobSeeker("Ivy");


jobPost.AddJob(new Job("Data Scientist"));

Console.ReadKey();





void RemoveJobSeeker(string name)
{
    seekers.ForEach(seeker =>
    {
        if (seeker == name)
        {
            jobPost.Detach(new JobSeeker(name));
        }
    });
}

void AddJobSeeker(string name)
{
    jobPost.Attach(new JobSeeker(name));
}

void AddJobSeekers(List<string> names)
{
    names.ForEach(name => jobPost.Attach(new JobSeeker(name)));
}




