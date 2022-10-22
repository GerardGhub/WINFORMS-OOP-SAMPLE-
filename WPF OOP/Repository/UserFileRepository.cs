using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPF_OOP.Interfaces;
using WPF_OOP.StoredProcedures;

namespace WPF_OOP.Repository
{
    internal class UserFileRepository : IUserFileRepository
    {
        readonly myclasses xClass = new myclasses();
        public  DataSet dSet = new DataSet();
      IStoredProcedures objStorProc = null;
        int TotalRecords = 0;

        public void AddUser(int UserFileId, int UserRightsId, string Username, string Password, string EmployeeName, string UserSection, string ReceivingStatus, int Position, string EmployeeLastName, int Department, string RequestorType, string Unit, string Gender, string Mode)
        {
            this.ConnectionInit();
            this.dSet.Clear();
            this.dSet = objStorProc.sp_userfileIncrement(0,
                UserRightsId,
                Username,
                Password,
                EmployeeName,
                UserSection,
                ReceivingStatus,
                Position,
                EmployeeLastName,
                Department,
                RequestorType,
                Unit,
                Gender,
                "add");
        }

        public void GetUsers(DataGridView DataGridViews)
        {
            try
            {

                this.xClass.fillDataGridView(DataGridViews, "users", this.dSet);

                this.TotalRecords = DataGridViews.RowCount;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void LoginValidation(string Username, string Password)
        {
            this.ConnectionInit();
            this.dSet.Clear();
            this.dSet = objStorProc.sp_userfile(0,
            Username,
            Password,
            "",
            "validate");

        }

        public void ValidateUserIfExist(string UserName, string FirstName, string LastName)
        {
            this.ConnectionInit();
            dSet.Clear();
            dSet = objStorProc.sp_userfile(0,0,
                UserName,
                "",
                FirstName,
                "",
                "",
                "",
                LastName,
                "",
                "",
                "",
                "",
                "getbyname");
        }

        private void ConnectionInit()
        {

            this.objStorProc = xClass.g_objStoredProc.GetCollections();
        }

    }
}
