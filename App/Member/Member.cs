using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosX.App.Member
{
    public class Member
    {

        public int Id { get; set; }
        [Display(Name = "รหัส")]
        public string Code { get; set; }
        [Display(Name = "เลขประจำตัวผู้เสียภาษี")]
        public string TaxId { get; set; }
        [Display(Name = "ชื่อสมาชิก")]
        public string Name { get; set; }
        [Display(Name = "ที่อยู่")]
        public string Address { get; set; }
        [Display(Name = "โทรศัพท์")]
        public string Tel { get; set; }
        [Display(Name = "โทรสาร")]
        public string Fax { get; set; }
        [Display(Name = "อีเมล")]
        public string Email { get; set; }
        [Display(Name = "Line")]
        public string Line { get; set; }
        [Display(Name = "Facebook")]
        public string Facebook { get; set; }
        [Display(Name = "ติดต่อ")]
        public string Contact { get; set; }

    }
}
