namespace dev.kaldiroglu.dp.intro.proxy.pm.pm3;

// Mirrors Main in the Java pm3 package.
public static class Demo
{
    public static void Run()
    {
        Console.WriteLine("Everything starts with a citizen coming to PM Secretary and asking for PM");
        PMSecretary secretary = new();
        Citizen citizen = new("John", secretary);
        citizen.TellProblem();
        citizen.AskForJob();
    }
}
