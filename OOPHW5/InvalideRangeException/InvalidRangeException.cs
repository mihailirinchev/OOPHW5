using System;
using System.Linq;
using System.Runtime.Serialization;

namespace InvalidRangeException
{
	internal class InvalidRangeException<T> : Exception
	{
		private const string DefaultErrorMessageFormat = "The value does not fall within the expected range: [{0}...{1}]";

		public T Start { get; private set; }

		public T End { get; private set; }

		public InvalidRangeException(T start, T end) : this(start, end, string.Format(DefaultErrorMessageFormat, start, end))
		{
		}

		public InvalidRangeException(T start, T end, string message) : this(start, end, message, null)
		{
		}

		public InvalidRangeException(T start, T end, string message, Exception innerException) : base(message, innerException)
		{
			this.Start = start;
			this.End = end;
		}

		public InvalidRangeException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}