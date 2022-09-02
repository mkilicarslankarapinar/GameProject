using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //MicroService
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Signed Up");
            }
            else
            {
                Console.WriteLine("Validation is not succeed. Saving is not completed.");
            }
            Console.WriteLine("Data Added");
        }

        internal void Add(Game game)
        {
            Console.WriteLine("Data Added");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Data Deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Data Updated");
        }
    }
}
