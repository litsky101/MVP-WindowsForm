using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_WindowsForm.Models
{
    interface IUserInfo
    {
        string LastName { get; set; }
        string FirstName { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        event EventHandler SaveAttempted;
    }
}
