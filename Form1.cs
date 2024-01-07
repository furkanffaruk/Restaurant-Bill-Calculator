using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RestaurantBillCalculator
{
    public partial class MainForm : Form
    {
        public struct Orders
        {
            public string item;
            public double price;
        }

        const double TaxRate = 0.06;//6% tax
        Orders orders = new Orders();
        static double Subtotal=0;
        static double Total=0;
        static double Tax=0;
        string finalBill = "FINAL BILL: \n";

        public MainForm()
        {
            InitializeComponent();
        }

        private void getValues(string custOrder)
        {
            orders.item = custOrder.Split('$')[0];
            orders.price = Convert.ToDouble(custOrder.Split('$')[1], System.Globalization.CultureInfo.InvariantCulture);
            lstOutput.Items.Add("Price: "+orders.price);
            finalBill += "Ordered Item: " + orders.item + "\nPrice: " + orders.price.ToString("C", new System.Globalization.CultureInfo("en-US")) + "\n";
            updateBill();
        }

        private void updateBill()
        {
            Subtotal += orders.price;
            Total += orders.price + (orders.price * TaxRate);
            Tax += orders.price * TaxRate;

            lstOutput.Items.Clear();
            lstOutput.Items.AddRange(finalBill.Split('\n'));
            lstOutput.Items.Add("Subtotal: " + Subtotal.ToString("C", new System.Globalization.CultureInfo("en-US")));
            lstOutput.Items.Add("Tax: " + Tax.ToString("C", new System.Globalization.CultureInfo("en-US")));
            lstOutput.Items.Add("Total: " + Total.ToString("C", new System.Globalization.CultureInfo("en-US")));
        }

        private void dropdownSelection(object sender, EventArgs e)
        {
            if(sender==cmbBeverage)
                getValues(cmbBeverage.SelectedItem.ToString());
            else if (sender == cmbAppetizer)
                getValues(cmbAppetizer.SelectedItem.ToString());
            else if (sender == cmbMainCourse)
                getValues(cmbMainCourse.SelectedItem.ToString());
            else
                getValues(cmbDessert.SelectedItem.ToString());
        }

        private void btnClearBill_Click(object sender, EventArgs e)
        {
            Subtotal = 0;
            Total = 0;
            Tax = 0;
            finalBill = "FINAL BILL: \n";
            lstOutput.Items.Clear();
        }  
    }
}