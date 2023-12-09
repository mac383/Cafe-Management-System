using CAFE_MANAGEMENT_DATAACCESS.CLASSES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAFE_MANAGEMENT_BUSINESS.CLASSES
{
    public class cls_Services
    {

        enum EN_Mode { AddNew = 0, Update = 2 }
        EN_Mode _Mode;

        public int ServiceID { set; get; }
        public string ServiceName { set; get; }
        public string ServiceDescription { set; get; }
        public string ServiceImage { set; get; }
        public cls_ServicesDepartments Department { set; get; }

        public cls_Services()
        {

            this.ServiceID = -1;
            this.ServiceName = null;
            this.ServiceDescription = null;
            this.ServiceImage = null;
            this.Department = new cls_ServicesDepartments();

            this._Mode = EN_Mode.AddNew;

        }

        public cls_Services(int ServiceID, string ServiceName, string ServiceDescription, string ServiceImage)
        {

            this.ServiceID = ServiceID;
            this.ServiceName = ServiceName;
            this.ServiceDescription = ServiceDescription;
            this.ServiceImage = ServiceImage;
            this.Department = cls_ServicesDepartments.FindByService(this.ServiceID);

            this._Mode = EN_Mode.Update;

        }

        public static bool IsExist(string ServiceName)
        {
            return cls_Services_D.IsExist(ServiceName);
        }

        public static bool IsExist(int ServiceID, string ServiceName)
        {
            return cls_Services_D.IsExist(ServiceID, ServiceName);
        }

        public static bool IsServiceReferences(int ServiceID)
        {
            return cls_Services_D.IsServiceReferences(ServiceID);
        }

        public static cls_Services Find(int ServiceID)
        {

            string servicename = "";
            string servicedescription = "";
            string serviceimage = "";

            if (cls_Services_D.Find(ServiceID, ref servicename, ref servicedescription, ref serviceimage))
                return new cls_Services(ServiceID, servicename, servicedescription, serviceimage);

            return null;

        }

        public static cls_Services Find(string ServiceName)
        {

            int serviceid = -1;
            string servicedescription = "";
            string serviceimage = "";

            if (cls_Services_D.Find(ref serviceid, ServiceName, ref servicedescription, ref serviceimage))
                return new cls_Services(serviceid, ServiceName, servicedescription, serviceimage);

            return null;

        }

        public static cls_Services FindByOptionID(int OptionID)
        {

            int serviceid = -1;
            string servicename = "";
            string servicedescription = "";
            string serviceimage = "";

            if (cls_Services_D.FindByOptionID(OptionID, ref serviceid, ref servicename, ref servicedescription, ref serviceimage))
                return new cls_Services(serviceid, servicename, servicedescription, serviceimage);

            return null;

        }

        public static bool Delete(int ServiceID)
        {
            return cls_Services_D.Delete(ServiceID);
        }

        private bool _AddService()
        {
            
            this.ServiceID = cls_Services_D.AddService(this.ServiceName, this.ServiceDescription,
                this.Department.DepartmentID, this.ServiceImage);

            if (this.ServiceID > 0)
                this.Department = cls_ServicesDepartments.FindByService(this.ServiceID);

            return this.ServiceID > 0;

        }

        private bool _UpdateService()
        {
            return cls_Services_D.UpdateService(this.ServiceID, this.ServiceName, this.ServiceDescription,
                this.Department.DepartmentID, this.ServiceImage);
        }

        public bool Save()
        {

            switch (_Mode)
            {

                case EN_Mode.AddNew:
                    if (_AddService())
                    {
                        _Mode = EN_Mode.Update;
                        return true;
                    }
                    break;

                case EN_Mode.Update:
                    if (_UpdateService())
                        return true;
                    break;
            }

            return false;

        }

        public static int GetCountOfOptionsForService(int ServiceID)
        {
            return cls_Services.GetCountOfOptionsForService(ServiceID);
        }

        public static DataTable GetServices()
        {
            return cls_Services_D.GetServices();
        }
    }
}
