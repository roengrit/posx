using PosX.App.Entity;
using System.IO;
using System.Linq;
using Dapper;
using System.Collections.Generic;

namespace PosX.App.Normal
{
    public class NormalMasterRepository : SqLiteBaseRepository, INormalMasterRepository
    {
        public NormalMaster GetNormalMaster(int id , string table)
        {

            using (var cnn = DbConnection())
            {
                cnn.Open();
                NormalMaster result = cnn.Query<NormalMaster>( @"SELECT id, name from " + table  + " WHERE Id = @id", new { id }).FirstOrDefault();
                return result;
            }
        }

        public List<NormalMaster> GetNormalMasterList(string searchTxt, string table)
        {

            using (var cnn = DbConnection())
            {
                cnn.Open();
                List<NormalMaster> result = cnn.Query<NormalMaster>(@"SELECT id, name from " + table + (string.IsNullOrEmpty(searchTxt)? "" : " WHERE lower(name) like lower('%"+ searchTxt +"%')")).ToList();
                return result;
            }
        }

        public void SaveNormalMaster(NormalMaster normalMaster, string table)
        {
            using (var cnn = DbConnection())
            {
                cnn.Open();
                normalMaster.Id = cnn.Execute(@"INSERT INTO " + table + @" (name ) VALUES  (@Name);", normalMaster);
            }
        }
    }
}
