using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;


// Authod:Dmitriy Frolov
namespace CosmoDog
{


    public class RegistryUtils
    {
        //ShowError  to show or hide error messages (default = false).

        //SubKey to set the subkey value (default = "SOFTWARE\\" + Application.ProductName).
        public static readonly string SubKey = "SOFTWARE\\" + System.Windows.Forms.Application.ProductName;
        //BaseRegistryKey to set the base registry key value (default = Registry.LocalMachine)
        public static readonly RegistryKey BaseRegistryKey = Registry.CurrentUser;

        public static string Read(string KeyName, string def="")
        {
            try
            {
                var rk = BaseRegistryKey;
                var sk1 = rk.OpenSubKey(SubKey);
                if (sk1 == null)
                    return def;
                else
                {
                    var obj = sk1.GetValue(KeyName.ToUpper()).ToString();
                    sk1.Close();
                    return obj;
                }
            }
            catch //(Exception e)
            {
                return def;
            }
            
        }

        public static bool Write(string KeyName, object Value, bool isShowIfException=false)
        {
            try
            {
                RegistryKey rk = BaseRegistryKey;
                RegistryKey sk1 = rk.OpenSubKey(SubKey, RegistryKeyPermissionCheck.ReadWriteSubTree);
                if (sk1 == null)
                    sk1 = rk.CreateSubKey(SubKey, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryOptions.None);

                sk1.SetValue(KeyName.ToUpper(), Value);
                sk1.Close();
                return true;
            }
            catch (Exception errr)
            {
                if (isShowIfException)
                    MessageBox.Show(errr.Message + " " + errr.Source + "   " + errr.InnerException + " " + errr.StackTrace);

                return false;
            }
        }

        //public static int? ReadInt(string p)
        //{
        //    return DBUtils.TryParseToIntOrNull(Read(p));
        //}
    }
}