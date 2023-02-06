using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using GoldenBall.Models;



namespace GoldenBall.ViewModels
{
    public class PlayerVM
    {
        public Player Player { get; set; }

        public IEnumerable<SelectListItem> ClubList { get; set; }
    }
}
