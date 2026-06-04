namespace dev.kaldiroglu.dp.intro.problems.db;

/// <summary>
/// Mirrors the Java <c>db/Main</c>: builds four connection "profiles" purely through
/// the default constructor + setters, illustrating the post-construction-initialization
/// smell. The Java Main produced no output; this port prints each result so the demo is
/// observable and testable.
/// </summary>
public static class Demo
{
    public static void Run()
    {
        // Scenario 1: Basic local development connection
        DatabaseConnection devConn = new DatabaseConnection();
        devConn.Host = "localhost";
        devConn.Database = "myapp_dev";
        devConn.Username = "dev_user";
        devConn.Password = "dev_pass";

        // Scenario 2: Production connection with custom security and timeouts
        DatabaseConnection prodConn = new DatabaseConnection();
        prodConn.Host = "prod-db-cluster.company.com";
        prodConn.Port = 5432;  // PostgreSQL
        prodConn.Database = "myapp_production";
        prodConn.Username = "prod_user";
        prodConn.Password = "complex_secure_password";
        prodConn.UseSSL = true;
        prodConn.ConnectionTimeout = 10000;
        prodConn.ReadTimeout = 120000;
        prodConn.ConnectionPool = "HikariCP";
        prodConn.EnableLogging = true;

        // Scenario 3: Testing connection with specific charset and no SSL
        DatabaseConnection testConn = new DatabaseConnection();
        testConn.Host = "test-server";
        testConn.Database = "test_db";
        testConn.Username = "test_user";
        testConn.Password = "test_pass";
        testConn.UseSSL = false;
        testConn.Charset = "UTF-8";
        testConn.AutoReconnect = false;

        // Scenario 4: Analytics connection with custom timezone and logging
        DatabaseConnection analyticsConn = new DatabaseConnection();
        analyticsConn.Host = "analytics-db";
        analyticsConn.Database = "warehouse";
        analyticsConn.Username = "analytics_user";
        analyticsConn.Password = "analytics_pass";
        analyticsConn.Timezone = "UTC";
        analyticsConn.EnableLogging = true;
        analyticsConn.LogLevel = "DEBUG";
        analyticsConn.ReadTimeout = 300000; // 5 minutes for long queries

        Console.WriteLine("Dev:       " + devConn);
        Console.WriteLine("Prod:      " + prodConn);
        Console.WriteLine("Test:      " + testConn);
        Console.WriteLine("Analytics: " + analyticsConn);
    }
}
