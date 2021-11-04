using System;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs76
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Label lb = new Label();
            Button bt = new Button();

            this.Text = "何やとワレェ！！！";
            this.Width = 250;
            this.Height = 200;

            lb.Text = "手ぶらで出ていくっちゅうんかい！！";
            lb.Dock = DockStyle.Top;

            bt.Text = "せやで";
            bt.Dock = DockStyle.Bottom;

            lb.Parent = this;
            bt.Parent = this;

            bt.Click += new EventHandler(ClickBt);
        }

        public void ClickBt(Object sender, EventArgs e)
        {
            this.Close();
        }
    }
}