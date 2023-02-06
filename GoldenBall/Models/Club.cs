using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace GoldenBall.Models
{
    public class Club
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("Club")]

        [Required]
        public String Name { get; set; }

        public String Country { get; set; }
    }
}