using CAFE_MANAGEMENT_DATAACCESS.CLASSES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_MANAGEMENT_BUSINESS.CLASSES
{
    public class cls_ManagementAppUser : cls_Person
    {

        enum EN_Mode { addnew = 1, update = 2 }
        EN_Mode _Mode;

        public int UserID { set; get; }
        public long Permissions { set;get; }

        public cls_ManagementAppUser() : base()
        {

            this.UserID = -1;
            this.Permissions = 0;

            this._Mode = EN_Mode.addnew;

        }

        public cls_ManagementAppUser(int userID, long permissions, string firstName,
            string secondName, string lastName, bool gender, string address, string userName,
            DateTime dob, string idNumber, string phone1, string phone2, string personImage)

            : base(firstName, secondName, lastName, gender, address, userName,
                 dob, idNumber, phone1, phone2, personImage)
        {

            this.UserID = userID;
            this.Permissions = permissions;

            this._Mode = EN_Mode.update;

        }

        private cls_ManagementAppUser(int userID, long permissions, int personID, string firstName,
            string secondName, string lastName, bool gender, string address, string userName, string password,
            DateTime dob,string idNumber, string phone1, string phone2, string personImage) 

            : base (personID, firstName, secondName, lastName, gender, address, userName,
                  password, dob, idNumber,phone1, phone2, personImage)
        {

            this.UserID = userID;
            this.Permissions = permissions;

            this._Mode = EN_Mode.update;

        }

        public static bool IsUserHasReferences(int userID)
        {
            return cls_ManagementAppUser_D.GetCountOfUserReferences(userID) > 0;
        }

        public static bool IsUserExist(string userName)
        {
            return IsPersonExist(userName);
        }

        public static bool IsUserExist(int userID, string userName)
        {
            int personid = Find(userID).PersonID;
            return (personid > 0) ? IsPersonExist(personid, userName) : false;
        }

        public static bool IsUserExistByIDNumber(string iDNumber)
        {
            return IsPersonExistByIDNumber(iDNumber);
        }

        public static bool IsUserExistByIDNumber(int userID, string iDNumber)
        { 
            int personid = Find(userID).PersonID;
            return (personid > 0) ? IsPersonExistByIDNumber(personid, iDNumber) : false;
        }

        public static bool IsUserExistByPhone(string Phone)
        {
            return IsPersonExistByPhone(Phone);
        }

        public static bool IsUserExistByPhone(int userID, string Phone)
        {
            int personid = Find(userID).PersonID;
            return (personid < 0) ? IsPersonExistByPhone(personid, Phone) : false;
        }

        public static cls_ManagementAppUser Find(int UserID)
        {

            int personid = -1;
            long permissions = 0;

            if (cls_ManagementAppUser_D.Find(UserID, ref personid, ref permissions))
            {

                cls_Person person = cls_Person.FindPerson(personid);
                return (person != null) ? new cls_ManagementAppUser(UserID, permissions, person.PersonID,
                    person.FirstName, person.SecondName, person.LastName, Convert.ToBoolean(person.Gender),
                    person.Address, person.UserName, person.Password, person.DOB, person.IDNumber,
                    person.Phone1, person.Phone2, person.PersonImage) : null;
            }

            return null;

        }

        public static cls_ManagementAppUser Find(string UserName)
        {

            int userid = -1;
            int personid = -1;
            long permissions = 0;

            if (cls_ManagementAppUser_D.Find(UserName, ref userid, ref personid, ref permissions))
            {

                cls_Person person = cls_Person.FindPerson(personid);
                return (person != null) ? new cls_ManagementAppUser(userid, permissions, person.PersonID,
                    person.FirstName, person.SecondName, person.LastName, Convert.ToBoolean(person.Gender),
                    person.Address, person.UserName, person.Password, person.DOB, person.IDNumber,
                    person.Phone1, person.Phone2, person.PersonImage) : null;
            }

            return null;

        }

        private bool _AddUser()
        {

            if (this.AddPerson())
                this.UserID = cls_ManagementAppUser_D.AddUser(this.PersonID, this.Permissions);

            return (this.UserID > 0);

        }
        
        private bool _UpdateUser()
        {

            return (this.UpdatePerson()) ? cls_ManagementAppUser_D.UpdateUser(this.UserID, this.Permissions) : false;

        }

        public static bool DeleteUser(int UserID)
        {
            int _PersonID = Find(UserID).PersonID;
            return IsUserHasReferences(UserID) ? false : cls_ManagementAppUser_D.DeleteUser(UserID) ? DeletePerson(_PersonID) : false;
        }

        public bool Save()
        {

            switch (_Mode)
            {

                case EN_Mode.addnew:
                    if (_AddUser())
                    {
                        _Mode = EN_Mode.update;
                        return true;
                    }
                    break;

                case EN_Mode.update:
                    if (_UpdateUser())
                        return true;
                    break;

            }

            return false;

        }

        public static DataTable GetUsers()
        {
            return cls_ManagementAppUser_D.GetUsers();
        }

    }
}
