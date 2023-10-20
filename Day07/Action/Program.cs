//Action
class Program
{
	static void Main()
	{
		CardCreator cre = new CardCreator("Misi");
		UI u = new UI();
		Database db = new Database();
		cre.onCardUpdate += u.Notification;
		cre.onCardUpdate -= db.AddCardToDb;
		cre.Update();
	}
	class CardCreator
	{
		public List<Card> cards;
		public Action<Card> onCardUpdate;
		public void CreateCard(int id, string description)
		{
			Card card = new Card() { id = id, description = description };
			cards.Add(card);
			Update(card);
		}
		public void Update(Card card)
		{
			onCardUpdate?.Invoke(card);
		}
	}
	class Card
	{
		public int id;
		public string description;
	}
	class UI
	{
		public void Notification(Card data)
		{
			Console.WriteLine($"Update UI location {data.id} , {data.description}");
		}
	}
	class Database
	{
		public void AddCardToDb(Card data)
		{
			Console.WriteLine($"Update Database {data.id} , {data.description}");
		}
	}
}
