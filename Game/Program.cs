using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player1 = new Player()
            {
                FirstName = "Doğa",
                LastName = "Öner",
                NationalatiyId = "12345",
                BirthDay = "03.07.2001"
            };
            

            IMhrs mhrs = new Mhrs(player1);


            PlayerManager playerManager = new PlayerManager();

            if (mhrs.Validate(player1))
            {
                playerManager.Add(player1);
            }
            else
                Console.WriteLine("Player doesn't added to database because of values are false");

            Console.WriteLine("------------------------------------");

            IKampanya kampanya = new Kampanya();

            kampanya.AddKampanya(kampanya);

            Console.WriteLine("------------------------------------");

            kampanya.DeleteKampanya(kampanya);

            Console.WriteLine("------------------------------------");

            kampanya.UpdateNewKampanya(kampanya);

            
        }

        
    
    
    
    }
}
