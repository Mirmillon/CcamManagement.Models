using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CcamManagement.Models.EnumTable
{
    public class SousCategorieActe
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SousCategorieActeId { get; set; }
        
        [Required]
        [MaxLength(2)]
        [DataType(DataType.Text)]
        public string SousCategorieCode { get; set; }
        [MaxLength(250)]
        [DataType(DataType.Text)]
        [Display(Name = "Sous Categorie")]
        [Required]
        public string CategorieActeLabel { get; set; }


        public int CategorieActeId { get; set; }
        public CategorieActe CategorieActe { get; set; }

        public List<Acte> Actes { get; set; }

        public SousCategorieActe()
        {
            SousCategorieCode = "00";
            CategorieActeLabel = "Sans";
        }

       
    }
}
