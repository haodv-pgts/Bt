using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Bai2
{
    public class FilterEmails
    {
        public List<string> FilterEmail(string[] emails)
        {
            // khoi tao mang danh sach email
            Dictionary<string,string> keyEmails = new Dictionary<string, string>();

            // logic loc email
            foreach (string email in emails) {
                // tach chuỗi name dùng split 
                string[] splitEmail = email.Split('@');
                string name = splitEmail[0];
                string domain = splitEmail[1];

                // tach truoc dau + de noi chuoi phu them
                string baseName = name.Split('+')[0];

                string newEmail = $"{baseName}@{domain}";

                // check trong keyEmails co mail ch roi them moi
                if (!keyEmails.ContainsKey(newEmail))
                {
                    keyEmails[newEmail] = email ;
                }

            }
            return keyEmails.Values.ToList();
        }
    }
}
