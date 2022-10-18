using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPF_OOP.ApplicationForm.User.Modals;
using WPF_OOP.Interfaces;
using WPF_OOP.Models;
using WPF_OOP.Notifications;
using WPF_OOP.Repository;
using WPF_OOP.StoredProcedures;

namespace WPF_OOP.ApplicationForm.User
{
    public partial class FrmUsers : Form
    {



        UserFileRepository UserFileRepository = new UserFileRepository();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        IStoredProcedures g_objStoredProcCollection = null;
        readonly myclasses xClass = new myclasses();

        UserFile UserFile = new UserFile();
        public FrmUsers()
        {
            InitializeComponent();
        }



        private void FrmUsers_Load(object sender, EventArgs e)
        {
            this.ConnetionString();

            this.UserFileRepository.GetUsers (this.DgvUsers);

            this.LblTotalRecords.Text = this.DgvUsers.RowCount.ToString();
            -
            this.textBox1.Text = String.Empty;
        }

        private void ConnetionString()
        {
            this.g_objStoredProcCollection = this.xClass.g_objStoredProc.GetCollections();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            this.UserFile.Mode = "ADD";
           FrmAddorEditUser  showModal = new FrmAddorEditUser(this, this.UserFile.Mode);
            showModal.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.FrmUsers_Load(sender, e);
        }
    }
}
