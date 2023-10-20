//Card
	
// class Card
// 	{
// 		private CardStatus status;
// 	}
// 	public enum CardStatus
// 	{
// 		OnDeck,
// 		OnPlayer,
// 		Removed
// 	}
// 	public enum GameStatus
// 	{
// 		Win,
// 		Lose,
// 		Draw
// 	}
	public enum DaysOfWeek
	{
		Monday,
		Tuesday,
		Wednesday,
		Thursday,
		Friday,
		Saturday,
		Sunday
	}
class Program
{
	static void Main()
	{
		if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
		{
			Console.WriteLine("Today is Sunday.");
		}
		else
		{
			Console.WriteLine("Today is not Sunday.");
			Console.WriteLine($"Today is {DateTime.Now.DayOfWeek}.");
			Console.WriteLine($"Today is the {(int)DayOfWeek.Tuesday}nd day of the week.");
		}
		// Use the enum in a foreach loop
		foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
		{
			Console.WriteLine(day);
		}
	}
}