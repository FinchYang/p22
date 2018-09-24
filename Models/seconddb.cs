using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace p22.Models
{
    public class secondContext : DbContext
    {
        public secondContext(DbContextOptions<secondContext> options) : base(options)
        {
        }
        public DbSet<police> police { set; get; }
         public DbSet<logging> dapp { set; get; }
          public DbSet<qq> xiao { set; get; }
    }
    [NotMapped]
    public class police
    {
        public int policeId { set; get; }
        [Required]
        public string policenumber { set; get; }
        [Required]
        public string email { set; get; }
        [Required]
        public string name { set; get; }
        public string identitycardnumber { set; get; }
    }
          public class logging
    {
        
        public int loggingId { set; get; }
        [Required]
        public string username { set; get; }
        [Required]
        public string ip { set; get; }
        [Required]
        public string time { set; get; }
        public string operation { set; get; }
    }
           [NotMapped]
    public class qq
    {
        public int qqId { set; get; }
        [Required]
        public string policenumber { set; get; }
        [Required]
        public string email { set; get; }
        [Required]
        public string name { set; get; }
        public string identitycardnumber { set; get; }
    }
}