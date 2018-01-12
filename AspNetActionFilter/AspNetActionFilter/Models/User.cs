using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetActionFilter.Models
{
    [Table("SiteUsers")]
    public class User
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required ,StringLength(20),DisplayName("Name")]
        public string Name { get; set; }

        [Required,StringLength(20),DisplayName("Surname")]
        public string SurName { get; set; }

        [Required,StringLength(20),DisplayName("Username")]
        public string UserName { get; set; }

        [Required,StringLength(16),DisplayName("Password"),DataType(DataType.Password)]
        public string Password { get; set; }

    }
}