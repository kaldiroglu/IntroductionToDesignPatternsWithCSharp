namespace dev.kaldiroglu.dp.intro.proxy.pm.pm3;

// The RealSubject: the actual Prime Minister.
public class RealPM : PM
{
    public void Listen(string problem)
    {
        Console.WriteLine("RealPM: Listening to you.");
        Resolve(problem);
    }

    public void FindJob(string name)
    {
        Console.WriteLine("RealPM: Don't ask me to find a job for you!");
    }

    private void Resolve(string problem)
    {
        Console.WriteLine("RealPM: Please resolve this: " + problem);
    }
}
