using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPF_OOP
{
    public partial class FrmLoginForm : Form
    {
        public FrmLoginForm()
        {
            InitializeComponent();
        }

        private void FrmLoginForm_Load(object sender, EventArgs e)
        {
            this.UseEffectMenuLoad();
        }

        private void UseEffectMenuLoad()
        {
            this.TxtUserName.Focus();
        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {
            this.TextBoxIsValid();
        }

        private void TextBoxIsValid()
        {

            bool result = (this.TxtUserName.Text == String.Empty || this.TxtPassword.Text == String.Empty)  ?  this.BtnLogin.Enabled = false : this.BtnLogin.Enabled = true;
 
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            this.TextBoxIsValid();
        }
    }
}
