using Luskyle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            trackBar1.Maximum = 5;            

            trackBar1.ValueChanged += (s, e) =>
            {
                label1.Text = (s as TrackBar).Value.ToString();
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MsgInforBox.Show(this, "(ง •_•)ง   请输入账号", InforType.Default, trackBar1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MsgInforBox.Show(this, "(ง •_•)ง   请输入账号", InforType.Error, trackBar1.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MsgInforBox.Show(this, "(ง •_•)ง   请输入账号", InforType.Success, trackBar1.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MsgInforBox.Show(this, "(ง •_•)ง   请输入账号", InforType.Warning, trackBar1.Value);
        }
    }
}
