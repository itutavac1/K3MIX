using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K3MIX
{
    public class CUserData
    {
        public string firstName;
        public string lastName;
        public string email;
        public bool consumer;
    }
    public class CUserDetailedData
    {

    }
    public class CConsumerDetailed : CUserDetailedData
    {
        public string description;
        public string picture;
    }
    public class CUserDetailed : CUserDetailedData
    {
        public string userName;
        public string password;
        public int[] OIB = new int[11];
    }
    public class CUser
    {
        public CUserData User;
        public CUserDetailedData Detailed;

        /// <summary>
        /// Detailed will be created as ConsumerDetailed or UserDetailed
        /// </summary>
        public void CreateDetailed()
        {
            if (User.consumer == true)
            {
                Detailed = new CConsumerDetailed();
            }
            else
            {
                Detailed = new CUserDetailed();
            }
        }
    }
}
