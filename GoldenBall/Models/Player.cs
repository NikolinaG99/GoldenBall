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
    public class Player
    {
        [Key]
        public int ID { get; set; }

        [DisplayName("Player")]

        [Required]
        public String Name { get; set; }

        [ForeignKey("Club")]
        public int ClubID { get; set; }
        public Club Club { get; set; }

        public String Nationality { get; set; }

        public String Position { get; set; }

        public int Won { get; set; }

        public DateTime Winning_Year { get; set; }
    }
}
