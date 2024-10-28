using System.Collections.Specialized;

namespace System.Configuration
{
    internal class ConfigurationManager
    {
        private static ConnectionStringSettingsCollection connectionStrings;

        static ConfigurationManager()
        {
            connectionStrings = new ConnectionStringSettingsCollection();
            
            connectionStrings.Add(new ConnectionStringSettings("PeliculaDB", "your_connection_string_here"));
        }

        public static ConnectionStringSettingsCollection ConnectionStrings
        {
            get { return connectionStrings; }
        }
    }

    public class ConnectionStringSettingsCollection : NameObjectCollectionBase
    {
        public void Add(ConnectionStringSettings settings)
        {
            BaseAdd(settings.Name, settings);
        }

        public ConnectionStringSettings this[string name]
        {
            get { return (ConnectionStringSettings)BaseGet(name); }
        }
    }

    public class ConnectionStringSettings
    {
        public string Name { get; }
        public string ConnectionString { get; }

        public ConnectionStringSettings(string name, string connectionString)
        {
            Name = name;
            ConnectionString = connectionString;
        }
    }
}
