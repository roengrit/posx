using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PosX.App.Normal
{
    public interface INormalMasterRepository
    {
        NormalMaster GetNormalMaster(int id , string table );
        void SaveNormalMaster(NormalMaster normalMaster , string table);
        List<NormalMaster> GetNormalMasterList(string searchTxt, string table);
    }

    public class NormalMaster
    {
        [Display(Name = "รหัส")]
        public int Id { get; set; }
        [Display(Name = "รายละเอียด")]
        public string Name { get; set; }
    }
}
