using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class Kampanya : IKampanya
    {
        public Kampanya()
        {
        }

      

        public void AddKampanya(IKampanya kampanya)
        {
            Console.WriteLine("New kampanya is shown on player screen!");
        }

        public void DeleteKampanya(IKampanya kampanya)
        {
            Console.WriteLine("Kampanya deleted from player screen!");
        }

        public void UpdateNewKampanya(IKampanya kampanya)
        {
            Console.WriteLine("New kampanya updated on player screen!");
        }
    }
}
