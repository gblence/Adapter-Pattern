using System.Collections.Generic;

namespace TelepathyLabsBlenceTest.Models
{
	/// <summary>
	/// Calendar Object.
	/// </summary>
	public class Calendar
	{
		public Calendar()
		{
			Events = new List<CalendarEvent>();
		}
		/// <summary>
		/// Platform ID
		/// </summary>
		public int PlatformId { get;  set; }
		/// <summary>
		/// Display name
		/// </summary>
		public string Name { get; set; }

		public string UserName { get; set; }

		public List<CalendarEvent> Events { get;  set;}

	}
}
