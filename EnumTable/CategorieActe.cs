using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CcamManagement.Models.EnumTable
{
    public class CategorieActe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategorieActeId { get; set; }
       
        [MaxLength(2)]
        [Required]
        [DataType(DataType.Text)]
        public string CodeCategorieActe { get; set; }
        
        [MaxLength(150)]
        [DataType(DataType.Text)]
        [Display(Name = "Type Acte")]
        [Required]
        public string LabelCategorieActe { get; set; }

        [MaxLength(2)]
        [Required]
        [DataType(DataType.Text)]
        public string TypeActeId { get; set; }

        public TypeActe TypeActe { get; set; }


        [Display(Name = "Appareil")]
        [Required]
        public string ChapitreAppareilId { get; set; }
        public Chapitre ChapitreAppareil { get; set; }

        public List<SousCategorieActe> SousCategorieActes { get; set; }




    }
}
