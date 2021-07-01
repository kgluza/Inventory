namespace Inventory.Data.Dto
{
    public class Item
    { 
        public int? Id { get; set; }

        public string Name { get; set; }

        public string SerialNumber { get; set; }

        public int CategoryId { get; set; }
        
        public string CategoryName { get; set; }

        public int LocationId { get; set; }

        public string LocationName { get; set; }
    }
}
