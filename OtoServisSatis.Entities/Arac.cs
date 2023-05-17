using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OtoServisSatis.Entities
{
    public class Arac : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Marka Adı"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public int MarkaId { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Renk { get; set; }
        [Display(Name = "Fiyatı"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public decimal Fiyati { get; set; }
        [StringLength(50), Display(Name = "Fiyatı"), Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Modeli { get; set; }
        [StringLength(50), Display(Name = "Kasa Tipi"),Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string KasaTipi { get; set; }
        [Display(Name = "Model Yılı")]
        public int ModelYili { get; set; }
        [Display(Name = "Satışta Mı?")]
        public bool SatistaMi { get; set; }
        [Required(ErrorMessage = "{0} Boş Bırakılamaz!")]
        public string Notlar { get; set; }
        public virtual Marka? Marka { get; set; }
    }
}
