using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_OOP.Repository
{
    internal interface IUserFileRepository
    {
        void LoginValidation(string Username, string Password);

        void GetUsers(System.Windows.Forms.DataGridView DataGridViews);
        void ValidateUserIfExist(string UserName, string FirstName, string LastName);

    }
}
