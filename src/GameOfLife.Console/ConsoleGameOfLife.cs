﻿using GameOfLife.Core;

namespace GameOfLife.Console;

public static class ConsoleGameOfLife
{
  public static async Task RunAsync(int cols, int rows, TimeSpan delayPerCycle)
  {
    var game = new Game(CellGenerator.RandomCells(cols, rows));
    var display = new ConsoleDisplay(game);

    var loop = new GameLoop(game, display);

    await loop.Run(delayPerCycle);

    System.Console.WriteLine("Game over.");
  }
}
