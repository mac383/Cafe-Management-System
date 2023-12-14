using CAFE_MANAGEMENT_DATAACCESS.CLASSES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CAFE_MANAGEMENT_BUSINESS.CLASSES
{
    public class cls_Options
    {

        enum EN_Mode { AddNew = 1, Update = 2 }
        EN_Mode _Mode;

        public int OptionID { set; get; }
        public string OptionName { set; get; }
        public double OptionPrice { set; get; }
        public long OptionValue { set; get; }

        public cls_Services Service;

        public cls_Options(int ServiceID)
        {

            this.OptionID = -1;
            this.OptionName = null;
            this.OptionPrice = -1;
            this.OptionValue = 0;
            this.Service = cls_Services.Find(ServiceID);

            this._Mode = EN_Mode.AddNew;

        }

        public cls_Options(int optionID, string optionName, double optionPrice, long optionValue)
        {

            this.OptionID = optionID;
            this.OptionName = optionName;
            this.OptionPrice = optionPrice;
            this.OptionValue = optionValue;
            this.Service = cls_Services.FindByOptionID(this.OptionID);

            this._Mode = EN_Mode.Update;

        }

        public static bool IsExist(string OptionName)
        {
            return cls_Options_D.IsExist(OptionName);
        }

        public static bool IsExist(int OptionID, string OptionName)
        {
            return cls_Options_D.IsExist(OptionID, OptionName);
        }

        public static cls_Options Find(int OptionID)
        {

            string optionName = "";
            double optionPrice = -1;
            long optionValue = 0;

            if (cls_Options_D.Find(OptionID, ref optionName, ref optionPrice, ref optionValue))
                return new cls_Options(OptionID, optionName, optionPrice, optionValue);

            return null;

        }

        public static cls_Options Find(string OptionName)
        {

            int optionID = -1;
            double optionPrice = -1;
            long optionValue = 0;

            if (cls_Options_D.Find(ref optionID, OptionName, ref optionPrice, ref optionValue))
                return new cls_Options(optionID, OptionName, optionPrice, optionValue);

            return null;

        }

        public static bool Delete(int OptionID)
        {
            return cls_Options_D.Delete(OptionID);
        }

        private bool _AddOption()
        {

            this.OptionID = cls_Options_D.AddOption(this.OptionName, this.OptionPrice, this.OptionValue, this.Service.ServiceID);

            if (OptionID > 0)
                this.Service = cls_Services.FindByOptionID(this.OptionID);

            return OptionID > 0;

        }

        private bool _UpdateOption()
        {
            return cls_Options_D.UpdateOption(this.OptionID, this.OptionName, this.OptionPrice, this.OptionValue, this.Service.ServiceID);
        }

        public bool Save()
        {
            
            switch (_Mode)
            {

                case EN_Mode.AddNew:
                    if (_AddOption())
                    {
                        _Mode = EN_Mode.Update;
                        return true;
                    }
                    break;

                case EN_Mode.Update:
                    if (_UpdateOption())
                        return true;
                    break;

            }

            return false;

        }

        public static DataTable GetOptions(int ServiceID)
        {
            return cls_Options_D.GetOptions(ServiceID);
        }

        public static long GetMaximumOptionValue()
        {
            return cls_Options_D.GetMaximumOptionValue();
        }

    }
}
