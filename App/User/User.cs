using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosX.App.User
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "รหัส")]
        public string Code { get; set; }
        public string Password { get; set; }
        [Display(Name = "ชื่อ")]
        public string Name { get; set; }

        public int PosId { get; set; }
        [Display(Name = "ตำแหน่ง")]
        public string PosName { get; set; }

        public int DeptId { get; set; }
        [Display(Name = "แผนก")]
        public string DeptName { get; set; }
        [Display(Name = "เบอร์โทร")]
        public string Tel { get; set; }
        [Display(Name = "เบอร์โทรภายใน")]
        public string TelInCompany { get; set; }
        [Display(Name = "อีเมล")]
        public string Email { get; set; }

    }
}
