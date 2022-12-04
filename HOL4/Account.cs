using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HOL4.Models
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Range(1, long.MaxValue, ErrorMessage = "Account number cannot be negative or zero")]
        [StringLength(byte.MaxValue,MinimumLength =2,ErrorMessage ="Minimum length must be 2")]
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        [Range(500, long.MaxValue, ErrorMessage = "Minimum balance must be 500")]
        public double CurrentBalance { get; set; }
    }
}