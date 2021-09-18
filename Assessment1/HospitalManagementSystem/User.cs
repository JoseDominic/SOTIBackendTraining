using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    enum Role
    {
        Doctor, Nurse, Admin, Patient, Nominee
    }
    class User
    {
        private int id;
        private string title;
        private string firstName;
        private string lastName;
        private string email;
        private string dob;
        private Role role;
    }
}
