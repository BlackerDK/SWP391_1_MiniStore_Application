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
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btShowEmployees_Click(object sender, EventArgs e)
        {

        }

        private void btAddEmployees_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployees addEmployeesPage = new AddEmployees();
            addEmployeesPage.ShowDialog();

        }
    }
}
