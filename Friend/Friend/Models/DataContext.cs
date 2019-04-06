using System.Data.Entity;

namespace MVCFriend.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;

   public class DataContext:DbContext
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