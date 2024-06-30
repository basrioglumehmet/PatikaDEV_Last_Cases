using System;
using Voting_Application.Core.Entities;

namespace Voting_Application.Application.DTOs.Auth
{
    internal class AuthResponseDto
    {
        public string? Message { get; private set; }
        public bool Success { get; private set; }
        public User? User { get; private set; }
        public string? Error { get; private set; }

        private AuthResponseDto() { }

        public class Builder
        {
            private string? _message;
            private bool _success;
            private User? _user;
            private string? _error;

            public Builder WithMessage(string message)
            {
                _message = message;
                return this;
            }

            public Builder WithSuccess(bool success)
            {
                _success = success;
                return this;
            }

            public Builder WithUser(User user)
            {
                _user = user;
                return this;
            }

            public Builder WithError(string error)
            {
                _error = error;
                return this;
            }

            public AuthResponseDto Build()
            {
                return new AuthResponseDto
                {
                    Message = _message,
                    Success = _success,
                    User = _user,
                    Error = _error
                };
            }
        }
    }
}
