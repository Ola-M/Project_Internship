using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.deliveryCheck
{
    public class CheckPermissions
    {
        UserPermissions userPermissions;
        int userID;
        warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        List<UserPermissions> xxx = new List<UserPermissions>();
        CheckPermissionsProvenProduct checkPermissionsProvenProduct;

        public CheckPermissions(int userID)
        {
            this.userID = userID;
            xxx = context.UserPermissions.ToList();
        }

        public bool logisticina()
        {
            for(int i = 0; i < xxx.Count; i++)
            {
                if((xxx[i].permissionsID == 2)&&(xxx[i].userID== userID))
                {
                    return true;
                }
            }
            return false;

        }
        public bool administrator()
        {
            for (int i = 0; i < xxx.Count; i++)
            {
                if ((xxx[i].permissionsID == 3) && (xxx[i].userID == userID))
                {
                    return true;
                }
            }
            return false;
        }
        public bool warehouseman()
        {
            for (int i = 0; i < xxx.Count; i++)
            {
                if ((xxx[i].permissionsID == 1) && (xxx[i].userID == userID))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
