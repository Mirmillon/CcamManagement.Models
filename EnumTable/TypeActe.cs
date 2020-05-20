using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CcamManagement.Models.EnumTable
{
    public class TypeActe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [MaxLength(2)]
        [DataType(DataType.Text)]
        public string TypeActeId { get; set; }
        [MaxLength(15)]
        [DataType(DataType.Text)]
        [Display(Name = "Type Acte")]
        [Required]
        public string Label { get; set; }

        public List<CategorieActe> CategorieActes { get; set; }
    }
}
