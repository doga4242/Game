using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    interface IPlayerManager
    {
      

        void Add(Player player);

        void Delete(Player player);

        void Update(Player player);

    }
}
