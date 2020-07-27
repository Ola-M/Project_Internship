using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace Warehouse
{
    public class AddExcelToDatabase
    {
        FormZalogowany formZalogowany = new FormZalogowany(1);
        warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();

        public void addExcel(List<Product> prod)
        {

            try
            {
                DapperPlusManager.Entity<Product>().Table("Product");
                if (prod != null)
                {
                    foreach (Product product in prod)
                    {
                        context.Product.Add(product);
                    }
                    context.SaveChanges();
                }

            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }

            }
        }
        }
    }

