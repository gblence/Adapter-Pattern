using System;

namespace TelepathyLabsBlenceTest.Exceptions
{
	/// <summary>
	/// Class representing an platform exception
	/// </summary>
	public class PlatformException : Exception
	{

		/// <summary>
		/// Wraps platform error
		/// </summary>
		/// <param name="errorMsg">Error message.</param>
		/// <param name="innerException">Platform error.</param>
		public PlatformException(string errorMsg, Exception innerException) : base(errorMsg, innerException)
		{
	
		}



	}


}
