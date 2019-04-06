

namespace API.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class MariaReneAranibarFriend
    {
        
        [Key]
        public int Friendld { get; set; }
        
        [Required]
       
        public string Name { get; set; }
        
        [Required]
        public double Type { get; set; }
       
        public char Nickname { get; set; }
        
        public DateTime Brithdate { get; set; }
        

    }
}