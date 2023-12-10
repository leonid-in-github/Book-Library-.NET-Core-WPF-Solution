﻿using System;

namespace BookLibrary.Storage.Exceptions
{
    [Serializable]
    public class SessionExpirationConflictException : Exception
    {
        public SessionExpirationConflictException() : base(massege)
        {

        }

        private const string massege = "Application and DB session expiration time conflict.";
    }
}