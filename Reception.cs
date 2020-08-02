using Client;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace HW_26_07
{
   static class Reception
    {
        const int numberOfRooms = 100;
        static int numberOfGuest = 0;
        static  Room [] rooms = new Room [numberOfRooms];
        

        public static Room CheckIn (Guest newguest)
        {

            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms [i] == null)
                {

                    rooms[i].SetGuest(newguest); 
                    numberOfGuest++;
                    return rooms[i];
                    
                }
                else
                {
                    Console.WriteLine("There is no free room available ");
                }
                
            }
            return null;
                        
        }

        public static void  CheckOut (Room newRoom)
        {
            newRoom.SetGuest(newRoom == null);
            numberOfGuest--;
        }

        public static bool isRoomFree (Room newRoom)
        {
            return true;
        }


    }
}
