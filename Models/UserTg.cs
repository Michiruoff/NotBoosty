using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NotBoosty.Models
{
    public class UserTg
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public UserData User { get; set; } = default!;
        public string TgId { get; set; } = default!;
    }
}
