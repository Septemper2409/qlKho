using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKho.DAO;
namespace QLKho.GUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtPass.Text =="" || txtUser.Text == "")
            {
                // show sai mk 
            }
            else
            {
                userDAO user = new userDAO();
                int result  =  user.login(txtUser.Text, txtPass.Text);
                if (result != 0)
                {
                    frmmenu frmmenu = new frmmenu();
                    frmmenu.Show();
                }
                //show loi
            }
        }
    }
}
