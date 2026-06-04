namespace dev.kaldiroglu.dp.intro.proxy.pm.pm3;

// A small factory that serves a PM to the Citizen. The Citizen receives a
// ProxyPM (typed as PM) wrapping a RealPM. GetMePM is internal, mirroring the
// package-private getMePM() in the Java source.
public class PMSecretary
{
    private readonly PM pm = new ProxyPM(new RealPM());

    internal PM GetMePM()
    {
        return pm;
    }
}
