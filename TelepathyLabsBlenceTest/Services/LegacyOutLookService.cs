

using System.Threading.Tasks;
using TelepathyLabsBlenceTest.Common;
using TelepathyLabsBlenceTest.Models;

namespace TelepathyLabsBlenceTest.Services
{
	////adaptee
	public class LegacyOutlookService
	{
		public async Task<Calendar> GetCalendar() => await Task.FromResult(new Calendar
		{
			Events = DateGeneratorExtension.GetRandomDays(1),
			Name = "Outlook",
			UserName = "Bobby"
		});
	}
}
