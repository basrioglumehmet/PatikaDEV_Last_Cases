using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Voting_Application.Core.Entities;

namespace Voting_Application.Core.Providers.Impl
{
    internal class SessionProvider : ISessionProvider
    {
        public static User? CurrentUser
        {
            get; set;
        }
    }
}
