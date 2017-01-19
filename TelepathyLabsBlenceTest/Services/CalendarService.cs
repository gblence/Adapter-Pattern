using System.Threading.Tasks;
using TelepathyLabsBlenceTest.Common;
using TelepathyLabsBlenceTest.Interfaces;
using Calendar = TelepathyLabsBlenceTest.Models.Calendar;

namespace TelepathyLabsBlenceTest.Services
{
	/// <summary>
	///Apple's Calender
	/// </summary>
	public class AppleCalendarService : BaseService, IPlatformCalendar
	{

		public async Task<Calendar> GetCalendar() => await Task.FromResult(new Calendar
		{
			Events = DateGeneratorExtension.GetRandomDays(5),
			Name = "Apple",
			UserName = "Stephen"
		});

		////Other Code
	}


	public class FacebookCalendarService : BaseService, IPlatformCalendar
	{

		public async Task<Calendar> GetCalendar() => await Task.FromResult(new Calendar
		{
			Events = DateGeneratorExtension.GetRandomDays(2),
			Name = "FaceBook",
			UserName = "Stephen"
		});

		////Other Code
	}

	//Adapter - class that implements the IPlatformCalendar interface in terms of the Adeptee
	public class LegacyOutlookAdapter : BaseService, IPlatformCalendar
	{
		public LegacyOutlookAdapter(LegacyOutlookService instance)
		{
			_outLookInstance = instance;
		}

		readonly LegacyOutlookService _outLookInstance;

		public async Task<Calendar> GetCalendar() => await _outLookInstance.GetCalendar();


	}
	//Adapter implements the IPlatformCalendar interface and translates Authentication and Event request to GoogleLibaryWrapper adaptee method.
	public class GoogleCalendarAdapter : BaseService, IPlatformCalendar
	{

		GoogleLibaryWrapper _googleLibary;
		public GoogleCalendarAdapter(GoogleLibaryWrapper instance)
		{
			_googleLibary = instance;
		}

		
		public override bool AuthenticateUser()
		{
			
			//	_googleLibary.Authenticate

			return true;
		}

		public async Task<Calendar> GetCalendar() => await Task.FromResult(new Calendar
		{
			//Call in to Google and map events to our model.
			//Events googleEvents = _googleLibary.GetGoogleEvents();
			Events = DateGeneratorExtension.GetRandomDays(1),
			Name = "Google",
			UserName = "Stephen"
		});

		////Other Code
	}

}



