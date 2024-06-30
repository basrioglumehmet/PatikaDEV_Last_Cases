using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voting_Application.Application.DTOs.Auth;
using Voting_Application.Core.Entities;

namespace Voting_Application.Application.Services
{
    internal interface IAuthService
    {
        public AuthResponseDto signIn(User user);
        public AuthResponseDto signUp(User user);
        public AuthResponseDto signOut();
        public void StartAuthenticationProccesses();
    }
}
