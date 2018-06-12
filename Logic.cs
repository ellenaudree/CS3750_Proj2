using System;

public class Conways_Game_Of_Life
{
	public Logic()
	{
		int row = 0; //Row of cells.
		int column = 0; //Columns of cells.
		int[][] newGeneration; //Array to loop through the table of cells.
		int numNeighbors = 0; // How many neighbors are surrounding each cell.

		// Checks if cell should be alive or dead.
		for (int row = 0; row < generation.length; row++)
		{
			for (int col = 0; col < generation[row].length; ++col)
			{
				//Over population and under population cells will die.
				if ((numNeighbors < 2)||(numNeighbors > 3))
				{
					newGeneration[row][column] = false; //There is no new generation of life created.
				}

				//No life is created or dies, stays the same.
				if (numNeighbors == 2)
				{
					newGeneration[row][column] = newGeneration[row][column]; //The game stays the same.
				}

				//Cells stay alive, or are created.
				if (numNeighbors == 3)
				{
					newGeneration[row][column] = true; // Create new cells.
				}
			}
		}
	}
}
