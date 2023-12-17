using CAFE_MANAGEMENT_DATAACCESS.CLASSES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_MANAGEMENT_BUSINESS.CLASSES
{
    public class cls_ServicesAppUser : cls_Person
    {

        enum EN_Mode { addnew = 1, update =2 }
        EN_Mode _Mode;

        public int UserID { set; get; }

        public cls_ServicesAppUser() : base()
        {
            UserID = -1;
            this._Mode = EN_Mode.addnew;
        }

        public cls_ServicesAppUser(int userID, string firstName,
            string secondName, string lastName, bool gender, string address, string userName,
            DateTime dob, string idNumber, string phone1, string phone2, string personImage)

            : base(firstName, secondName, lastName, gender, address, userName, dob, idNumber,
                  phone1, phone2, personImage)
        {

            this.UserID = userID;
            this._Mode = EN_Mode.update;

        }

        private cls_ServicesAppUser(int userID, int personID, string firstName,
            string secondName, string lastName, bool gender, string address, string userName, string password,
            DateTime dob, string idNumber, string phone1, string phone2, string personImage)

            : base(personID, firstName, secondName, lastName, gender, address, userName, password, dob, idNumber,
                  phone1, phone2, personImage)
        {

            this.UserID = userID;
            this._Mode = EN_Mode.update;

        }


        public static bool IsUserHasReferences(int userID)
        {
            return cls_ServicesAppUser_D.GetCountOfUserReferences(userID) > 0;
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
            return (personid > 0) ? IsPersonExistByPhone(personid, Phone) : false;
        }

        public static cls_ServicesAppUser Find(int UserID)
        {

            int personid = -1;
            
            if (cls_ServicesAppUser_D.Find(UserID, ref personid))
            {

                cls_Person person = cls_Person.FindPerson(personid);

                return (person != null) ? new cls_ServicesAppUser(UserID, person.PersonID, person.FirstName,
                    person.SecondName, person.LastName, Convert.ToBoolean(person.Gender), person.Address,
                    person.UserName, person.Password, person.DOB, person.IDNumber, person.Phone1, 
                    person.Phone2,person.PersonImage) : null;
            }

            return null;

        }

        public static cls_ServicesAppUser Find(string UserName)
        {

            int userid = -1;
            int personid = -1;

            if (cls_ServicesAppUser_D.Find(UserName, ref userid, ref personid))
            {

                cls_Person person = cls_Person.FindPerson(personid);

                return (person != null) ? new cls_ServicesAppUser(userid, person.PersonID, person.FirstName,
                    person.SecondName, person.LastName, Convert.ToBoolean(person.Gender), person.Address,
                    person.UserName, person.Password, person.DOB, person.IDNumber, person.Phone1,
                    person.Phone2, person.PersonImage) : null;
            }

            return null;

        }
        private bool _AddUser()
        {

            this.UserID = this.AddPerson() ? cls_ServicesAppUser_D.AddUser(this.PersonID) : -1;
            return (this.UserID > 0);

        }

        private bool _UpdateUser()
        {
            return this.UpdatePerson();
        }

        public static bool DeleteUser(int UserID)
        {
            int _PersonID = Find(UserID).PersonID;
            return IsUserHasReferences(UserID) ? false : cls_ServicesAppUser_D.DeleteUser(UserID) ? DeletePerson(_PersonID) : false;
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
            return cls_ServicesAppUser_D.GetUsers();
        }

    }
}
