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
using WPF_OOP.Notifications;
using WPF_OOP.Repository;
using WPF_OOP.StoredProcedures;

namespace WPF_OOP.ApplicationForm.User.Modals
{
    public partial class FrmAddorEditUser : Form
    {
        readonly FrmUsers ths;
        UserFile UserFile = new UserFile();
        UserFileRepository UserRepository = new UserFileRepository();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
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



        private void MetroSave()
        {

        }


        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (this.UserFile.Mode == "ADD")
            {

                //Validation to minimize the duplicate fucking entries
       

                this.UserRepository.ValidateUserIfExist(this.TxtuserName.Text.Trim(), this.TxtFirstName.Text.Trim(), this.TxtLastName.Text.Trim());

                if (this.UserRepository.dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();



                    this.TxtFirstName.Focus();
                    return;
                }
                else
                {
                    this.MetroSave();

                }



            }
            else
            {

                if (this.UserFile.Employee_Name == this.TxtFirstName.Text)
                {

                }
                else
                {
                    this.UserRepository.ValidateUserIfExist(this.TxtuserName.Text.Trim(), this.TxtFirstName.Text.Trim(), this.TxtLastName.Text.Trim());

                    if (UserRepository.dSet.Tables[0].Rows.Count > 0)
                    {
                        this.GlobalStatePopup.DataAlreadyExist();



                        this.TxtFirstName.Focus();
                        return;
                    }
                }



                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    //this.TblCustomersRepositorys
                    //    .PutCustomer(
                    //    this.TblCustomersEntity.Cust_Id,
                    //    this.MatTxtName.Text,
                    //    this.metroCmbType.Text,
                    //    this.metroCmbCompany.Text,
                    //    this.TxtMobile.Text,
                    //    this.TxtLeadMan.Text,
                    //    this.TxtAddress.Text,
                    //   TblCustomersEntity.Cust_Added_By,
                    //    "",
                    //    TblCustomersEntity.Cust_Updated_by,
                    //    "",
                    //    true,
                    //    "edit");
                    //this.GlobalStatePopup.UpdatedSuccessfully();
                    //this.Close();
                }
                else
                {
                    return;
                }



            }



        }

        private void FrmAddorEditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.textBox1.Text = "SuccessFully Save";
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }





}
