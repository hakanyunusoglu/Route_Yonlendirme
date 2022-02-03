using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Route_Yonlendirme.Models
{
    public class UserDetailModel
    {
        public List<userTablo> userList { get; set; }
        public userTablo users { get; set; }
    }
}