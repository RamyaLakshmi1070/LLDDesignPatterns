using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    class InternalButton
    {
        InternalDispatcher internalDispatcher = new InternalDispatcher();
       public void PressButton(ElevatorController controller, int destinationFloor)
       {
            internalDispatcher.SubmitInternalRequest(controller, destinationFloor);
       }
    }
}
