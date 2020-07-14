using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace ProductServices.Models
{
    public class ProductInformation
    {
        [Key]
        public int Keyboard_Id { get; set; }
        //Vilken typ av brytare tangentbordet har
        public string Switches { get; set; }
        //ISO eller ANSI layout på tangenterna 
        public string Layout { get; set; }
        //Språk på tangenterna 
        public string Language { get; set; }
        //Size mäts i %, ex. 60% keyboard som inte har numpad eller piltangenter eller 100% keyboard som har allt
        public int Size { get; set; }
    }
}
