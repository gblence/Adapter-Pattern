using System;

namespace TelepathyLabsBlenceTest.Models
{
	/// <summary>
	/// Calendar event name/title/subject
	/// </summary>
	public class CalendarEvent
	{
		public CalendarEvent()
		{
			
			Name = "Meeting";
		}
	
		public string Name { get;  set; }


		public DateTime Start { get;  set; }

	
		public DateTime End { get;  set; }

		public override string ToString() => "Event Name=" + Name + ", Start Date=" + $"{Start:ddd, MMM d, yyyy}" + " To " + ", End Date=" +
		                                     $"{End:ddd, MMM d, yyyy} ";
	}
}