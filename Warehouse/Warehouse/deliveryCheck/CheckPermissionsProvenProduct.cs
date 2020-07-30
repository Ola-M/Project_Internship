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
        int userID;
        CheckPermissions checkPermissions;
        Button buttonDelate;
        Button buttonSave;
        Button buttonFinish;
        Button buttonSummary;
        public CheckPermissionsProvenProduct(int userID, Button buttonDelate, Button buttonSave, Button buttonFinish, Button buttonSummary)
        {
            this.userID = userID;
            checkPermissions = new CheckPermissions(this.userID);
            this.buttonSummary = buttonSummary;
            this.buttonDelate = buttonDelate;
            this.buttonFinish = buttonFinish;
            this.buttonSave = buttonSave;

        }
        public void provenProductButtons()
        {
            if(checkPermissions.logisticina() == true)
            {
                buttonSummary.Visible = true; 
            }
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
        }
    }
}
