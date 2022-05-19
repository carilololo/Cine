using System.ComponentModel.DataAnnotations;

namespace Cine.Web.Models
{
    public class Cinema
    {
        public int id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

    }
}
