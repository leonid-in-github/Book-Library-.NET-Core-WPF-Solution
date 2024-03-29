﻿using BookLibrary.UI.HelperClasses;

namespace BookLibrary.UI
{
    public class AppUser
    {
        private AppUser() { }

        private AppUser(string login, string password, int accountId)
        {
            Login = login;
            Password = password;
            AccountId = accountId;
        }

        private static AppUser _instance;

        public static AppUser GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AppUser();
            }
            return _instance;
        }

        public static void SetInstance(string login, string password, int accountId)
        {
            SetLastSessionUser(login, password, accountId);
            _instance = new AppUser(login, password, accountId);
            return;
        }

        private static void SetLastSessionUser(string login, string password, int accountId)
        {
            LastSession.Login = login;
            LastSession.Password = password;
            LastSession.AccountId = accountId;
        }

        public string Login { get; }

        public string Password { get; }

        public int AccountId { get; }
    }
}
