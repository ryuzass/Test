using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_Riw
{ 
    public partial class Form1 : Form
    { string Sl = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
        }
        public void cup(string menu, string bath)
        {
            string[] cup = { menu, bath };
            var ryu = new ListViewItem(cup);
            listView1.Items.Add(ryu);
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {
            cup("LemonTeaIce", "25");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            cup("NesteaTeaHot", "20");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            cup("NesafeHot", "20");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cup("MiloHot", "20");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cup("LemonTeaFrappe", "30");
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cup("EsspressoHot", "35");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            cup("EsspressoIce", "40");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            cup("EsspressoFrappe", "50");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cup("AricanoHot", "35");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            cup("AricanoIce", "40");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cup("LateHot", "35");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            cup("LateIce", "40");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            cup("LateFrappe", "50");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cup("MochaHot", "35");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            cup("MochaIce", "40");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            cup("MochaFrappe", "50");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cup("CappuccinoHot", "35");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            cup("CappuccinoIce", "45");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            cup("CappuccinoFrappe", "50");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cup("Green TeaHot", "20");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            cup("Green TeaIce", "25");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            cup("Green TeaFrappe", "30");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            cup("ThaiTeaHot", "20");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            cup("ThaiTeaIce", "25");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            cup("ThaiTeaFrappe", "30");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cup("CoCoaHot", "20");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            cup("CoCoaIce", "25");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            cup("CoCoaFrappe", "30");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cup("MilkHot", "20");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            cup("MilkIce", "25");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            cup("MilkFrappe", "30");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            cup("Milk TeaIce", "25");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            cup("Milk TeaFrappe", "30");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            cup("MiloIce", "25");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            cup("NesafeIce", "25");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            cup("NesafeFrappe", "30");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            cup("NesteaTeaIce", "25");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            cup("NesteaTeaFrappe", "30");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            cup("Cantalupr", "25");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            cup("Strawberry", "25");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            cup("Apple", "25");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            cup("BuleHawai", "25");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            cup("Red lime Soda", "25");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            cup("Honey lime Soda", "25");
        }
        double one;
        public string[] R2()
        {
            one = 0;
            string[] Item = new string[listView1.Items.Count];
            int R3 = listView1.Items.Count;
            for (int i = 0; i < R3; i++)
            {
                one += double.Parse(listView1.Items[i].SubItems[1].Text);

                Item[i] = listView1.Items[i].SubItems[0].Text.ToString();

            } label29.Text = one.ToString();
            return Item;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabcontorl1.Controls.Remove(PayMent);
        }
        public string[] pog ()
        {
            string[] Item = new string[listView1.Items.Count];
            int R1 = listView1.Items.Count;
            for(int i=0;i<R1;i++)
            {
                Item[i] = listView1.Items[i].SubItems[1].Text.ToString();
            }
            return Item;

        }
        public void Record()
        {
            string[] R1 = R2();
            string[] R4 = pog();
            string BF = "coffee Sl" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string AF = "coffee Sl";
            AF += "\r\n" + DateTime.Now.ToString("hh:mm:ss") + "\r\n" + DateTime.Now.ToString("dd/mm/yyyy") + "\r\n" + "\r\n";
            AF += "Menu" + "\r\n";
            for (int i =0; i< listView1.Items.Count; i++)
            {
                AF += R1[i] + new string(' ', 20) + R4[i] + "bath" + "\r\n";
            }
            AF += "\r\n";
            AF += "Totle Price :" + label29.Text;
            System.IO.File.WriteAllText(Sl + @"\" + BF + ".txt", AF);
            textBox1.Text += AF + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "Save File at" + Sl + @"\" + BF + ".txt";

        }
        bool H = false;

        private void button49_Click(object sender, EventArgs e)
        {
            label29.Text = " ";
            if (H == false)
            {
                tabcontorl1.TabPages.Insert(1, PayMent);
                tabcontorl1.SelectedTab = PayMent;
            }
            else tabcontorl1.SelectedTab = PayMent;
            if (listView1.Items.Count > 0)
                Record();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            H = false;
            tabcontorl1.Controls.Remove(PayMent);
            textBox1.Text = "";
            label29.Text = "";
        }
    }
}
