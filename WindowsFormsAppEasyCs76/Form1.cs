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
            this.Text = "Dialog Test Sample";
            this.Width = 250;
            this.Height = 200;

            lb = new Label();
            lb.Text = "Welcome.";
            lb.Dock = DockStyle.Top;

            bt = new Button();
            bt.Text = "Buy";
            bt.Dock = DockStyle.Bottom;

            lb.Parent = this;
            bt.Parent = this;

            bt.Click += new EventHandler(ClickBt);
        }

        public void ClickBt(Object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you really but it?", "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for shopping.", "Bought", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}