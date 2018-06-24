using PosX.App.Entity;
using System.IO;
using System.Linq;
using Dapper;
using System.Collections.Generic;
using System;

namespace PosX.App.User
{
    public class UserRepository : SqLiteBaseRepository
    {
        public List<User> GetUserList(string searchTxt)
        {
            var sqlCommand = @"SELECT  user.id,
                                                                    user.code,
                                                                    user.name,
                                                                    user.password,
                                                                    user.dept_id,
                                                                    user_department.name as dept_name,
                                                                    user.pos_id,
                                                                    user_position.name as pos_name,
                                                                    user.tel,
                                                                    user.tel_in_company,
                                                                    user.email                                                                    
                                                            from user 
                                                                 left join  user_department on user.dept_id = user_department.id
                                                                 left join  user_position on user.pos_id = user_position.id                                                                        
                                                                
                                                            where lower(user.code) like lower('%" + searchTxt + "%')" +
                                    " or lower(user.name) like lower('%" + searchTxt + "%')" +
                                    " or lower(user_department.name) like lower('%" + searchTxt + "%')" +
                                    " or lower(user_position.name) like lower('%" + searchTxt + "%')" +
                                    " or lower(user.tel) like lower('%" + searchTxt + "%')" +
                                    " or lower(user.tel_in_company) like lower('%" + searchTxt + "%')" +
                                    " or lower(user.email) like lower('%" + searchTxt + "%')";
            using (var cnn = DbConnection())
            {
                cnn.Open();
                List<User> result = cnn.Query<User>(sqlCommand).ToList();
                return result;
            }
        }

        public Exception SaveUser(User user)
        {
            using (var cnn = DbConnection())
            {
                try
                {
                    cnn.Open();
                    cnn.Execute(@"INSERT INTO user(code,name,password,pos_id,dept_id,tel,tel_in_company,email)
                                            VALUES(@code,@name,@password,@pos_id,@dept_id,@tel,@tel_in_company,@email);",
                                  new
                                  {
                                      code = user.Code,
                                      name = user.Name,
                                      password = user.Password,
                                      pos_id = user.PosId,
                                      dept_id = user.DeptId,
                                      tel = user.Tel,
                                      tel_in_company = user.TelInCompany,
                                      email = user.Email
                                  });
                    return null;
                }
                catch (System.Exception ex)
                {
                    return ex;
                }
            }
        }

        public Exception UpdateUser(User user)
        {
            using (var cnn = DbConnection())
            {
                try
                {
                    cnn.Open();
                    cnn.Execute(@"update user set code=@code,name=@name,password=@password,pos_id=@pos_id,dept_id=@dept_id,tel=@tel,tel_in_company=@tel_in_company,email=@email where id = @id",
                                  new
                                  {
                                      code = user.Code,
                                      name = user.Name,
                                      password = user.Password,
                                      pos_id = user.PosId,
                                      dept_id = user.DeptId,
                                      tel = user.Tel,
                                      tel_in_company = user.TelInCompany,
                                      email = user.Email,
                                      id = user.Id
                                  });
                    return null;
                }
                catch (System.Exception ex)
                {
                    return ex;
                }
            }
        }

        public Exception DeleteUser(int id)
        {
            using (var cnn = DbConnection())
            {
                try
                {
                    cnn.Open();
                    cnn.Execute(@"delete from user WHERE id = @id ;", new { id });
                    return null;
                }
                catch (System.Exception ex)
                {
                    return ex;
                }
            }
        }
    }
}
