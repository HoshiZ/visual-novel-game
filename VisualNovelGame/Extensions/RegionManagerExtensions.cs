using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualNovelGame.Extensions
{
    public static class RegionManagerExtensions
    {
        public static void RemoveRegionsWithPrefix(this IRegionManager regionManager, string prefix)
        {
            var regionNamesToRemove = regionManager.Regions.Where(r => r.Name.StartsWith(prefix)).Select(r => r.Name).ToList();

            foreach (var regionName in regionNamesToRemove)
            {
                if (regionManager.Regions.ContainsRegionWithName(regionName))
                {
                    regionManager.Regions.Remove(regionName);
                }
            }
        }
    }
}
