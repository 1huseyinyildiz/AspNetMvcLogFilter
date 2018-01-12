using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetActionFilter.Models
{
    [Table("Logs")]
    public class Log
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required,DisplayName("Transaction Date")]
        public DateTime DataTime { get; set; }

        [Required,StringLength(25),DisplayName("Username")]
        public string UserName { get; set; }

        [StringLength(100),DisplayName("Action")]
        public string ActionName { get; set;}

        [StringLength(100), DisplayName("Controller")]
        public string ControllerName { get; set; }

        [StringLength(250),DisplayName("İnformation")]
        public string information { get; set; }

    }
}