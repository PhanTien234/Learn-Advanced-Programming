using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Constants
    {
        public const string InvalidArtistName = "Artist name should be between {0} and {1} symbol!";
        public const string InvalidSongLength = "Invalid song length!";
        public const string InvalidSongRange = "Song minutes should be between {0} and {1}";
        public const string InvalidSongSymbol = "Song name should be between {0} and {1} symbols.";
        public const string InvalidSongSeconds = "Song seconds should be between {0} and {1}";



        public class InvalidSongException : Exception
        {
            private string exceptionMessage = "Invalid Song";
            
            public virtual string ExceptionMessage
            {
                set => this.exceptionMessage = value;
            }
            public override string Message => exceptionMessage;

        }
        
        public class InvalidArtistNameException : InvalidSongException
        {
            private const int MinNameLength = 3;
            private const int MaxNameLength = 30;

            public override string Message => string.Format(Constants.InvalidArtistName, MinNameLength, MaxNameLength);
        }
        public class InvalidSongLengthException : InvalidSongException
        {
            public override string Message => Constants.InvalidSongLength;
        }

        public class InvalidSongMinutesException : InvalidSongLengthException
        {
            private const int MinMinutesValue = 0;
            private const int MaxMinutesValue = 14;
            public override string Message => string.Format(Constants.InvalidSongRange, MinMinutesValue, MaxMinutesValue);
        }

        public class InvalidSongNameException : InvalidSongException
        {
            private const int MinNameLength = 3;
            private const int MaxNameLength = 30;

            public override string Message => string.Format(Constants.InvalidSongSymbol, MinNameLength, MaxNameLength);
        }

        public class InvalidSongSecondsException : InvalidSongLengthException
        {
            private const int MinSecondsValue = 0;
            private const int MaxSecondsValue = 59;

            public override string Message => string.Format(Constants.InvalidSongSeconds, MinSecondsValue, MaxSecondsValue);

        }
    }
}
