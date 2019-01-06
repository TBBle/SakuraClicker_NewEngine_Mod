using System;
using IllusionPlugin;
using UnityEngine;
using WingedCloud.ClickerCore;

namespace SC_NewEngine_Mod
{
    class MinimumSpiritsPlugin : IPlugin
    {
        public string Name => "MinimumSpirits Plugin";

        public string Version => "0.1";

        public void OnApplicationQuit()
        {
        }

        public void OnApplicationStart()
        {
        }

        public void OnFixedUpdate()
        {
            var coreManager = GameObject.FindObjectOfType<ClickerCoreManager>();
            var playerManager = coreManager.PlayerManager;
            const int minimumSpirits = 10000;
            if (playerManager.Spirits < minimumSpirits)
            {
                Console.WriteLine("MinimumSpirits: Resetting to {0} spirits", minimumSpirits);
                playerManager.Spirits = minimumSpirits;
            }
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
