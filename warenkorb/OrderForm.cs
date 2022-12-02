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
    public partial class OrderForm : Form
    {
        List<OrderItem> orderedItems = new List<OrderItem>();
        public OrderForm()
        {
            InitializeComponent();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxProduct.Text.Trim()))
                return;

            OrderItem produkt = new OrderItem();
            produkt.ProduktName = textBoxProduct.Text;
            produkt.Anzahl = Convert.ToInt32(numericUpDownAmount.Value);
            orderedItems.Add(produkt);

            labelAmountCart.Text = "(" + orderedItems.Count.ToString() + ")";

            textBoxProduct.Text = "";
            textBoxProduct.Focus();
            numericUpDownAmount.Value = 1;
        }
        private void textBoxProduct_TextChanged(object sender, EventArgs e)
        {
            buttonAdd.Enabled = textBoxProduct.Text.Length > 0;
        }
        private void linkLabelViewCart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CartForm cart = new CartForm(this.orderedItems);
            cart.ShowDialog();
        }
        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
