using System;
using System.Reflection;
using Serilog.Core;
using Serilog.Events;

namespace ContosoUniversity.WithSerilog.Serilog
{
    public class SourceSystemInformationalVersionEnricher<T> : SourceSystemInformationalVersionEnricher
    {
        public SourceSystemInformationalVersionEnricher()
            : base(typeof(T).GetTypeInfo().Assembly)

        {
        }
    }
    
    public class SourceSystemInformationalVersionEnricher : ILogEventEnricher
    {
        private readonly string _version;

        public SourceSystemInformationalVersionEnricher(Assembly assembly)
        {
            if (assembly == null)
                throw new ArgumentNullException(nameof(assembly));

            try
            {
                _version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
            }
            catch (Exception)
            {
                // ignored
            }
        }

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            if (string.IsNullOrWhiteSpace(_version))
                return;

            logEvent.AddPropertyIfAbsent(propertyFactory.CreateProperty("SourceSystemInformationalVersion", _version));
        }
    }
}