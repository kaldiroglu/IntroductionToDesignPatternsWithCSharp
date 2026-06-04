namespace dev.kaldiroglu.dp.intro.proxy.pm.pm3;

// The Proxy: implements PM, holds a reference to another PM (the RealPM),
// sorts out what it can and delegates the rest.
public class ProxyPM : PM
{
    private readonly PM pm;

    public ProxyPM(PM pm)
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
