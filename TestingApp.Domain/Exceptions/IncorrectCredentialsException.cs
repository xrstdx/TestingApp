namespace TestingApp.Domain.Exceptions;

public class IncorrectCredentialsException : Exception
{
    public IncorrectCredentialsException(string message = "Incorrect username or password") : base(message) { }
}

