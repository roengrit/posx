using PosX.App.Entity;
using System.IO;
using System.Linq;
using Dapper;
using System.Collections.Generic;
using System;

namespace PosX.App.Member
{
    public class MemberRepository : SqLiteBaseRepository
    {
        public List<Member> GetMemberList(string searchTxt)
        {
            var sqlCommand = @"SELECT  member.id,
                                       member.code,
                                       member.tax_id,
                                       member.name,
                                       member.address,
                                       member.tel,
                                       member.fax,
                                       member.email,
                                       member.line,
                                       member.facebook,
                                       member.contact 
                             from member 
                             where lower(member.code) like lower('%" + searchTxt + "%')" +
                                  " or lower(member.name) like lower('%" + searchTxt + "%')";

            using (var cnn = DbConnection())
            {
                cnn.Open();
                List<Member> result = cnn.Query<Member>(sqlCommand).ToList();
                return result;
            }
        }

        public Exception SaveMember(Member member)
        {
            using (var cnn = DbConnection())
            {
                try
                {
                    cnn.Open();
                    cnn.Execute(@"INSERT INTO member(code,tax_id,name,address,tel,fax,email,line,facebook,contact)
                                                  VALUES(@code,@tax_id,@name,@address,@tel,@fax,@email,@line,@facebook,@contact);",
                                  new
                                  {
                                      code = member.Code,
                                      tax_id = member.TaxId,
                                      name = member.Name,
                                      address = member.Address,
                                      tel = member.Tel,
                                      fax = member.Fax,
                                      email = member.Email,
                                      line = member.Line,
                                      facebook = member.Facebook,
                                      contact = member.Contact
                                  });
                    return null;
                }
                catch (System.Exception ex)
                {
                    return ex;
                }
            }
        }

        public Exception UpdateMember(Member member)
        {
            using (var cnn = DbConnection())
            {
                try
                {
                    cnn.Open();
                    cnn.Execute(@"update member set code =@code,tax_id=@tax_id,name=@name,address=@address,tel=@tel,fax=@fax,email=@email,line=@line,facebook=@facebook,contact=@contact where id = @id",
                                  new
                                  {
                                      code = member.Code,
                                      tax_id = member.TaxId,
                                      name = member.Name,
                                      address = member.Address,
                                      tel = member.Tel,
                                      fax = member.Fax,
                                      email = member.Email,
                                      line = member.Line,
                                      facebook = member.Facebook,
                                      contact = member.Contact,
                                      id = member.Id
                                  });
                    return null;
                }
                catch (System.Exception ex)
                {
                    return ex;
                }
            }
        }

        public Exception DeleteMember(int id)
        {
            using (var cnn = DbConnection())
            {
                try
                {
                    cnn.Open();
                    cnn.Execute(@"DELETE FROM member WHERE id = @id ;", new { id });
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
