using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voting_Application.Application.DTOs.Auth;
using Voting_Application.Core.Entities;
using Voting_Application.Core.Providers;
using Voting_Application.Core.Providers.Impl;

namespace Voting_Application.Application.Services.Impl
{
    internal class AuthService : IAuthService
    {
        private UserService? _userService;
        public AuthService(UserService userService)
        {
            _userService = userService;
        }

        public AuthResponseDto signIn(User user)
        {
            if (_userService.CheckUserExists(user))
            {
                SessionProvider.CurrentUser = user;
                return new AuthResponseDto.Builder()
                    .WithUser(SessionProvider.CurrentUser)
                    .WithSuccess(true)
                    .WithMessage("Başarıyla Giriş Yapıldı")
                    .Build();
            }
            return new AuthResponseDto.Builder().WithSuccess(false).WithError("Kullanıcı Kayıtlı Değil. Kayıt Olmak için 0 basın").Build();
        }

        public AuthResponseDto signOut()
        {
            SessionProvider.CurrentUser = null;
            return new AuthResponseDto.Builder()
               .WithSuccess(true)
               .WithMessage("Başarıyla Çıkış Yapıldı")
               .Build();
        }

        public AuthResponseDto signUp(User user)
        {
            if (!_userService.CheckUserExists(user))
            {
                SessionProvider.CurrentUser = user;
                return new AuthResponseDto.Builder()
                    .WithUser(SessionProvider.CurrentUser)
                    .WithSuccess(true)
                    .WithMessage("Başarıyla kayıt olundu ve giriş yapıldı")
                    .Build();
            }
            return new AuthResponseDto.Builder().WithSuccess(false).Build();
        }

        public void StartAuthenticationProccesses()
        {
            string email = "";
            string password = "";

            var user = new User();
            while (true)
            {
                Console.Write("Eposta:");
                email = Console.ReadLine();
                Console.Write("\nŞifre:");
                password = Console.ReadLine();

                user.Email = email;
                user.Password = password;
                var response = signIn(user);
                Console.WriteLine(" ");
                if (!response.Success)
                {
                    Console.WriteLine(response.Error);
                }
                break;
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.KeyChar == '0')
            {
                var response = signUp(user);
                Console.WriteLine(" ");
                if (!response.Success)
                {
                    Console.WriteLine(response.Error);
                }
                else
                {
                    Console.WriteLine(response.Message);
                }
            }
        }
    }
}
