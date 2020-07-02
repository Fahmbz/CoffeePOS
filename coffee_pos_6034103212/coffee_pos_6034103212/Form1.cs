using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_pos_6034103212
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("https://github.com/mbz1998");
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button288_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(tag);
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            hani("Esspresso(Hot)", "35");
        }
        public void hani(string menu, string bath)
        {
            string[] hn = { menu, bath };
            var listview = new ListViewItem(hn);
            listView.Items.Add(listview);
            list();
        }
        public void list()
        {

        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            hani("Americano(Hot)", "35");
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            hani("milk(Hot)", "20");
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            hani("mocha(Hot)", "35");
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            hani("GreenTea(Hot)", "20");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            hani("latte(Hot)", "35");
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            hani("Cocoa(Hot)", "20");
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            hani("Milo(Hot)", "20");
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            hani("Nescafe(Hot)", "20");
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            hani("NesteaTea(Hot)", "20");
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            hani("Thaitea(Hot)", "20");
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            hani("Cappuccino(Hot)", "35");
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            hani("latte(Ice)", "45");
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            hani("Mocha(Ice)", "45");
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            hani("Cappuccino(Ice)", "45");
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            hani("Esspresso(Ice)", "45");
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            hani("GreenTea(Ice)", "25");
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            hani("Milk(Ice)", "25");
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            hani("Milo(Ice)", "25");
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            hani("Americano(Ice)", "45");
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            hani("Nescafe(Ice)", "25");
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            hani("NesteaTea(Ice)", "25");
        }

        private void button38_Click_1(object sender, EventArgs e)
        {
            hani("LemonTea(Ice)", "25");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            hani("MilkTea(Ice)", "25");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            hani("Mocha(Frappe)", "50");
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            hani("Esspresso(Frappe)", "50");
        }

        private void button36_Click_1(object sender, EventArgs e)
        {
            hani("Latte(Frappe)", "50");
        }

        private void button35_Click_1(object sender, EventArgs e)
        {
            hani("Cappuccino(Frappe)", "50");
        }

        private void button34_Click_1(object sender, EventArgs e)
        {
            hani("GreenTea(Frappe)", "30");
        }

        private void button39_Click_1(object sender, EventArgs e)
        {
            hani("LemonTea(Frappe)", "30");
        }

        private void button40_Click_1(object sender, EventArgs e)
        {
            hani("ThaiTea(Frappe)", "30");
        }

        private void button41_Click_1(object sender, EventArgs e)
        {
            hani("Cocoa(Frappe)", "30");
        }

        private void button42_Click_1(object sender, EventArgs e)
        {
            hani("MIlk(Frappe)", "30");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            hani("Milo(Frappe)", "30");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            hani("MilkTea(Frappe)", "30");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            hani("Nescafe(Frappe)", "30");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            hani("NesteaTea(Frappe)", "30");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            hani("Apple(Soda)", "25");
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            hani("Strawberry(Soda)", "25");
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            hani("Honey Lime(Soda)", "25");
        }

        private void button49_Click(object sender, EventArgs e)
        {
            hani("Cantaloupe(Soda)", "25");
        }

        private void button37_Click_1(object sender, EventArgs e)
        {
            hani("Red Lime(Soda)", "25");
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            hani("BlueHawaii(Soda)", "25");
        }

        double gg;
        public string[] ListPrice()
        {
            gg = 0;
            string[] a = new string[listView.Items.Count];
            int li = listView.Items.Count;
            for (int i = 0; i < li; i++)
            {
                gg += double.Parse(listView.Items[i].SubItems[1].Text);
                a[i] = listView.Items[i].SubItems[0].Text.ToString();
            }
            lbtotal.Text = gg.ToString();
            return a;
        }

        public string[] inListPrice()
        {
            string[] a = new string[listView.Items.Count];
            int li = listView.Items.Count;
            for (int i = 0; i < li; i++)
            {
                a[i] = listView.Items[i].SubItems[1].Text.ToString();
            }
            return a;
        }
        public void sef()
        {
            string[] naeun = ListPrice();
            string[] eunji = inListPrice();
            string ddd = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string file = "Mr.Chu's Coffee" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string filebill = "Mr.Chu's Coffee";
            filebill += "\r\n" + DateTime.Now.ToString("hh:mm:ss") + "\r\n" + DateTime.Now.ToString("dd//mm/yyyy") + "\r\n" + "\r\n";
            filebill += "Menu" + "\r\n";
            for (int i = 0; i < listView.Items.Count; i++)
            {
                filebill += eunji[i] + new string(' ', 20) + naeun[i] + " Bath" + "\r\n";
            }
            filebill += "\r\n";
            filebill += "Total Price : " + lbtotal.Text;
            System.IO.File.WriteAllText(eunji + @"\" + file + ".txt", filebill);
            txtotal.Text += filebill + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Save File at" + ddd + @"\" + file + ".txt";
        }
        bool ok = false;
        private void button3_Click_1(object sender, EventArgs e)
        {
            txtotal.Text = "";
            if (ok == false)
            {
                tabControl1.TabPages.Insert(1, tag);
                ok = true;
                tabControl1.SelectedTab = tag;
            }
            else tabControl1.SelectedTab = tag;

            if (listView.Items.Count > 0)
            sef();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            listView.Items.Clear();
            ok = false;
            tabControl1.Controls.Remove(tag);
            lbtotal.Text = "";
        }
    }
}
