using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore
{
    public partial class NextAccountEmployees : Form
    {
        public NextAccountEmployees()
        {
            InitializeComponent();
        }

        private void btAddEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPage addAcountSucessfully = new AdminPage();
            addAcountSucessfully.ShowDialog();
        }
    }
}
