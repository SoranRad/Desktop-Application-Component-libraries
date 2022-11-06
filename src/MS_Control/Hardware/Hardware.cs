using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;

namespace MS_Control.Hardware
{
    public static class Hardware
    {
        public static string cpu_name()
        {
            try
            {
                ManagementObjectSearcher searcher =
                            new ManagementObjectSearcher("root\\CIMV2",
                            "SELECT * FROM Win32_Processor");
                string res = "";

                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["Name"].ToString() + "\n";
                }
                return res;
            }
            catch
            {
                return string.Empty;
            }
        }
        
        public static string cpu_temp()
        {
            try
            {
                ManagementObjectSearcher searcher =
                            new ManagementObjectSearcher("root\\WMI",
                            "SELECT * FROM MSAcpi_ThermalZoneTemperature");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["CurrentTemperature"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {

                return string.Empty;
            }
        }
        public static string cpu_caption()
        {
            try
            {
                ManagementObjectSearcher searcher =
                           new ManagementObjectSearcher("root\\CIMV2",
                           "SELECT * FROM Win32_Processor");
                string res = "";

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    res += queryObj["Caption"].ToString() + "\n";

                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static string cpu_clock_speed()
        {
            try
            {
                ManagementObjectSearcher searcher =
                           new ManagementObjectSearcher("root\\CIMV2",
                           "SELECT * FROM Win32_Processor");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["CurrentClockSpeed"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static string cpu_voltage()
        {
            try
            {
                ManagementObjectSearcher searcher =
                           new ManagementObjectSearcher("root\\CIMV2",
                           "SELECT * FROM Win32_Processor");
                string res = "";

                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["CurrentVoltage"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static string cpu_vendor()
        {
            try
            {
                ManagementObjectSearcher searcher =
                         new ManagementObjectSearcher("root\\CIMV2",
                         "SELECT * FROM Win32_Processor");
                string res = "";

                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["Manufacturer"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static string cpu_core_count()
        {
            try
            {
                ManagementObjectSearcher searcher =
                            new ManagementObjectSearcher("root\\CIMV2",
                            "SELECT * FROM Win32_Processor");
                string res = "";

                foreach (ManagementObject queryObj in searcher.Get())
                {
                    res += queryObj["NumberOfCores"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static string cpu_id()
        {
            try
            {
                ManagementObjectSearcher searcher =
                           new ManagementObjectSearcher("root\\CIMV2",
                           "SELECT * FROM Win32_Processor");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["ProcessorId"].ToString() + "\n";

                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static string cpu_maximum_clock()
        {
            try
            {
                ManagementObjectSearcher searcher =
                            new ManagementObjectSearcher("root\\CIMV2",
                            "SELECT * FROM Win32_Processor");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["MaxClockSpeed"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public static string windows_build()
        {
            try
            {
                ManagementObjectSearcher searcher =
                           new ManagementObjectSearcher("root\\CIMV2",
                           "SELECT * FROM Win32_OperatingSystem");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["BuildNumber"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static string windows_caption()
        {
            try
            {
                ManagementObjectSearcher searcher =
                           new ManagementObjectSearcher("root\\CIMV2",
                           "SELECT * FROM Win32_OperatingSystem");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["Caption"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static string windows_install_date()
        {
            try
            {
                ManagementObjectSearcher searcher =
                          new ManagementObjectSearcher("root\\CIMV2",
                          "SELECT * FROM Win32_OperatingSystem");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["InstallDate"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static string windows_vendor()
        {
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_OperatingSystem");
            string res = "";
            foreach (ManagementObject queryObj in searcher.Get())
            {

                res += queryObj["Manufacturer"].ToString() + "\n";

            }
            return res;
        }
        public static string windows_number_of_users()
        {
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_OperatingSystem");
            string res = "";
            foreach (ManagementObject queryObj in searcher.Get())
            {

                res += queryObj["NumberOfUsers"].ToString() + "\n";
            }
            return res;
        }
        public static string windows_organization()
        {
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_OperatingSystem");
            string res = "";
            foreach (ManagementObject queryObj in searcher.Get())
            {

                res += queryObj["Organization"].ToString() + "\n";
            }
            return res;
        }
        public static string windows_registered_user()
        {
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_OperatingSystem");
            string res = "";
            foreach (ManagementObject queryObj in searcher.Get())
            {

                res += queryObj["RegisteredUser"].ToString() + "\n";
            }
            return res;
        }
        public static string windows_serial_number()
        {
            ManagementObjectSearcher searcher =
                  new ManagementObjectSearcher("root\\CIMV2",
                  "SELECT * FROM Win32_OperatingSystem");
            string res = "";
            foreach (ManagementObject queryObj in searcher.Get())
            {

                res += queryObj["SerialNumber"].ToString() + "\n";
            }
            return res;
        }
        public static string windows_path()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.System).ToString();
        }
        public static string windows_version()
        {
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_OperatingSystem");
            string res = "";
            foreach (ManagementObject queryObj in searcher.Get())
            {

                res += queryObj["Version"].ToString() + "\n";
            }
            return res;
        }
        public static string windows_version2()
        {
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_OperatingSystem");
            string res = "";
            foreach (ManagementObject queryObj in searcher.Get())
            {

                res += queryObj["CSDVersion"].ToString() + "\n";
            }
            return res;
        }
        public static string windows_pc_name()
        {
            ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_OperatingSystem");
            string res = "";
            foreach (ManagementObject queryObj in searcher.Get())
            {

                res += queryObj["CSName"].ToString() + "\n";
            }
            return res;
        }
        public static string windows_last_bootup()
        {
            ManagementObjectSearcher searcher =
                   new ManagementObjectSearcher("root\\CIMV2",
                   "SELECT * FROM Win32_OperatingSystem");
            string res = "";
            foreach (ManagementObject queryObj in searcher.Get())
            {

                res += queryObj["LastBootUpTime"].ToString() + "\n";
            }
            return res;

        }
        public static string windows_drives()
        {
            string[] info = Environment.GetLogicalDrives();
            string res = "";
            foreach (string s in info)
            {
                res += s + "\n";
            }
            return res;

        }
        public static string windows_os_version()
        {
            return Environment.OSVersion.VersionString;
        }
        public static string windows_start_time()
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, Environment.TickCount);


            return ts.Hours.ToString() + ":" + ts.Minutes.ToString() + ":" + ts.Seconds.ToString();
        }
        
        public static string Hard_caption()
        {
            try
            {
                ManagementObjectSearcher searcher =
                           new ManagementObjectSearcher("root\\CIMV2",
                           "SELECT * FROM Win32_DiskDrive");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["Caption"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static string Hard_interface_type()
        {
            try
            {
                ManagementObjectSearcher searcher =
                           new ManagementObjectSearcher("root\\CIMV2",
                           "SELECT * FROM Win32_DiskDrive");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["InterfaceType"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static string Hard_numberof_partitions()
        {
            try
            {

                ManagementObjectSearcher searcher =
                    new ManagementObjectSearcher("root\\CIMV2",
                    "SELECT * FROM Win32_DiskDrive");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["Partitions"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static string Hard_size()
        {
            try
            {
                ManagementObjectSearcher searcher =
                        new ManagementObjectSearcher("root\\CIMV2",
                        "SELECT * FROM Win32_DiskDrive");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["Size"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public static string sound_caption()
        {
            try
            {
                ManagementObjectSearcher searcher =
                            new ManagementObjectSearcher("root\\CIMV2",
                            "SELECT * FROM Win32_SoundDevice");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["Caption"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static string sound_vendor()
        {
            try
            {
                ManagementObjectSearcher searcher =
                           new ManagementObjectSearcher("root\\CIMV2",
                           "SELECT * FROM Win32_SoundDevice");
                string res = "";

                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["Manufacturer"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        public static string video_name()
        {
            try
            {
                ManagementObjectSearcher searcher =
                            new ManagementObjectSearcher("root\\CIMV2",
                            "SELECT * FROM Win32_VideoController");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["Name"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static string video_numberof_colors()
        {
            try
            {
                ManagementObjectSearcher searcher =
                            new ManagementObjectSearcher("root\\CIMV2",
                            "SELECT * FROM Win32_VideoController");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    if (queryObj["CurrentNumberOfColors"] != null)
                        res += queryObj["CurrentNumberOfColors"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static string video_driver_date()
        {
            try
            {
                ManagementObjectSearcher searcher =
                           new ManagementObjectSearcher("root\\CIMV2",
                           "SELECT * FROM Win32_VideoController");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["DriverDate"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static string video_driver_version()
        {
            try
            {
                ManagementObjectSearcher searcher =
                           new ManagementObjectSearcher("root\\CIMV2",
                           "SELECT * FROM Win32_VideoController");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["DriverVersion"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static string video_descrip()
        {
            try
            {
                ManagementObjectSearcher searcher =
                           new ManagementObjectSearcher("root\\CIMV2",
                           "SELECT * FROM Win32_VideoController");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    if (queryObj["VideoModeDescription"] != null)

                        res += queryObj["VideoModeDescription"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static string video_processor()
        {
            try
            {
                ManagementObjectSearcher searcher =
                            new ManagementObjectSearcher("root\\CIMV2",
                            "SELECT * FROM Win32_VideoController");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["VideoProcessor"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        
        
        public static string mb_vendor()
        {
            try
            {
                ManagementObjectSearcher searcher =
                           new ManagementObjectSearcher("root\\CIMV2",
                           "SELECT * FROM Win32_BaseBoard");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    res += queryObj["Manufacturer"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static string mb_serial_number()
        {
            try
            {
                ManagementObjectSearcher searcher =
                            new ManagementObjectSearcher("root\\CIMV2",
                            "SELECT * FROM Win32_BaseBoard");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["SerialNumber"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        public static string mb_version()
        {
            try
            {
                ManagementObjectSearcher searcher =
                            new ManagementObjectSearcher("root\\CIMV2",
                            "SELECT * FROM Win32_BaseBoard");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["Version"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }

        }
        public static string mb_system_model()
        {
            try
            {
                ManagementObjectSearcher searcher =
                           new ManagementObjectSearcher("root\\CIMV2",
                           "SELECT * FROM Win32_ComputerSystem");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["Model"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
        

        public static string ram_size()
        {
            try
            {
                ManagementObjectSearcher searcher =
                            new ManagementObjectSearcher("root\\CIMV2",
                            "SELECT * FROM Win32_ComputerSystem");
                string res = "";
                foreach (ManagementObject queryObj in searcher.Get())
                {

                    res += queryObj["TotalPhysicalMemory"].ToString() + "\n";
                }
                return res;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
