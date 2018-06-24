using PosX.App.Entity;
using System.IO;
using System.Linq;
using Dapper;
using System.Collections.Generic;

namespace PosX.App.Normal
{
    public class NormalMasterRepository : SqLiteBaseRepository
    {
        public NormalMaster GetNormalMaster(int id, string table)
        {

            using (var cnn = DbConnection())
            {
                cnn.Open();
                NormalMaster result = cnn.Query<NormalMaster>(@"SELECT id, name from " + table + " WHERE Id = @id", new { id }).FirstOrDefault();
                return result;
            }
        }

        public List<NormalMaster> GetNormalMasterList(string searchTxt, string table)
        {

            using (var cnn = DbConnection())
            {
                cnn.Open();
                List<NormalMaster> result = cnn.Query<NormalMaster>(@"SELECT id, name from " + table + (string.IsNullOrEmpty(searchTxt) ? "" : " WHERE lower(name) like lower('%" + searchTxt + "%')")).ToList();
                return result;
            }
        }

        public void SaveNormalMaster(NormalMaster normalMaster, string table)
        {
            using (var cnn = DbConnection())
            {
                cnn.Open();
                cnn.Execute(@"INSERT INTO " + table + @" (name ) VALUES  (@Name);", normalMaster);
            }
        }

        public void UpdateNormalMaster(NormalMaster normalMaster, string table)
        {
            using (var cnn = DbConnection())
            {
                cnn.Open();
                normalMaster.Id = cnn.Execute(@"UPDATE " + table + @" SET name = @Name WHERE id = @id;", new { normalMaster.Name, normalMaster.Id });
            }
        }

        public void DeleteNormalMaster(int id, string table)
        {
            using (var cnn = DbConnection())
            {
                cnn.Open();
                cnn.Execute(@"DELETE FROM " + table + @" WHERE id = @id ;", new { id });
            }
        }
    }
}
