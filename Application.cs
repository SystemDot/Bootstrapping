namespace SystemDot.Bootstrapping
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;

    public class Application : IApplication
    {
        public IEnumerable<Type> GetAllTypes() => GetAssemblies().SelectMany(GetTypes);

        IEnumerable<Type> GetTypes(Assembly assembly)
        {
            if (assembly.IsDynamic) return new List<Type>();

            try
            {
                return assembly.ExportedTypes;
            }
            catch (FileLoadException)
            {
                return new List<Type>();
            }
            catch (NotSupportedException)
            {
                return new List<Type>();
            }
        }

        IEnumerable<Assembly> GetAssemblies() =>
            AppDomain.CurrentDomain.GetAssemblies();
    }
}