using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ThunderManager.Core.Extensions;
using ThunderManager.Core.Manager.Thunderstore;
using ThunderManager.Core.Manager.Thunderstore.Models;
using ThunderManager.Core.Steam;

namespace ThunderManager.Core.Manager
{
    public class ModManager
    {
        private readonly SteamLocator _steam;
        private readonly ThunderstoreClient _thunderstoreClient;

        public ModManager()
        {
            _steam = new SteamLocator();
            _thunderstoreClient = new ThunderstoreClient();

            Mods = new HashSet<ModPackage>();
        }

        public HashSet<ModPackage> Mods { get; }

        public async Task InitializeAsync()
        {
            // Initialize SteamLocator.
            if (!_steam.Initialize())
            {
                throw new ModManagerException($"Failed to initialize SteamLocator, status: '{_steam.Status}'.");
            }

            // Fetch initial mods.
            Mods.UnionWith(await _thunderstoreClient.GetPackagesAsync());
            ModsSynced?.AsyncSafeInvoke(this, EventArgs.Empty);
        }

        public event EventHandler<EventArgs> ModsSynced;
    }
}
