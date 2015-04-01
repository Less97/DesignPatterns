using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class FacadePurchase
    {
        private BasketSubsystem basketModule = new BasketSubsystem();
        private BuySubsystem buyModule = new BuySubsystem();
        private ConfirmSubsystem confirmModule = new ConfirmSubsystem();

        public void Purchase()
        {
            if(!(basketModule.CheckItems()&&basketModule.IsQuantityAvailable()))
                return;
            if (!(buyModule.VerifyAvailability() && buyModule.RemovePurchasedItems()))
                return;
            confirmModule.SendConfirmationEmail();
        }


    }
}
