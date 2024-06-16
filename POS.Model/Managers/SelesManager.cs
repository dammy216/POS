﻿using POS.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Model.Managers
{
    public class SelesManager
    {
        private List<SalledData> _salledList = new List<SalledData>();
        public List<SalledData> SalledList { get {  return _salledList; } }
        private static SelesManager _instance;

        private SelesManager()
        {
        }

        public static SelesManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SelesManager();
                return _instance;
            }
            return _instance;
        }

        public void AddSeles(string salledName, int salledPrice, int salledAmount)
        {
            var salledData = new SalledData(salledName, salledPrice, salledAmount, CalcSubTotal(salledPrice, salledAmount));
            _salledList.Add(salledData);
        }

        //販売数×価格の計算
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
            string today = DateTime.Today.ToString("yyyy-MM-dd");

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