using System;


namespace R5T.F0059
{
	public class LoggingOperator : ILoggingOperator
	{
		#region Infrastructure

	    public static ILoggingOperator Instance { get; } = new LoggingOperator();

	    private LoggingOperator()
	    {
        }

	    #endregion
	}
}