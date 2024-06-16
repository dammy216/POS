using POS.Model.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.View
{
    public partial class Seles : Form
    {
        private StockManager _stockInstance = StockManager.GetInstance();
        public Seles()
        {
            InitializeComponent();
            DisplaySelesListView();
        }

        private void DisplaySelesListView()
        {
            salesListView.Items.Clear();

            foreach (var stock in _stockInstance.StockList)
            {
                var selesList = _stockInstance.DisplaySelesList(stock);

                if(selesList == null )
                    continue;

                ListViewItem item = new ListViewItem(selesList);

                salesListView.Items.Add(item);
            }
        }
    }
}
