﻿using StardewModdingAPI;
using StardewValley;
using System.Collections.Generic;

namespace ContentPatcherEditor
{
    internal class MyManifest
    {
        public string Name;

        public string Description;

        public string Author;

        public System.Version Version;

        public System.Version MinimumApiVersion;

        public string UniqueID;

        public ManifestContentPackFor ContentPackFor = new ManifestContentPackFor()
        {
            UniqueID = "Pathoschild.ContentPatcher"
        };

        public ManifestDependency[] Dependencies = new ManifestDependency[] 
        {
            new ManifestDependency()
            {
                UniqueID = "Pathoschild.ContentPatcher",
                IsRequired = true
            }
        };

        public string[] UpdateKeys;

        public Dictionary<string, object> ExtraFields;
    }
}