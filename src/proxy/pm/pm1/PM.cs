namespace dev.kaldiroglu.dp.intro.proxy.pm.pm1;

// Solution 1: PM is a concrete class the Citizen depends on directly.
// Note its low cohesion — it both sorts out and resolves problems.
public class PM
{
    public void Listen(string problem)
    {
        Console.WriteLine("PM: Listening to you.");
        if (SortOut(problem))
        {
            Resolve(problem);
        }
    }

    public void FindJob(string name)
    {
        Console.WriteLine("PM: Don't ask me to find a job for you!");
    }

    private bool SortOut(string problem)
    {
        bool b = true;
        //...
        return b;
    }

    private void Resolve(string problem)
    {
        Console.WriteLine("PM: Please resolve this: " + problem);
    }
}
