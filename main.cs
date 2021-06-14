using System;

class MainClass {
public static void Main (string[] args) {
		WelcomeMessage();


  	Console.ReadLine();
	}
	private static void WelcomeMessage()
	{
		Console.WriteLine("--- Welcome to BattleShip ---");
		Console.WriteLine("Created by: Jeff Eckman");
		Console.WriteLine();
	}

	private static PlayerInfoModel CreatePlayer()
	{
		PlayerInfoModel output = new PlayerInfoModel();

		// Ask the user for their name
		output.UsersName = AskForUsersName();

		// Load up the shot grid
		InitializeGrid(output);

		// Ask the user for their 5 ship placements

		// Clear

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
			

		} while (model.ShipLocations.Count < 5);
	}
}

