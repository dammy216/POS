using POS.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model.Managers
{
    public class StockManager
    {
        private List<StockData> _stockList = new List<StockData>();
        public List<StockData> StockList { get { return _stockList; } }

        public void AddStock(string stockName, int stockAmount, int purchasePrice, int sallesPrice)
        {
            var stockData = new StockData(stockName, stockAmount, purchasePrice, sallesPrice);
            _stockList.Add(stockData);
        }
    }
}
