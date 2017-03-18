using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Domain.Entities
{
    public class EmailSettings
    {
        public string MailToAddress = "dapito.sherwin@gmail.com";
        public string MailFromAddress = "dapito.sherwin@gmail.com";
        public bool UseSsl = true;
        public string Username = "dapito.sherwin@gmail.com";
        public string Password = "liolwyxvpxnmvuse";
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;
     //   public bool WriteAsFile = false;
     //   public string FileLocation = @"c:\sports_store_emails";
    }
}
