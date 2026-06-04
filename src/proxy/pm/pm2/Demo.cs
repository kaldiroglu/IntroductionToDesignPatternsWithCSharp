namespace dev.kaldiroglu.dp.intro.proxy.pm.pm2;

// Mirrors Main in the Java pm2 package.
public static class Demo
{
    public static void Run()
    {
        PM pm = new();
        Proxy proxy = new(pm);
        Citizen citizen = new("John", proxy);
        citizen.TellProblem();
        citizen.AskForJob();
    }
}
