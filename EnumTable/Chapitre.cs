using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CcamManagement.Models.EnumTable
{
    public class Chapitre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(2)]
        [DataType(DataType.Text)]
        public string ChapitreId { get; set; }
        [MaxLength(200)]
        [DataType(DataType.Text)]
        [Display(Name = "Chapitre")]
        [Required]
        public string ChapitreLabel { get; set; }
        [MaxLength(500)]
        [DataType(DataType.Text)]
        [Display(Name = "Précision")]
        public string Precision { get; set; }

        public List<CategorieActe> CategorieActes { get; set; }
    }
}
