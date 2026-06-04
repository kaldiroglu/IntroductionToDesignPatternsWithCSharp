namespace dev.kaldiroglu.dp.intro.proxy.pm.pm1;

// Mirrors Main in the Java pm1 package.
public static class Demo
{
    public static void Run()
    {
        PM pm = new();
        Citizen citizen = new("John", pm);
        citizen.TellProblem();
        citizen.AskForJob();
    }
}
