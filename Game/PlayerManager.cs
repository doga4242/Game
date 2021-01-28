using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class PlayerManager : IPlayerManager
    {

        


        public void Add(Player player)
        {
            Console.WriteLine("Player name added : "+player.FirstName);
            Console.WriteLine("PLayer last name added: "+player.LastName);
            Console.WriteLine("Player NationalId added: "+player.NationalatiyId);
            Console.WriteLine("Player birthday added: "+player.BirthDay);
        }


        public void Delete(Player player)
        {
            Console.WriteLine("Player deleted from database ");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Player updated! ");
        }
        
    }
}
