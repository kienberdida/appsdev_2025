using System;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        
        private decimal iphone16ProMax = 69990;
        private decimal iphone16Pro = 84990;
        private decimal iphone16Plus = 54990;
        private decimal iphone16 = 62990;
        private decimal iphone16e = 39990;

        
        private decimal appleCarePlus = 2590;
        private decimal usbCAdapter = 1990;
        private decimal magsafeCharger = 2490;

        public Form1()
        {
            InitializeComponent();

            
            string[] loanTerm = { "12 Months", "24 Months", "30 Months", "36 Months" };
            comboBox1.Items.AddRange(loanTerm);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0; 
        }

       
        private void modelBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("iPhone 16 Pro Max (256GB)");
            listBox1.Items.Add("iPhone 16 Pro (128GB)");
            listBox1.Items.Add("iPhone 16 Plus (128GB)");
            listBox1.Items.Add("iPhone 16 (128GB)");
            listBox1.Items.Add("iPhone 16e (128GB)");
        }

        
        private void addOnsBtn_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            checkedListBox1.Items.Add("Apple Care Plus");
            checkedListBox1.Items.Add("USB-C Charging Adapter");
            checkedListBox1.Items.Add("MagSafe Charger (1M)");
        }

        
        private void computeBtn_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an iPhone model.");
                return;
            }

            
            decimal modelPrice = 0;
            string selectedModel = listBox1.SelectedItem.ToString();
            switch (selectedModel)
            {
                case "iPhone 16 Pro Max (256GB)":
                    modelPrice = iphone16ProMax;
                    break;
                case "iPhone 16 Pro (128GB)":
                    modelPrice = iphone16Pro;
                    break;
                case "iPhone 16 Plus (128GB)":
                    modelPrice = iphone16Plus;
                    break;
                case "iPhone 16 (128GB)":
                    modelPrice = iphone16;
                    break;
                case "iPhone 16e (128GB)":
                    modelPrice = iphone16e;
                    break;
            }

            
            decimal addOnPrice = 0;
            foreach (var item in checkedListBox1.CheckedItems)
            {
                if (item.ToString() == "Apple Care Plus")
                    addOnPrice += appleCarePlus;
                if (item.ToString() == "USB-C Charging Adapter")
                    addOnPrice += usbCAdapter;
                if (item.ToString() == "MagSafe Charger (1M)")
                    addOnPrice += magsafeCharger;
            }

            
            decimal interestRate = 0;
            switch (comboBox1.SelectedItem.ToString())
            {
                case "12 Months":
                    interestRate = 0.05m;
                    break;
                case "24 Months":
                    interestRate = 0.10m;
                    break;
                case "30 Months":
                    interestRate = 0.1225m;
                    break;
                case "36 Months":
                    interestRate = 0.15m;
                    break;
            }

            
            decimal totalPrice = modelPrice + addOnPrice;
            decimal totalWithInterest = totalPrice * (1 + interestRate);

           
            MessageBox.Show($"Total Price: {totalPrice:C}\n" +
                            $"Interest Rate: {interestRate * 100}%\n" +
                            $"Total with Interest: {totalWithInterest:C}");
        }

      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}
