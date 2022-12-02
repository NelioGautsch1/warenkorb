using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bestellungen_erfassen
{
    public partial class CartForm : Form
    {
        List<OrderItem> items;
        public CartForm(List<OrderItem> orderedItems)
        {
            InitializeComponent();

            this.items = orderedItems;
        }
        private void CartForm_Load(object sender, EventArgs e)
        {
            foreach (OrderItem produkt in items)
            {
                listBoxItems.Items.Add(produkt.Anzahl + " Ex." +  "\t" + produkt.ProduktName);
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
