using CAFE_MANAGEMENT_DATAACCESS.CLASSES;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_MANAGEMENT_BUSINESS.CLASSES
{
    public class cls_Person
    {

        public enum EN_Gender { female = 0, male = 1}

        public int PersonID { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string LastName { set; get; }
        public Nullable<EN_Gender> Gender { set; get; }
        public string Address { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public DateTime DOB { set; get; }
        public string IDNumber { set; get; }
        public string Phone1 { set; get; }
        public string Phone2 { set; get; }
        public string PersonImage { set; get; }

        protected cls_Person()
        {

            this.PersonID = -1;
            this.FirstName = string.Empty;
            this.SecondName = string.Empty;
            this.LastName = null;
            this.Gender = null;
            this.Address = string.Empty;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.DOB = DateTime.MinValue;
            this.IDNumber = null;
            this.Phone1 = string.Empty;
            this.Phone2 = null;
            this.PersonImage = null;

        }

        protected cls_Person(string firstName, string secondName, string lastName, bool gender,
            string address, string userName, DateTime dOB, string iDNumber, string phone1,
            string phone2, string personImage)
        {

            PersonID = FindPerson(userName).PersonID;
            FirstName = firstName;
            SecondName = secondName;
            LastName = lastName;
            Gender = (gender) ? EN_Gender.male : EN_Gender.female;
            Address = address;
            UserName = userName;
            Password = null;
            DOB = dOB;
            IDNumber = iDNumber;
            Phone1 = phone1;
            Phone2 = phone2;
            PersonImage = personImage;

        }

        protected cls_Person(int personID, string firstName, string secondName, string lastName, bool gender,
            string address, string userName, string password, DateTime dOB, string iDNumber, string phone1,
            string phone2, string personImage)
        {

            PersonID = personID;
            FirstName = firstName;
            SecondName = secondName;
            LastName = lastName;
            Gender = (gender) ? EN_Gender.male : EN_Gender.female;
            Address = address;
            UserName = userName;
            Password = password;
            DOB = dOB;
            IDNumber = iDNumber;
            Phone1 = phone1;
            Phone2 = phone2;
            PersonImage = personImage;

        }

        protected static bool IsPersonExist(string UserName)
        {
            return cls_Person_D.IsExist(UserName);
        }

        protected static bool IsPersonExist(int PersonID, string UserName)
        {
            return cls_Person_D.IsExist(PersonID, UserName);
        }

        protected static bool IsPersonExistByIDNumber(string IDNumber)
        {
            return cls_Person_D.IsPersonExistByIDNumber(IDNumber);
        }

        protected static bool IsPersonExistByIDNumber(int PersonID, string IDNumber)
        {
            return cls_Person_D.IsPersonExistByIDNumber(PersonID, IDNumber);
        }

        protected static bool IsPersonExistByPhone(string Phone)
        {
            return cls_Person_D.IsPersonExistByPhone(Phone);
        }

        protected static bool IsPersonExistByPhone(int PersonID, string Phone)
        {
            return cls_Person_D.IsPersonExistByPhone(PersonID, Phone);
        }

        protected static bool IsPersonHasReferences(int PersonID)
        {
            return cls_Person_D.GetCountOfPersonReferences(PersonID) > 0;
        }

        protected static cls_Person FindPerson(int personID)
        {

            string firstName = "";
            string secondName = "";
            string lastName = "";
            bool gender = false;
            string address = "";
            string userName = "";
            string password = "";
            DateTime dob = DateTime.MinValue;
            string idNumber = "";
            string phone1 = "";
            string phone2 = "";
            string personImage = "";

            if (cls_Person_D.Find(personID, ref firstName, ref secondName, ref lastName, ref gender, ref address,
                ref userName, ref password, ref dob, ref idNumber, ref phone1, ref phone2, ref personImage))

                return new cls_Person(personID, firstName, secondName, lastName, gender, address, userName, password,
                    dob, idNumber, phone1, phone2, personImage);

            return null;

        }

        protected static cls_Person FindPerson(string userName)
        {
            
            int personID = -1;
            string firstName = "";
            string secondName = "";
            string lastName = "";
            bool gender = false;
            string address = "";
            string password = "";
            DateTime dob = DateTime.MinValue;
            string idNumber = "";
            string phone1 = "";
            string phone2 = "";
            string personImage = "";

            if (cls_Person_D.Find(userName, ref personID, ref firstName, ref secondName, ref lastName, ref gender,
                ref address, ref password, ref dob, ref idNumber, ref phone1, ref phone2, ref personImage))

                return new cls_Person(personID, firstName, secondName, lastName, gender, address, userName,
                    password, dob, idNumber, phone1, phone2, personImage);

            return null;

        }

        protected bool AddPerson()
        {

            this.PersonID = cls_Person_D.AddPerson(this.FirstName, this.SecondName, this.LastName,
                Convert.ToBoolean(this.Gender), this.Address, this.UserName, this.Password, this.DOB,
                this.IDNumber, this.Phone1, this.Phone2, this.PersonImage);

            return this.PersonID > 0;

        }

        protected bool UpdatePerson()
        {

            return cls_Person_D.UpdatePerson(this.PersonID, this.FirstName, this.SecondName, this.LastName,
                Convert.ToBoolean(this.Gender), this.Address, this.UserName, this.DOB,
                this.IDNumber, this.Phone1, this.Phone2, this.PersonImage);

        }

        protected static bool DeletePerson(int PersonID)
        {

            return IsPersonHasReferences(PersonID) ? false : cls_Person_D.Delete(PersonID);

        }

    }
}
