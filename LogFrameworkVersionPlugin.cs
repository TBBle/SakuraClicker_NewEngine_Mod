using System;
using IllusionPlugin;

namespace SC_NewEngine_Mod
{
    // IEnhancedPlugin doesn't work, see https://github.com/Eusth/IPA/pull/11
    class LogFrameworkVersionPlugin : IPlugin
    {
        public string[] Filter => new string[] {"Sakura Clicker.exe"};

        public string Name => "LogFrameworkVersion Plugin";

        public string Version => "trivial";

        public void OnApplicationQuit()
        {
        }

        public void OnApplicationStart()
        {
            Console.WriteLine("LogFrameworkVersionPlugin: Running on Framework {0}", Environment.Version);
        }

        public void OnFixedUpdate()
        {
        }

        public void OnLateUpdate()
        {
        }

        public void OnLevelWasInitialized(int level)
        {
        }

        public void OnLevelWasLoaded(int level)
        {
        }

        public void OnUpdate()
        {
        }
    }
}
