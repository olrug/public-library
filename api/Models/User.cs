using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Nickname { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surame { get; set; } = string.Empty;
        public string SecondName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
    }
}