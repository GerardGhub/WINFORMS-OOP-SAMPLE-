using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPF_OOP.Interfaces;
using WPF_OOP.Models;
using WPF_OOP.StoredProcedures;

namespace WPF_OOP.ApplicationForm.User.Modals
{
    public partial class FrmAddorEditUser : Form
    {
        readonly FrmUsers ths;
        UserFile UserFile = new UserFile();
        IStoredProcedures g_objStoredProcCollection = null;
        readonly myclasses myClass = new myclasses();
        public FrmAddorEditUser(FrmUsers frm,  string Mode)
        {
            InitializeComponent();
            this.ths = frm;
            this.UserFile.Mode = Mode;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
        }

        private void FrmAddorEditUser_Load(object sender, EventArgs e)
        {
            this.WindowsLoadData();
            this.ConnetionString();
        }

        private void ConnetionString()
        {
            this.g_objStoredProcCollection = this.myClass.g_objStoredProc.GetCollections();
        }

        private void WindowsLoadData()
        {
            this.UserFile.Mode = this.UserFile.Mode;
        }

        private void TextBoxValidation()
        {
            bool FormValidation = (this.TxtFirstName.Text == String.Empty || this.TxtLastName.Text == String.Empty ||
                 this.TxtuserName.Text == String.Empty || this.TxtPassword.Text == String.Empty) ? this.BtnSave.Enabled = false : this.BtnSave.Enabled = true;
        }

        private void TxtFirstName_TextChanged(object sender, EventArgs e)
        {
            this.TextBoxValidation();
        }

        private void TxtLastName_TextChanged(object sender, EventArgs e)
        {
            this.TextBoxValidation();
        }

        private void TxtuserName_TextChanged(object sender, EventArgs e)
        {
            this.TextBoxValidation();
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            this.TextBoxValidation();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }
    }
}
