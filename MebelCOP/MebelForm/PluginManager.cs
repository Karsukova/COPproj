using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryPlugin;
using System.IO;
using System.Reflection;

namespace MebelForm
{
    public class PluginManager
    {
        public string PluginPath { get; }

        public PluginManager(string pluginPath)
        {
            PluginPath = pluginPath;
        }

        public List<IPlugin> GetPlugins()
        {
            var pluginDirectory = new DirectoryInfo(PluginPath);
            if (!pluginDirectory.Exists)
                pluginDirectory.Create();

            var plugins = new List<IPlugin>();
            var pluginFiles = Directory.GetFiles(PluginPath, "*.dll");
            foreach (var file in pluginFiles)
            {
                var asm = Assembly.LoadFrom(file);
                var types = asm.GetTypes().
                    Where(t => t.GetInterfaces().
                        Where(i => i.FullName == typeof(IPlugin).FullName).Any());

                foreach (var type in types)
                {
                    var plugin = asm.CreateInstance(type.FullName) as IPlugin;
                    plugins.Add(plugin);
                }
            }

            return plugins;
        }
    }
}
