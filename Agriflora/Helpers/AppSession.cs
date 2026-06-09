using Agriflora.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agriflora.Helpers
{
    public static class AppSession
    {
        public static Pengguna CurrentUser { get; private set; }

        public static bool IsAuthenticated => CurrentUser != null;

        public static void SetUser(Pengguna user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
