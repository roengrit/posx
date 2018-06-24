using PosX.App.Entity;
using System.IO;
using System.Linq;
using Dapper;
using System.Collections.Generic;
using System;

namespace PosX.App.Product
{
    public class ProductRepository : SqLiteBaseRepository
    {
        public List<Product> GetProductList(string searchTxt)
        {
            var sqlCommand = @"SELECT  ic_product.id,
                                                                    ic_product.code,
                                                                    ic_product.barcode,
                                                                    ic_product.name,
                                                                    ic_product.description,
                                                                    ic_product.type,
                                                                    ic_product.category_id,
                                                                    ic_category.name as category_name,
                                                                    ic_product.unit_id,
                                                                    ic_unit.name as unit_name,
                                                                    ic_product.balance_qty,
                                                                    ic_product.average_cost,
                                                                    ic_product.purchase_price,
                                                                    ic_product.sale_price
                                                            from ic_product 
                                                                 left join ic_category on ic_product.category_id = ic_category.id 
                                                                 left join ic_unit on ic_product.unit_id = ic_unit.id
                                                            where lower(ic_product.code) like lower('%" + searchTxt + "%')" +
                                                                 " or lower(ic_product.name) like lower('%" + searchTxt + "%')" +
                                                                 " or lower(ic_product.description) like lower('%" + searchTxt + "%')" +
                                                                 " or lower(ic_category.name) like lower('%" + searchTxt + "%')" +
                                                                 " or lower(ic_unit.name) like lower('%" + searchTxt + "%')";
            using (var cnn = DbConnection())
            {
                cnn.Open();
                List<Product> result = cnn.Query<Product>(sqlCommand).ToList();
                return result;
            }
        }

        public Exception SaveProduct(Product product)
        {
            using (var cnn = DbConnection())
            {
                try
                {
                    cnn.Open();
                    cnn.Execute(@"INSERT INTO ic_product(code,barcode,name,description,type,category_id,unit_id,balance_qty,average_cost,purchase_price,sale_price)
                                                  VALUES(@code,@barcode,@name,@description,@type,@category_id,@unit_id,@balance_qty,@average_cost,@purchase_price,@sale_price);",
                                  new
                                  {
                                      code = product.Code,
                                      barcode = product.Barcode,
                                      name = product.Name,
                                      description = product.Description,
                                      type = product.Type,
                                      category_id = product.CategoryId,
                                      unit_id = product.UnitId,
                                      balance_qty = product.BalanceQty,
                                      average_cost = product.AverageCost,
                                      purchase_price = product.PurchasePrice,
                                      sale_price = product.SalePrice
                                  });
                    return null;
                }
                catch (System.Exception ex)
                {
                    return ex;
                }
            }
        }

        public Exception UpdateProduct(Product product)
        {
            using (var cnn = DbConnection())
            {
                try
                {
                    cnn.Open();
                    cnn.Execute(@"update ic_product set code = @code,barcode = @barcode,name = @name,description = @description,type = @type,category_id = @category_id ,unit_id = @unit_id,purchase_price = @purchase_price,sale_price = @sale_price where id = @id",
                                  new
                                  {
                                      code = product.Code,
                                      barcode = product.Barcode,
                                      name = product.Name,
                                      description = product.Description,
                                      type = product.Type,
                                      category_id = product.CategoryId,
                                      unit_id = product.UnitId,
                                      balance_qty = product.BalanceQty,
                                      average_cost = product.AverageCost,
                                      purchase_price = product.PurchasePrice,
                                      sale_price = product.SalePrice,
                                      id = product.Id
                                  });
                    return null;
                }
                catch (System.Exception ex)
                {
                    return ex;
                }
            }
        }

        public Exception DeleteProduct(int id)
        {
            using (var cnn = DbConnection())
            {
                try
                {
                    cnn.Open();
                    cnn.Execute(@"DELETE FROM ic_product WHERE id = @id ;", new { id });
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
