using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLearning.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        public string name { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string subject { get; set; }
        [Required]
        [MaxLength(10,ErrorMessage = "You done messed up bruh")]
        public string message { get; set; }
    }
}
