using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3
{
    public class jocuri
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id {  get; set; }

        public string Grafica { get; set; }

        public string Tip { get; set; }

        public int Fps { get; set; }

        public string Platforma { get; set; }
    }
}
