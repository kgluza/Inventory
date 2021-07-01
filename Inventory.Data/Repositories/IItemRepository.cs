using Inventory.Data.Dto;
using System.Collections.Generic;
using System.IO;

namespace Inventory.Data
{
    public interface IItemRepository
    {
        List<Item> GetItems(string id = null, string name = null, string categoryName = null, string locationName = null, string serialNumber = null);

        Item GetItemById(int itemId);

        void AddItem(Item item);

        void DeleteItem(int itemId);

        void UpdateItem(Item item);

        void UploadDocument(int itemId, string filePath);

        List<Document> GetDocuments(int itemId);
    }
}
