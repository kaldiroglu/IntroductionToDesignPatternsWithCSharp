namespace dev.kaldiroglu.dp.intro.proxy.pm.pm3;

public class Citizen
{
    private readonly string name;
    private readonly PM pm;

    public Citizen(string name, PMSecretary secretary)
    {
        this.name = name;
        this.pm = secretary.GetMePM();
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
