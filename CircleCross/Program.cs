using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using CircleCross.App.Abstract;
using CircleCross.App.Concrete;
using CircleCross.App.Managers;
using CircleCross.Domain.Entity;

namespace CircleCross
{
	public class Program
	{
		//Stała
		public const string FILE_NAME = @"C:\CircleCrossFiles\ImportFile.xlsx";
		static void Main(string[] args)
		{
			

			MenuActionService actionService = new MenuActionService();
			ItemService itemService = new ItemService();
			ItemManager itemManger = new ItemManager(actionService, itemService);

			Console.WriteLine("Welcome to warehouse app!");
			while (true)
			{
				Console.WriteLine("Please let me know what you want to do:");
				var mainMenu = actionService.GetMenuActionsByMenuName("Main");
				for (int i = 0; i < mainMenu.Count; i++)
				{
					Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
				}

				var operation = Console.ReadKey();

				switch (operation.KeyChar)
				{
					case '1':
						var newId = itemManger.AddNewItem();
						break;
					
						
					default:
						Console.WriteLine("Action you entered does not exist");
						break;
				}


			}
		}
		

	
	}
}
