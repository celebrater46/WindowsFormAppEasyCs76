using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs76
{
    public partial class Form1 : Form
    {
        private Label lb;
        private Button bt;
        
        public Form1()
        {
            InitializeComponent();
            this.Text = "ダイアログテストやで！！！！";
            this.Width = 250;
            this.Height = 200;

            lb = new Label();
            lb.Text = "おこしやす！！！！";
            lb.Dock = DockStyle.Top;

            bt = new Button();
            bt.Text = "買うやで！";
            bt.Dock = DockStyle.Bottom;

            lb.Parent = this;
            bt.Parent = this;

            bt.Click += new EventHandler(ClickBt);
        }

        public void ClickBt(Object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("ホンマに買うんか？？？", "確認やで！", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                // MessageBox.Show("おおきに！！！", "買うたで！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else if (dr == DialogResult.No)
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
        }
    }
}