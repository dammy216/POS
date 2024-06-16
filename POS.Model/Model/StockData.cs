using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model.Model
{
    public class StockData
    {
        public string Name {  get; set; }
        public DateTime PurchaseDate { get; set; }
        public int PurchasePrice {  get; set; }
        public int SallesPrice {  get; set; }
        public int StockAmount { get; set; }

        public StockData(string name, int stockAmount ,int purchasePrice, int sallesPrice )
        {
            Name = name;
            PurchaseDate = DateTime.Today;
            PurchasePrice = purchasePrice;
            SallesPrice = sallesPrice;
            StockAmount = stockAmount;
        }
    }
}
