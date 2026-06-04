using Pm1 = dev.kaldiroglu.dp.intro.proxy.pm.pm1;
using Pm2 = dev.kaldiroglu.dp.intro.proxy.pm.pm2;
using Pm3 = dev.kaldiroglu.dp.intro.proxy.pm.pm3;
using Db = dev.kaldiroglu.dp.intro.problems.db;

// The three stages of the Proxy exercise, mirroring the pm1/pm2/pm3 Mains in the Java repo.

Console.WriteLine("===== Solution 1 (pm1): Citizen -> PM =====");
Pm1.Demo.Run();

Console.WriteLine();
Console.WriteLine("===== Solution 2 (pm2): Citizen -> Proxy -> PM =====");
Pm2.Demo.Run();

Console.WriteLine();
Console.WriteLine("===== Solution 3 (pm3): Citizen -> ProxyPM -> RealPM (served by PMSecretary) =====");
Pm3.Demo.Run();

// The "complex object construction" problem, mirroring the Java db/Main.
// (The complexObject example has no Main in the Java repo, so it stays compile-only.)
Console.WriteLine();
Console.WriteLine("===== Problem: telescoping constructors / post-construction setters (db) =====");
Db.Demo.Run();
