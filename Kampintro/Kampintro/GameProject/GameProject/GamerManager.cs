using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    // Micro Service
    class GamerManager : IGamerService
    {
        IUserValidationService userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (this.userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız, Mernis geçersiz");
            }            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silme başarılı");
        }

        public void Update(Gamer gamer)
        {
            if (this.userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt güncelleme başarılı");
            }
            else
            {
                Console.WriteLine("Kayıt güncellemebaşarısız, Mernis geçersiz");
            }            
        }
    }
}
