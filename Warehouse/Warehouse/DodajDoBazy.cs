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
    public class DodajDoBazy
    {
        /*warehouseDatabaseEntities context = new warehouseDatabaseEntities();

        public void zapisPdfBaza()
        {
          
             try
             {
                 DapperPlusManager.Entity<invoice>().Table("invoice");
                 List<invoice> invoices = invoiceBindingSource.DataSource as List<invoice>;
                 if (invoices != null)
                 {
                     foreach (invoice inv in invoices)
                     {
                         context.invoice.Add(inv);
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
         }*/
        }
    }

