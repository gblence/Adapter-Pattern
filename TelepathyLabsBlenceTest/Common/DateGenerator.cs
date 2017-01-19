using System;
using System.Collections.Generic;
using TelepathyLabsBlenceTest.Models;

namespace TelepathyLabsBlenceTest.Common
{
	public static class DateGeneratorExtension
	{
		public static List<CalendarEvent> GetRandomDays(int nDays)
		{
			var range = new List<CalendarEvent>(nDays);
			for (int i = 0; i <= nDays; i++)
			{
				var date = RandomDayFunc();		
				range.Add(new CalendarEvent() {Start = date, End = date});
			}
			return range;

		}

		static DateTime RandomDayFunc()
		{
		
				DateTime start = new DateTime(1995, 1, 1);
				Random gen = new Random();
				int range = (DateTime.Today - start).Days;
				return  start.AddDays(gen.Next(range));		
		
		}
		

	}
}
