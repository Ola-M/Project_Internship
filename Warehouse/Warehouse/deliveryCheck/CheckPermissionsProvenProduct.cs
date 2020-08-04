using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.deliveryCheck
{
    public class CheckPermissionsProvenProduct
    {
        warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        int userID;
        CheckPermissions checkPermissions;
        Button buttonDelate;
        Button buttonSave;
        Button buttonFinish;
        Button buttonSummary;
        TextBox textBoxAdd;
        public CheckPermissionsProvenProduct(int userID, Button buttonDelate, Button buttonSave, Button buttonFinish, Button buttonSummary, TextBox textBoxAdd)
        {
            this.userID = userID;
            checkPermissions = new CheckPermissions(this.userID);
            this.buttonSummary = buttonSummary;
            this.buttonDelate = buttonDelate;
            this.buttonFinish = buttonFinish;
            this.buttonSave = buttonSave;
            this.textBoxAdd = textBoxAdd;
        }
        public void provenProductButtons(int deliveryNoteID) { 
            var product = context.Delivery.FirstOrDefault(c => c.deliveryNoteID == deliveryNoteID);

            if (product.@checked == false) 
            { 

                if (checkPermissions.warehouseman() == true)
                {
                    buttonSave.Visible = true;
                }
                if (checkPermissions.warehouseman() == true)
                {
                    buttonDelate.Visible = true;
                }
                if (checkPermissions.warehouseman() == true)
                {
                    buttonFinish.Visible = true;
                }
                if(checkPermissions.warehouseman() == true)
                {
                    textBoxAdd.Visible = true;
                }
            }
            if (checkPermissions.logisticina() == true)
            {
                buttonSummary.Visible = true;
            }
        }
    }
}
