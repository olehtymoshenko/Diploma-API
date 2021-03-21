﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Infrastructure.Exceptions
{
    public class ErrorMessages
    {
        public const string InvalidCredentials = "Invalid credintials";

        public const string RefreshTokensNotExists = "Refresh tokens for the provided credentials don't exist";

        public const string EmailAlreadyExistsInDB = "Email is already registred";

        public const string UserWithProvidedEmailDoesntExists = "User with provided email doesn't exists in the DB";

        public const string InvalidAccessToken = "Invalid access token";

        public const string InvalidRefreshToken = "Invalid refresh token";
    }
}
