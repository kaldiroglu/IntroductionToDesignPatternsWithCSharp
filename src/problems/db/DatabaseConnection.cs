namespace dev.kaldiroglu.dp.intro.problems.db;

/// <summary>
/// Faithful port of the Java DatabaseConnection. It deliberately demonstrates the
/// "telescoping constructor" problem (plus post-construction setters) that the
/// <b>Builder</b> pattern is meant to solve. Java getters/setters become C#
/// auto-properties; the overloaded constructors are kept exactly as in the source.
/// </summary>
public class DatabaseConnection
{
    public string? Host { get; set; }
    public int Port { get; set; }
    public string? Database { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public bool UseSSL { get; set; }
    public int ConnectionTimeout { get; set; }
    public int ReadTimeout { get; set; }
    public string? Charset { get; set; }
    public bool AutoReconnect { get; set; }
    public int MaxRetries { get; set; }
    public string? ConnectionPool { get; set; }
    public bool EnableLogging { get; set; }
    public string? LogLevel { get; set; }
    public string? Timezone { get; set; }

    // Default constructor for post-construction initialization
    public DatabaseConnection()
    {
        // Set reasonable defaults
        Port = 3306;
        UseSSL = true;
        ConnectionTimeout = 30000;
        ReadTimeout = 60000;
        Charset = "UTF-8";
        AutoReconnect = true;
        MaxRetries = 3;
        EnableLogging = false;
        LogLevel = "INFO";
    }

    // Imagine if we tried to use constructors for all combinations:

    // Constructor for basic connection
    public DatabaseConnection(string host, string database, string username, string password)
        : this()
    {
        Host = host;
        Database = database;
        Username = username;
        Password = password;
    }

    // Constructor with port
    public DatabaseConnection(string host, int port, string database, string username, string password)
        : this(host, database, username, password)
    {
        Port = port;
    }

    // Constructor with SSL option
    public DatabaseConnection(string host, int port, string database, string username, string password, bool useSSL)
        : this(host, port, database, username, password)
    {
        UseSSL = useSSL;
    }

    // Constructor with timeouts... this quickly becomes unmanageable!
    public DatabaseConnection(string host, int port, string database, string username, string password,
                              bool useSSL, int connectionTimeout, int readTimeout)
        : this(host, port, database, username, password, useSSL)
    {
        ConnectionTimeout = connectionTimeout;
        ReadTimeout = readTimeout;
    }

    // We'd need dozens more constructors to cover all meaningful combinations!
    // What if someone wants SSL=true, custom charset, but default timeouts?
    // What if they want custom logging but default connection settings?

    // C#-port convenience (not in the Java original): a readable one-line summary so the
    // demo can show what each scenario produced.
    public override string ToString() =>
        $"DatabaseConnection[host={Host}, port={Port}, database={Database}, useSSL={UseSSL}, " +
        $"connectionTimeout={ConnectionTimeout}, readTimeout={ReadTimeout}, charset={Charset}, " +
        $"autoReconnect={AutoReconnect}, maxRetries={MaxRetries}, connectionPool={ConnectionPool}, " +
        $"enableLogging={EnableLogging}, logLevel={LogLevel}, timezone={Timezone}]";
}

/*
Why constructors would be problematic here:

1. COMBINATORIAL EXPLOSION: With 15 properties, we'd need potentially
   hundreds of constructor overloads to cover meaningful combinations.

2. PARAMETER CONFUSION: A constructor with 8+ parameters becomes error-prone:
   DatabaseConnection(host, port, database, username, password, useSSL, timeout1, timeout2)
   // Which timeout is which? Easy to mix up port and timeout values!

3. MEANINGLESS COMBINATIONS: Not every combination makes sense to have
   a dedicated constructor for.

4. MAINTENANCE NIGHTMARE: Adding one new property means potentially
   adding dozens of new constructors.

5. UNCLEAR INTENT: Post-construction initialization makes it clear
   which properties are being customized for each use case.

6. FLEXIBILITY: Easy to create different "profiles" of connections
   without predefined constructors.
*/
