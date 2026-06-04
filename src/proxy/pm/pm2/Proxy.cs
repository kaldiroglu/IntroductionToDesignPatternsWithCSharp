namespace dev.kaldiroglu.dp.intro.proxy.pm.pm2;

// Solution 2: a Proxy stands between Citizen and PM. The Citizen, however, is
// still aware it is talking to a Proxy (its field type is Proxy, not PM).
public class Proxy
{
    private readonly PM pm;

    public Proxy(PM pm)
    {
        this.pm = pm;
    }

    public void Listen(string problem)
    {
        Console.WriteLine("Proxy: Listening to you.");
        if (SortOut(problem))
        {
            Delegate(problem);
        }
    }

    public void FindJob(string name)
    {
        Console.WriteLine("Proxy: 'I'll find out what I can do for you!'");
    }

    private void Delegate(string problem)
    {
        pm.Listen(problem);
    }

    private bool SortOut(string problem)
    {
        bool b = true;
        //...
        return b;
    }
}
