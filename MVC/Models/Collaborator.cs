using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC.Models
{
    [Table("Collaborators")]
    public class Collaborator
    {
        public Collaborator()
        {
            System.Console.WriteLine("@Entrei no Model");
        }

        [Key]
        public int CollaboratorId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Gender { get; set; }
    }
}
