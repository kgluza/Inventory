using System.IO;

namespace Inventory.Data.Dto
{
    public class Document
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public string FileName { get; set; }

        public byte[] Content { get; set; }
    }
}
