using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CardDeckRevamp
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
           EnterName ens = new EnterName();
           Form form = this.FindForm();

            form.Controls.Add(ens);
            form.Controls.Remove(this);

            ens.Location = new Point((form.Width - ens.Width) / 2, (form.Height - ens.Height) / 2);
        }

        private void leaderButton_Click(object sender, EventArgs e)
        {
            LeaderBoardScreen lbs = new LeaderBoardScreen();
            Form form = this.FindForm();

            form.Controls.Add(lbs);
            form.Controls.Remove(this);

            lbs.Location = new Point((form.Width - lbs.Width) / 2, (form.Height - lbs.Height) / 2);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
