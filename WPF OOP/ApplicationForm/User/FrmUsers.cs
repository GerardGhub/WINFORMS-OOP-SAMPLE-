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
        readonly UserFileRepository UserFileRepository = new UserFileRepository();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        IStoredProcedures g_objStoredProcCollection = null;
        readonly myclasses xClass = new myclasses();
        readonly UserFile UserFile = new UserFile();
        public FrmUsers()
        {
            InitializeComponent();
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            this.ConnetionString();
            this.RadioActive.Checked = true;            
            this.textBox1.Text = String.Empty;
        }

        private void ConnetionString()
        {
            this.g_objStoredProcCollection = this.xClass.g_objStoredProc.GetCollections();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            this.BtnNew.Visible = false;
            this.UserFile.Mode = "ADD";
           FrmAddorEditUser  showModal = new FrmAddorEditUser(this, this.UserFile.Mode);
            showModal.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.BtnNew.Visible = true;
            this.FrmUsers_Load(sender, e);
        }

        private void RadioActive_CheckedChanged(object sender, EventArgs e)
        {
            this.BtnInActive.Text = "InActive";
            this.GetActivatedUser();
        }
        private void GetActivatedUser()
        {
            this.UserFileRepository.GetUsers(this.DgvUsers);

            this.LblTotalRecords.Text = this.DgvUsers.RowCount.ToString();
        }

        private void RadioInActive_CheckedChanged(object sender, EventArgs e)
        {
            this.BtnInActive.Text = "Activate";
            this.GetDeactivateUser();
        }

        private void GetDeactivateUser()
        {
            this.UserFileRepository.GetUsersInactive(this.DgvUsers);

            this.LblTotalRecords.Text = this.DgvUsers.RowCount.ToString();
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            this.SearchProc();
            this.DoSearchOnMaterialTextBox();
        }

        public void SearchProc()
        {
            try
            {
                if (this.RadioActive.Checked == true)
                {
                    this.UserFileRepository.SearchActiveUser("usercurrentcellchanged");
                }
                else
                {
                    this.UserFileRepository.SearchInActiveUser("InactiveUserCurrentCellChanged");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }





        }


        public void DoSearchOnMaterialTextBox()
        {
            try
            {
                if (this.UserFileRepository.dSet.Tables.Count > 0)
                {
                    DataView dv = new DataView(this.UserFileRepository.dSet.Tables[0]);


                    dv.RowFilter = "employee_name like '%" + this.TxtSearch.Text + "%' " +
                        "or employee_lastname like '%" + this.TxtSearch.Text + "%' " +
                        "or username like '%" + this.TxtSearch.Text + "%'   ";


                    this.DgvUsers.DataSource = dv;
                    this.LblTotalRecords.Text = this.DgvUsers.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
        }

        private void BtnInActive_Click(object sender, EventArgs e)
        {

            //Start
            if (this.RadioActive.Checked == true)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to deactivate?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (this.DgvUsers.Rows.Count > 0)
                    {
                        this.UserFileRepository.DeactivateUser(this.UserFile.Userfile_Id);
                        this.GetActivatedUser();
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
           
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to activate?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (this.DgvUsers.Rows.Count > 0)
                        {
                            this.UserFileRepository.ActivateUser(this.UserFile.Userfile_Id);
                           this.GetDeactivateUser();
                    }
                    }
                    else
                    {
                        return;
                    }
                


            }

            //End

        }

        private void DgvUsers_CurrentCellChanged(object sender, EventArgs e)
        {
            this.CurrentCellChanged();
        }

        public void CurrentCellChanged()
        {
            if (this.DgvUsers.RowCount > 0)
            {
                if (this.DgvUsers.CurrentRow != null)
                {
                    if (this.DgvUsers.CurrentRow.Cells["username"].Value != null)
                    {

                        this.UserFile.Userfile_Id = Convert.ToInt32(this.DgvUsers.CurrentRow.Cells["userfile_id"].Value.ToString());
                        this.UserFile.Employee_Name = this.DgvUsers.CurrentRow.Cells["employee_name"].Value.ToString();
                        this.UserFile.Employee_Lastname = this.DgvUsers.CurrentRow.Cells["employee_lastname"].Value.ToString();

                    }

                }
            }
        }


    }
}
