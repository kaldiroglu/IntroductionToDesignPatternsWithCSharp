namespace dev.kaldiroglu.dp.intro.proxy.pm.pm2;

public class Citizen
{
    private readonly string name;
    private readonly Proxy proxy;

    public Citizen(string name, Proxy proxy)
    {
        this.name = name;
        this.proxy = proxy;
    }

    public void TellProblem()
    {
        proxy.Listen("The problem is ...");
    }

    public void AskForJob()
    {
        proxy.FindJob(name);
    }
}
