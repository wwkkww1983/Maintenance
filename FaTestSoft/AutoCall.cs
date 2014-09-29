using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FaTestSoft.CommonData;

namespace FaTestSoft
{
    public partial class AutoCall : Form
    {
        Timer timer;
        public AutoCall(Timer timer)
        {
            InitializeComponent();
            this.timer = timer;
        }

        private void AutoCall_Load(object sender, EventArgs e)
        {
            textBox1.Text = (timer.Interval / 1000).ToString();
            if (timer.Enabled == true)
            {
                button1.Text = "关闭";
            }
            else
            {
                button1.Text = "开启";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer.Enabled == true)
            {
                timer.Enabled = false;
                button1.Text = "开启";
            }
            else
            {
                timer.Enabled = true;
                button1.Text = "关闭";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Interval = int.Parse(textBox1.Text) * 1000;
        }

        private void buttonSingleCall_Click(object sender, EventArgs e)
        {
            PublicDataClass._NetTaskFlag.C_IC_NA_1 = true;
            PublicDataClass._GprsTaskFlag.C_IC_NA_1 = true;
            PublicDataClass._UsbTaskFlag.C_IC_NA_1 = true;
            PublicDataClass._ComTaskFlag.C_IC_NA_1 = true;
        }
    }
}
