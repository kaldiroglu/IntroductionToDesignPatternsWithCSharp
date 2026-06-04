namespace dev.kaldiroglu.dp.intro.proxy.pm.pm2;

// Solution 2: the PM now only resolves; sorting out has moved to the Proxy.
public class PM
{
    public void Listen(string problem)
    {
        Console.WriteLine("PM: Listening to you.");
        Resolve(problem);
    }

    public void FindJob(string name)
    {
        Console.WriteLine("PM: Don't ask me to find a job for you!");
    }

    private void Resolve(string problem)
    {
        Console.WriteLine("PM: Please resolve this: " + problem);
    }
}
