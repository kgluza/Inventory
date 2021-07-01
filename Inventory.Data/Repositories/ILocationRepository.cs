using Inventory.Data.Dto;
using System.Collections.Generic;

namespace Inventory.Data
{
    public interface ILocationRepository
    {
        List<Location> GetLocations(string id = null, string name = null);

        Location GetLocationById(int locationId);

        void AddLocation(Location location);

        void DeleteLocation(int locationId);

        void UpdateLocation(Location location);
    }
}
