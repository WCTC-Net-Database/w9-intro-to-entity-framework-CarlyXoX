﻿namespace W9_assignment_template.Services;

public class Menu
{
    private readonly GameEngine _gameEngine;

    public Menu(GameEngine gameEngine)
    {
        _gameEngine = gameEngine;
    }

    public void Show()
    {
        while (true)
        {
            Console.WriteLine("1. Display Rooms");
            Console.WriteLine("2. Add a Room");
            Console.WriteLine("3. Display Characters");
            Console.WriteLine("4. Add a Character");
            Console.WriteLine("5. Find a Character");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    _gameEngine.DisplayRooms();
                    break;
                case "2":
                    _gameEngine.AddRoom();
                    break;
                case "3":
                    _gameEngine.DisplayCharacters();
                    break;  
                case "4":
                    _gameEngine.AddCharacter();
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

}