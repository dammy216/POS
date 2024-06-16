using POS.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model.Managers
{
    public class SalledManager
    {
        private List<SalledData> _salledList = new List<SalledData>();
        public List<SalledData> SalledList { get {  return _salledList; } }

        public void AddStock(string salledName, int salledPrice, int salledAmount)
        {
            var salledData = new SalledData(salledName, salledPrice, salledAmount, CalcSubTotal(salledPrice, salledAmount));
            _salledList.Add(salledData);
        }

        private int CalcSubTotal(int salledPrice, int salledAmount)
        {
            int subTotal = salledPrice * salledAmount;
            return subTotal;
        }

        //"総"売り上げ金額を求める
        public int CalcSalledTotalPrice()
        {
            int salledTotalPrice = _salledList.Sum(item => item.SalledSubTotal);
            return salledTotalPrice;
        }

        //"今日"の売り上げ金額を求める
        public int CalcSalledTodayPrice()
        {
            DateTime today = DateTime.Today;

            int salledTodayPrice = _salledList.Where(item => item.SalledDate == today).Sum(item => item.SalledSubTotal);
            return salledTodayPrice;
        }

        //利益の計算メソッドはどのクラスに作るか問題解決まで放置-------------------------------------
        //public int CalcProfitTotalPrice()
        //{
        //    var stockManager = new StockManager();
        //    var stockList = stockManager.StockList;

        //    if(stockList.Any(item => item.Name == _salledList.N)
        //}
        //--------------------------------------------------------------------------------------------
    }
}
