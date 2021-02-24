using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mom3._3.Models
{
    public class Music
    {
        // properties
        public int Id { get; set; }
        [Required(ErrorMessage = "Du måste ange en artist")]
        public string Artist { get; set; }
        [Required(ErrorMessage ="Du måste ange en titel")]
        public string Title { get; set; }
        [Required(ErrorMessage ="Hur lång är låten?")]
        public int Length { get; set; }
        [Required(ErrorMessage ="Vilken genre är det?")]
        public string Category { get; set; }
    }
}
