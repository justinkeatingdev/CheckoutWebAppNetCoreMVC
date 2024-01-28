using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.NetworkInformation;

namespace ShoppingCartCSET4100.Models
{
    public class Item
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public string ItemNameAndCost => $"{ItemName} - ${ItemPrice}";

        public Item (string itemName, double itemPrice)
        {
            ItemName = itemName;
            ItemPrice = itemPrice;
        }
        public static List<Item> GetGiftCardItems()
        {
            List<Item> giftCardItems = new List<Item>()
            {
                new Item("Mastercard Gift Card",100.00),
                new Item("Amazon eGift Card",50.00),
                new Item("Visa Gift Card",200.00),
                new Item("Uber Gift Card",25.00)
            };
            return giftCardItems;
        }
        public static List<Item> GetToyItems()
        {
            List<Item> toyItems = new List<Item>()
            {
               new Item("Bubble Blower for Children", 12.99), 
                new Item("Pandemic Board Game", 16.00), 
                new Item("Maracas", 16.15), 
                new Item("Pokemon Assorted Cards", 8.50)

            };
            return toyItems;
        }
        public static List<Item> GetCellItems()
        {
            List<Item> cellItems = new List<Item>()
            {
                new Item("Waterproof Case", 12.99),
                new Item("USB Wall Charger", 10.99),
                new Item("Car Phone Mount", 24.95),
                new Item("Apple MagSafe Charger", 34.00)
            };
            return cellItems;
        }
        public static List<Item> GetSoftwareItems()
        {
            List<Item> softwareItems = new List<Item>()
            {
                new Item("Microsoft 365 Personal", 58.99),
                new Item("Adobe Creative Cloud Photograph Plan", 9.99),
                new Item("Norton 360 Deluxe", 34.99),
                new Item("QuickBooks Desktop", 199.99)
            };
            return softwareItems;
        }
        public static List<Item> GetOutdoorItems()
        {
            List<Item> outdoorItems = new List<Item>()
            {
                new Item("Mosquito Repeller",19.58),
                new Item("Folding Chair", 63.96),
                new Item("Folding Chair", 5.89),
                new Item("Camping Hammock", 19.54)
            };
            return outdoorItems;
        }

        public static List<Item> GetAllItems() {
            var giftCardItems = Item.GetGiftCardItems();
            var toyItems = Item.GetToyItems();
            var cellItems = Item.GetCellItems();
            var softwareItems = Item.GetSoftwareItems();
            var outdoorItems = Item.GetOutdoorItems();
            var allItems = giftCardItems.Concat(toyItems).Concat(cellItems).Concat(softwareItems).Concat(outdoorItems);


            return allItems.ToList();
        }
       

    }
}
