using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p4lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum MyEnum
        {
            jeden,
            dwa,
            trzy
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.AddRange(new List<string>
            //{
            //    "item1",
            //    "item2",
            //    "item3"
            //}.ToArray());

            foreach (var item in Enum.GetValues(typeof(MyEnum)))
            {
                comboBox1.Items.Add(item);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
            fontDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.ShowBalloonTip(1000, "Tytuł", "Treść",ToolTipIcon.Info);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
            }

            printDialog1.ShowDialog();
        }
    }
}
