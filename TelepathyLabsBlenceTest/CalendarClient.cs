using System;
using TelepathyLabsBlenceTest.Exceptions;
using TelepathyLabsBlenceTest.Interfaces;
using TelepathyLabsBlenceTest.Models;

namespace TelepathyLabsBlenceTest
{
	/// <summary>
	/// Calendar Service class
	/// </summary>
	public class CalendarClient
	{
		readonly IPlatformCalendar _calendar;

		public CalendarClient(IPlatformCalendar calendar)
		{
			_calendar = calendar;
		}

		public async void WriteEvents()
		{
			Calendar calendar = null;

			try
			{
				_calendar.AuthenticateUser();
				 calendar = await _calendar.GetCalendar();
			}
			catch
				(PlatformException ex)
			{
				//Log
			}
			catch (Exception ex)
			{
				//Log
			}
			Console.Write("Hello {0}, for your calendar {1} you have {2} events.", calendar.UserName,
				calendar.Name, calendar.Events.Count);
			Console.WriteLine();

			foreach (var e in calendar.Events)
			{
				Console.Write(e.ToString());
				Console.WriteLine();
			}


			Console.WriteLine();
		}
	}
}