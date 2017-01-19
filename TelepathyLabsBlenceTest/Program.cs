using System;
using TelepathyLabsBlenceTest.Interfaces;
using TelepathyLabsBlenceTest.Services;

namespace TelepathyLabsBlenceTest
{
	class Program
	{
		static void Main(string[] args)
		{
			IPlatformCalendar platformF = new FacebookCalendarService();
			IPlatformCalendar platformA = new AppleCalendarService();
			IPlatformCalendar platformO = new LegacyOutlookAdapter(new LegacyOutlookService());
			IPlatformCalendar platformG = new GoogleCalendarAdapter(new GoogleLibaryWrapper());


			CalendarClient client = new CalendarClient(platformF);
			client.WriteEvents();
			Console.ReadKey();
			client = new CalendarClient(platformA);
			client.WriteEvents();
			Console.ReadKey();
			client = new CalendarClient(platformO);
			client.WriteEvents();
			Console.ReadKey();
			client = new CalendarClient(platformG);
			client.WriteEvents();
			Console.ReadKey();
		}
	}
}
