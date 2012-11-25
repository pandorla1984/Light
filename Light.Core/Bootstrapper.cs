using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Light.Core
{
    public class Bootstrapper
    {
        #region Properties
        public MessageBus MessageBus { get; set; }
        public List<LightModule> Modules { get; set; }
        #endregion

        /// <summary>
        /// Construct a boot strapper for Light framework. 
        /// </summary>
        /// <param name="Args">Application init args</param>
        public Bootstrapper(string[] Args)
        {
            MessageBus = new MessageBus();
            Modules = new List<LightModule>();
            LoadAssemblies();
            MessageBus.Run();
        }

        private void LoadAssemblies()
        {
            var modulePathString = AppDomain.CurrentDomain.BaseDirectory + "Modules\\";
            DirectoryInfo di = new DirectoryInfo(modulePathString);
            if (di.Exists)
            {
                var assemblies = di.GetFiles();
                assemblies.Select(ass =>
                {
                    var a = Assembly.LoadFrom(ass.FullName);

                    //find and initialize modules, pass messagebus to it.
                    Modules.AddRange(a.DefinedTypes.Where(t => t.BaseType == typeof(LightModule)).Select(t =>
                    {
                        return (LightModule)Activator.CreateInstance(t.DeclaringType, MessageBus);
                    }));

                    //find receivers and added into message bus
                    var receivers = Modules.Where(m => m is IMessageReceiver).Select(m => (IMessageReceiver)m).ToList();
                    MessageBus.Receivers.AddRange(receivers);
                    return true;
                }).AsParallel();
            }
        }

        #region Init Implementations

        #endregion
    }
}
