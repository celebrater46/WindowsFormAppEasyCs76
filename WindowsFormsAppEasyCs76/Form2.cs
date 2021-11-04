using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs76
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Label lb = new Label();
            Button bt = new Button();
        
            this.Text = "おおきに！";
            this.Width = 250;
            this.Height = 100;

            lb.Text = "おおきに！！！！";
            lb.Dock = DockStyle.Top;

            bt.Text = "かまへん";
            bt.DialogResult = DialogResult.OK;
            bt.Dock = DockStyle.Bottom;

            lb.Parent = this;
            bt.Parent = this;
        }
    }
}