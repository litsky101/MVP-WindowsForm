using MVP_WindowsForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_WindowsForm.Presenters
{
    class UserInfoPresenter
    {
        private readonly IUserInfo _view;

        public UserInfoPresenter(IUserInfo view)
        {
            _view = view;
            _view.SaveAttempted += Save;
        }

        private void Save(object sender, EventArgs e)
        {
            _view.LastName = "De Sagun";
        }
    }
}
