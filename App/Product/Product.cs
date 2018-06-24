using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosX.App.Product
{
    public class Product
    {

        public int Id { get; set; }
        [Display(Name = "รหัส")]
        public string Code { get; set; }
        [Display(Name = "บาร์โค้ด")]
        public string Barcode { get; set; }
        [Display(Name = "ชื่อสินค้า/บริการ")]
        public string Name { get; set; }
        [Display(Name = "รายละเอียด")]
        public string Description { get; set; }
        public int Type { get; set; }
        [Display(Name = "ยอดคงเหลือ")]
        public decimal BalanceQty { get; set; }
        [Display(Name = "ต้นทุนเฉลี่ย")]
        public decimal AverageCost { get; set; }
        [Display(Name = "ราคาซื้อ")]
        public decimal PurchasePrice { get; set; }
        [Display(Name = "ราคาขาย")]
        public decimal SalePrice { get; set; }
        public int UnitId { get; set; }
        [Display(Name = "หน่วย")]
        public string UnitName { get; set; }
        public int CategoryId { get; set; }
        [Display(Name = "หมวดหมู่")]
        public string CategoryName { get; set; }

    }
}
