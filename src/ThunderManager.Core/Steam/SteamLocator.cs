using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ThunderManager.Core.Steam
{
    public class SteamLocator
    {
        private static readonly string[] SteamRegistryKeys = {
            "HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Steam",
            "HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Valve\\Steam"
        };

        private string _steamInstallPath;
        private readonly List<string> _steamLibraries;

        public SteamLocator()
        {
            _steamInstallPath = null;
            _steamLibraries = new List<string>();

            Status = SteamLocatorStatus.Uninitialized;
        }

        public SteamLocatorStatus Status { get; private set; }

        public bool Initialize()
        {
            if (!FindSteamPath())
            {
                Status = SteamLocatorStatus.ErrorInstallPath;
                return false;
            }

            if (!FindSteamLibraries())
            {
                Status = SteamLocatorStatus.ErrorLibraries;
                return false;
            }

            Status = SteamLocatorStatus.Ready;
            return true;
        }
        
        public string GetAppIdFolder(uint appId)
        {
            if (Status != SteamLocatorStatus.Ready)
            {
                throw new SteamLocatorException("SteamLocator was not initialized properly.");
            }
            
            foreach (var steamLibrary in _steamLibraries)
            {
                var appManifestPath = Path.Combine(steamLibrary, $"appmanifest_{appId}.acf");
                
                // Found a manifest.
                if (File.Exists(appManifestPath))
                {
                    var appManifest = File.ReadAllText(appManifestPath);
                    var appInstallDirName = Regex.Match(appManifest, @"""installdir""\s+""(.*?)""").Groups[1].Value;
                    var appInstallDir = Path.Combine(steamLibrary, "common", appInstallDirName);

                    return appInstallDir;
                }
            }

            // Unable to find path.
            return null;
        }

        /// <summary>
        ///     Find Steam installation path.
        /// </summary>
        /// <returns></returns>
        private bool FindSteamPath()
        {
            foreach (var key in SteamRegistryKeys)
            {
                _steamInstallPath = Registry.GetValue(key, "InstallPath", null) as string;
                    
                if (_steamInstallPath != null)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        ///     Find Steam libraries.
        /// </summary>
        /// <returns></returns>
        private bool FindSteamLibraries()
        {
            var steamApps = Path.Combine(_steamInstallPath, "steamapps");
            
            _steamLibraries.Clear();
            _steamLibraries.Add(steamApps);
            
            // Find other library folders from 'libraryfolders.vdf'.
            var libraryFolders = File.ReadAllText(Path.Combine(steamApps, "libraryfolders.vdf"));
            var libraryMatches = Regex.Matches(libraryFolders, @"""\d""\s+""(?<path>.*?)""");
            
            foreach (Match match in libraryMatches)
            {
                var libraryPath = match.Groups["path"].Value.Replace(@"\\", "\\");
                
                _steamLibraries.Add(Path.Combine(libraryPath, "steamapps"));
            }
            
            return true;
        }
    }
}