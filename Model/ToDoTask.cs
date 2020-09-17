using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeOrganizerAPI.Model
{
    public class ToDoTask
    {
        [Column("TDTSK_ID")]
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        [Column("TDTSK_NAME")]
        public string Name { get; set; }

        [Required]
        [MaxLength(255)]
        [Column("TDTSK_DESC")]
        public string Description { get; set; }
    }
}