using CAFE_MANAGEMENT_DATAACCESS.CLASSES;
using SpaceLibraries.Classes.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_MANAGEMENT_BUSINESS.CLASSES
{
    public class cls_ServicesDepartments
    {

        enum EN_Mode { AddNew = 0, Update = 1 }
        EN_Mode _Mode;

        public int DepartmentID { set; get; }
        public string DepartmentName { set; get; }
        public string DepartmentImage { set; get; }
        public int CountOfServices { set; get; }

        public cls_ServicesDepartments()
        {

            this.DepartmentID = -1;
            this.DepartmentName = null;
            this.DepartmentImage = null;
            this.CountOfServices = -1;

            _Mode = EN_Mode.AddNew;

        }

        public cls_ServicesDepartments(int DepartmentID, string DepartmentName, string DepartmentImage)
        {

            this.DepartmentID = DepartmentID;
            this.DepartmentName = DepartmentName;
            this.DepartmentImage = DepartmentImage;
            this.CountOfServices = GetCountOfServicesForDepartments(DepartmentName);

            _Mode = EN_Mode.Update;
        }

        public static bool IsDepartmentReferences(int DepartmentID)
        {
            return cls_ServicesDepartments_D.IsDepartmentReferences(DepartmentID);
        }

        public static bool IsExist(string DepartmentName)
        {
            return cls_ServicesDepartments_D.IsExist(DepartmentName);
        }

        public static bool IsExist(int DepartmentID, string DepartmentName)
        {
            return cls_ServicesDepartments_D.IsExist(DepartmentID, DepartmentName);
        }

        public static cls_ServicesDepartments Find(int  DepartmentID)
        {

            string departmentname = "";
            string departmentimage = "";

            if (cls_ServicesDepartments_D.Find(DepartmentID, ref departmentname, ref departmentimage))
                return new cls_ServicesDepartments(DepartmentID, departmentname, departmentimage);

            return null;
        }

        public static cls_ServicesDepartments Find(string DepartmentName)
        {
            int departmentid = -1;
            string departmentimage = "";

            if (cls_ServicesDepartments_D.Find(DepartmentName, ref departmentid, ref departmentimage))
                return new cls_ServicesDepartments(departmentid, DepartmentName, departmentimage);

            return null;
        }

        public static cls_ServicesDepartments FindByService(int ServiceID)
        {

            int departmentid = -1;
            string departmentname = "";
            string departmentimage = "";

            if (cls_ServicesDepartments_D.Find(ServiceID, ref departmentid, ref departmentname, ref departmentimage))
                return new cls_ServicesDepartments(departmentid, departmentname, departmentimage);

            return null;

        }

        public static bool Delete(string DepartmentName)
        {
            return cls_ServicesDepartments_D.Delete(DepartmentName);
        }

        private bool _AddDepartment()
        {
            this.DepartmentID = cls_ServicesDepartments_D.AddDepartment(this.DepartmentName, this.DepartmentImage);
            this.CountOfServices = GetCountOfServicesForDepartments(DepartmentName);
            return this.DepartmentID > 0;
        }

        private bool _UpdateDepartment()
        {
            return cls_ServicesDepartments_D.UpdateDepartment(this.DepartmentID, this.DepartmentName, this.DepartmentImage);
        }

        public bool Save()
        {

            switch (_Mode)
            {

                case EN_Mode.AddNew:
                    if (_AddDepartment())
                    {
                        _Mode = EN_Mode.Update;
                        return true;
                    }

                    break;

                case EN_Mode.Update:
                    if (_UpdateDepartment())
                        return true;
                    break;

            }

            return false;

        }

        public static int GetCountOfServicesForDepartments(string DepartmentName)
        {
            return cls_ServicesDepartments_D.GetCountOfServicesForDepartments(DepartmentName);
        }

        public static DataTable GetDepartments()
        {
            return cls_ServicesDepartments_D.GetDepartments();
        }

    }
}
