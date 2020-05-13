using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITHS_Labb1_FelixGramell.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int Order_Id { get; set; }
        public string User_Email { get; set; }
        public string OrderAdress { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
