public static class Consts
{
    private static string _connectionString;
    private static bool _initialized = false;

    public static string ConnectionString
    {
        get
        {
            if (!_initialized || string.IsNullOrEmpty(_connectionString))
            {
                throw new InvalidOperationException(
                    "Connection string has not been initialized. Call Initialize() first.");
            }
            return _connectionString;
        }
        private set
        {
            _connectionString = value;
            _initialized = true;
        }
    }

    public static void Initialize(IConfiguration configuration)
    {
        if (configuration == null)
            throw new ArgumentNullException(nameof(configuration));

        var connStr = configuration.GetConnectionString("Default");

        if (string.IsNullOrEmpty(connStr))
            throw new InvalidOperationException(
                "Connection string 'Default' not found in configuration");

        ConnectionString = connStr;
    }
}
