using System;

namespace ThunderManager.Models
{
    public class ModItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public ulong Downloads { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
