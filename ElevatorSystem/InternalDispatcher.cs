using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    class InternalDispatcher
    {
        public void SubmitInternalRequest(ElevatorController controller, int destinationfloor)
        {
            controller.SubmitInternalRequest(destinationfloor);
        }
    }
}
