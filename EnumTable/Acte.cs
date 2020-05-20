using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CcamManagement.Models.EnumTable
{
    public class Acte
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [MaxLength(7)]
        [MinLength(7)]
        public string ActeId { get; set; }

        [MaxLength(250)]
        [DataType(DataType.Text)]
        [Display(Name = "Label")]
        [Required]
        public string ActeLabel { get; set; }

        public int SousCategorieActeId { get; set; }

        public SousCategorieActe SousCategorieActe { get; set; }



    }
}
