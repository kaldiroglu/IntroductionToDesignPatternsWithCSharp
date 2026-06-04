namespace dev.kaldiroglu.dp.intro.proxy.pm.pm1;

public class Citizen
{
    private readonly string name;
    private readonly PM pm;

    public Citizen(string name, PM pm)
    {
        this.name = name;
        this.pm = pm;
    }

    public void TellProblem()
    {
        pm.Listen("The problem is ...");
    }

    public void AskForJob()
    {
        pm.FindJob(name);
    }
}
