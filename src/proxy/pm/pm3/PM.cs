namespace dev.kaldiroglu.dp.intro.proxy.pm.pm3;

// Solution 3: PM is now an interface (the Subject). The Citizen depends on it,
// so ProxyPM and RealPM are interchangeable behind it.
// (Kept as `PM`, not `IPM`, to match the Java source and the slides.)
public interface PM
{
    void Listen(string problem);
    void FindJob(string name);
}
