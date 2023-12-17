using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Cafe_Management_System.GLOBAL_CLASSES
{
    public class cls_util
    {

        public enum EN_Directory 
        {
            DepartmentsImages = 1,
            ServicesImages = 2, 
            ManagementAppUsersImages = 3, 
            ServicesAppUsersImages = 4
        }

        public static string GenderateGUID()
        {

            Guid newguid = Guid.NewGuid();
            return newguid.ToString();

        }

        public static string ReplaceFileNameWithGUID(string SourceFile)
        {

            return GenderateGUID() + new FileInfo(SourceFile).Extension;

        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {

            if (!Directory.Exists(FolderPath))
            {

                try
                {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }

                catch (Exception e)
                {
                    MessageBox.Show("Error Creating Folder: " + e.Message);
                    return false;
                }
            }

            return true;

        }

        public static bool CopyImageToProjectImagesFolder(ref string SourceFile, EN_Directory Directory)
        {

            string DestinationFolder = "";

            switch (Directory)
            {

                case EN_Directory.DepartmentsImages:
                    DestinationFolder = @"C:\Cafe-Services-Departments-Images\";
                    break;

                case EN_Directory.ServicesImages:
                    DestinationFolder = @"C:\Cafe-Services-Images\";
                    break;

                case EN_Directory.ManagementAppUsersImages:
                    DestinationFolder = @"C:\Cafe-Management-App-Users-Images\";
                    break;

                case EN_Directory.ServicesAppUsersImages:
                    DestinationFolder = @"C:\Cafe-Services-App-Users-Images\";
                    break;

            }

            if (!CreateFolderIfDoesNotExist(DestinationFolder))
                return false;

            string destinationfile = DestinationFolder + ReplaceFileNameWithGUID(SourceFile);

            try
            {
                File.Copy(SourceFile, destinationfile, true);
            }

            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            SourceFile = destinationfile;
            return true;

        }
        

    }
}
