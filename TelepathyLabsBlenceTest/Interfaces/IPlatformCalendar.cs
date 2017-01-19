using System.Threading.Tasks;
using TelepathyLabsBlenceTest.Models;

namespace TelepathyLabsBlenceTest.Interfaces
{
	/// <summary>
	/// The system calendar that governs the evaluation rules.
	/// </summary>
	public interface IPlatformCalendar
	{
		/// <summary>
		/// Gets a list of periods collected so far during
		/// the evaluation process.
		/// </summary>
		//Calendar Instance { get; }

		/// <summary>
		/// Returns all calendar events
		/// </summary>
		/// <exception cref="PlatformException">Platform error.</exception>
		 Task<Calendar> GetCalendar();

	

		/// <summary>
		/// Authenticat User
		/// </summary>
		bool AuthenticateUser();

	}
}