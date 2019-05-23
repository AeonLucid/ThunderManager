using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ThunderManager.Core.Manager.Thunderstore.Models
{
    public class ModPackage
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("package_url")]
        public Uri PackageUrl { get; set; }

        [JsonProperty("date_created")]
        public DateTimeOffset DateCreated { get; set; }

        [JsonProperty("date_updated")]
        public DateTimeOffset DateUpdated { get; set; }

        [JsonProperty("uuid4")]
        public Guid Uuid { get; set; }

        [JsonProperty("is_pinned")]
        public bool IsPinned { get; set; }

        [JsonProperty("versions")]
        public List<ModPackageVersion> Versions { get; set; }

        protected bool Equals(ModPackage other)
        {
            return Uuid.Equals(other.Uuid);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ModPackage) obj);
        }

        public override int GetHashCode()
        {
            return Uuid.GetHashCode();
        }
    }
}
