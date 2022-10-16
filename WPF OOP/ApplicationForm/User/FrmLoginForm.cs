using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPF_OOP.Application.Main_Menu;
using WPF_OOP.Interfaces;
using WPF_OOP.Notifications;
using WPF_OOP.StoredProcedures;

namespace WPF_OOP
{
    public partial class FrmLoginForm : Form
    {


        DataSet dSet = new DataSet();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();

        readonly myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        readonly myglobal pointer_module = new myglobal();

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

        private void BtnLogin_Click(object sender, EventArgs e)
        {

        }

        private void LoginProcedure() 
        {

            //User Stored Procedure Validate name & Password
            this.dSet.Clear();
            this.dSet = objStorProc.sp_userfile(0,
                this.TxtUserName.Text.Trim(),
                this.TxtPassword.Text.Trim(),
                "",
                "validate");



            if (dSet.Tables[0].Rows.Count > 0)
            {
                userinfo.set_user_parameters(dSet);
                myglobal.user_password = this.TxtPassword.Text;

                string winpath = Environment.GetEnvironmentVariable("windir");
                string path = System.IO.Path.GetDirectoryName(
                System.Windows.Forms.Application.ExecutablePath);




                this.Hide();
                MDIParentMenu MainMenu = new MDIParentMenu();
                MainMenu.ShowDialog();
                this.Close();

                //end of form validation
            }
            }


        }
}
