using Baseline.ImTools;
using ImTools;
using LamarCodeGeneration.Util;
using Microsoft.TeamFoundation.Work.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uno;

namespace CircleCross
{
    class Board_service
    {

        char[,] board = new char[3, 3];

          
        for (int i = 0; I< 3; I++)
        {
            for (int j = 0; j< 3; j++)
            
                board[i, j] = ' ';
        }
    
}


PrintBoard(Board);
    

    static void PrintBoard(char[,] board)
{
	Console.Clear();
	for (int i = 0; i < 3; i++)
	{
		Console.WriteLine(" {0} | {1} | {2} ", board[i, 0], board[i, 1], board[i, 2]);
		if (i < 2)
		{
			Console.WriteLine("---|---|---");
		}
	}
}

