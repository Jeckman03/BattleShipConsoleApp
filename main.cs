using System;

class MainClass {
public static void Main (string[] args) {
		WelcomeMessage();

		PlayerInfoModel player1 = CreatePlayer("Player 1");
		PlayerInfoModel player2 = CreatePlayer("Player 2");


  	Console.ReadLine();
	}
	private static void WelcomeMessage()
	{
		Console.WriteLine("--- Welcome to BattleShip ---");
		Console.WriteLine("Created by: Jeff Eckman");
		Console.WriteLine();
	}

	private static PlayerInfoModel CreatePlayer(string playerTitle)
	{
		PlayerInfoModel output = new PlayerInfoModel();

		Console.WriteLine($"Player information for { playerTitle }");

		// Ask the user for their name
		output.UsersName = AskForUsersName();

		// Load up the shot grid
		GameLogic.InitializeGrid(output);

		// Ask the user for their 5 ship placements
		PlaceShips(output);

		// Clear
		Console.Clear();

		return output;
	}

	private static string AskForUsersName()
	{
		Console.Write("What is yout name: ");
		string output = Console.ReadLine();

		return output;
	}

	private static void PlaceShips(PlayerInfoModel model)
	{
		do
		{
			Console.Write($"Where do you want to place your ship number { model.ShipLocations.Count + 1 }: ");
			string location = Console.ReadLine();

			bool isVaildLocation = GameLogic.PlaceShip(model, location);

			if (isVaildLocation == false)
			{
				Console.WriteLine("That was not a valid location. Please try again.");
			}

		} while (model.ShipLocations.Count < 5);
	}
}

