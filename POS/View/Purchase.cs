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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POS.View
{
    
    public partial class Purchase : Form
    {
        private readonly ProductManager _instance = ProductManager.GetInstance();
        public Purchase()
        {
            InitializeComponent();
            DisplayListView();
        }

        private void DisplayListView()
        {
            productNameListView.Items.Clear();
            
            foreach(var product in _instance.ProductList)
            {
                ListViewItem item = new ListViewItem(_instance.DisplaySubscribeProduct(product));
                productNameListView.Items.Add(item);
            }
            
        }
    }
}
