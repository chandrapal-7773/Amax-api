namespace Amax.InsurancePro.Domain.Common;

using System.Globalization;

// custom exception class for throwing application specific exceptions (e.g. for validation) 
// that can be caught and handled within the application
public class AppException : Exception
{
    public AppException() : base() { }

    public AppException(string message) : base(message) { }
    public AppException(string message, bool isDBLog) : base(message) { _isDBLog = isDBLog; }

    public AppException(string message, params object[] args)
        : base(String.Format(CultureInfo.CurrentCulture, message, args))
    {
    }
    public AppException(string message, bool isDBLog, params object[] args)
        : base(String.Format(CultureInfo.CurrentCulture, message, args))
    {
        _isDBLog = isDBLog;
    }

    private bool _isDBLog = true;
    public bool IsDBLog { get { return _isDBLog; } }
}