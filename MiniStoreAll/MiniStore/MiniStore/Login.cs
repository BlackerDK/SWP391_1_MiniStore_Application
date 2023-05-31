using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void btLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string passWord = txtPass.Text;
            if (userName.Trim() == "")
            {
                MessageBox.Show("Place ! Enter User name !");
            } else if (passWord.Trim() == "")
            {
                MessageBox.Show("Place ! Enter Password !");
            }
            else
            {
                string query = "Select * from Account where UserName = '" + userName + "' and PassWord = '"+passWord+"' ";
            if(modify.Acounts(query).Count !=0)
                {
                    MessageBox.Show("Sucessfully !!");
                    this.Hide();
                    AdminPage adminPage = new AdminPage();
                    adminPage.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Fails !", "Confirm", MessageBoxButtons.OK);
                }
            }
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
