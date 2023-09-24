using MVP_WindowsForm.Models;
using MVP_WindowsForm.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_WindowsForm.Views
{
    public partial class Main : Form, IUserInfo
    {
        private UserInfoPresenter _presenter = null;

        public Main()
        {
            InitializeComponent();
            _presenter = new UserInfoPresenter(this);
        }

        string IUserInfo.LastName
        {
            get { return txtLastName.Text; }
            set { txtLastName.Text = value; }
        }

        string IUserInfo.FirstName
        {
            get { return txtFirstName.Text; }
            set { txtFirstName.Text = value; }
        }

        string IUserInfo.Email
        {
            get { return txtEmail.Text; }
            set { txtEmail.Text = value; }
        }

        string IUserInfo.Phone
        {
            get { return txtPhone.Text; }
            set { txtPhone.Text = value; }
        }


        public event EventHandler SaveAttempted;

        private void button1_Click(object sender, EventArgs e)
        {
            SaveAttempted?.Invoke(this, e);
        }
    }
}
