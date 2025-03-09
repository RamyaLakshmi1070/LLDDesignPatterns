using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    class ExternalButton
    {
        ExternalDispatcher externalDispatcher = new ExternalDispatcher();
        List<ElevatorController> elevatorCarts = ElevatorCreator.ElevatorList();
        public ExternalButton()
        {
            
        }

        public void PressButton(ElevatorController controller, Direction direction,int floor)
        {
            externalDispatcher.SubmitExternalRequest(controller, direction,floor);
        }
    }
}
