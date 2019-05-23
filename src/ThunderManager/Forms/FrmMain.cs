using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using ThunderManager.Core.Manager;
using ThunderManager.Extensions;
using ThunderManager.Models;

namespace ThunderManager.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            lvModsThunderstore.PrimarySortColumn = olvColumnUpdated;
            lvModsThunderstore.PrimarySortOrder = SortOrder.Descending;

            olvColumnUpdated.AspectToStringFormat = "{0:d}";

            ModManager = new ModManager();
            ModManager.ModsSynced += ModManagerOnModsSynced;
        }

        private ModManager ModManager { get; }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            await ModManager.InitializeAsync();
        }

        private void ModManagerOnModsSynced(object sender, EventArgs e)
        {
            this.InvokeIfRequired(() =>
            {
                var rand = new Random();
                var mods = ModManager.Mods.Select(x =>
                {
                    var version = x.Versions.First();

                    return new ModItem
                    {
                        Id = x.Uuid,
                        Name = x.Name,
                        Version = version.VersionNumber,
                        Downloads = x.Versions.Aggregate(0UL, (a, b) => a + b.Downloads),
                        CreatedAt = x.DateCreated,
                        UpdatedAt = x.DateUpdated
                    };
                });

                lvModsThunderstore.SetObjects(mods);
            });
        }

        private void OpenWebsiteTsMenuItem_Click(object sender, EventArgs e)
        {
            if (lvModsThunderstore.SelectedObject == null) return;

            var modItem = (ModItem)lvModsThunderstore.SelectedObject;
            var modPackage = ModManager.Mods.First(x => x.Uuid == modItem.Id);
            var modUrl = modPackage.PackageUrl.ToString();

            Process.Start(modUrl);
        }
    }
}
