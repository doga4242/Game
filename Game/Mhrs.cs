using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Mhrs : IMhrs
    {
        

        public Mhrs(Player player)
        {
        }

    

        public bool Validate(Player player)
        {
            if (
                player.BirthDay == "03.07.2001" &&
                player.FirstName == "Doğa" && 
                player.LastName == "Öner" &&
                player.NationalatiyId == "12345"
                )
            {
                return true;
            }
            else
                return false;
        

        }
    
    
    
    }
}