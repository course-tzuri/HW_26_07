using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_26_07
{
    class RoomService :Room
    {
        protected override void SetFeatutures()
        {
           
        }
        

        internal void CleanRoom(RoomForTwo newRoomForTwo)
        {
            newRoomForTwo.IsClean(true);

        }

        internal void CleanRoom(FamilyRoom newFamilyRoom)
        {
            newFamilyRoom.SetIsClean(true);

        }

        internal void CleanRoom(Suite newSuite)
        {

            newSuite.SetIsClean(true);

        }

    }
}
