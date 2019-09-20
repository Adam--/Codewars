using System;

public class TicTacToe
{
  private enum Result
  {
    NotFinished = -1,
    Tie = 0,
    XWins = 1,
    YWins = 2,
  }

  public int IsSolved(int[,] board)
  {
    var boardNotFinished = false;

    for (int i = 0; i < 3; i++)
    {
      var rcResult = EvaluateColumnsAndRows(i);

      if (rcResult == Result.XWins || rcResult == Result.YWins)
      {
        // Short circuit for a win, no need to continue evaluating
        // since we assume the board is valid
        return (int)rcResult;
      }

      boardNotFinished |= rcResult == Result.NotFinished;
    }

    var diagResult = EvaluateDiag();
    if (diagResult == Result.XWins || diagResult == Result.YWins)
    {
      // Short circuit for a win, no need to continue evaluating
      // since we assume the board is valid
      return (int)diagResult;
    }

    boardNotFinished |= diagResult == Result.NotFinished;
    
    return boardNotFinished ? (int)Result.NotFinished : (int)Result.Tie;

    Result EvaluateColumnsAndRows(int i)
    {
      if (board[0, i] == 1 && board[1, i] == 1 && board[2, i] == 1 ||
          board[i, 0] == 1 && board[i, 1] == 1 && board[i, 2] == 1)
      {
        return Result.XWins;
      }

      if (board[0, i] == 2 && board[1, i] == 2 && board[2, i] == 2 ||
          board[i, 0] == 2 && board[i, 1] == 2 && board[i, 2] == 2)
      {
        return Result.YWins;
      }

      if (board[0, i] == 0 || board[1, i] == 0 || board[2, i] == 0 ||
          board[i, 0] == 0 || board[i, 1] == 0 || board[i, 2] == 0)
      {
        return Result.NotFinished;
      }

      return Result.Tie;
    }

    Result EvaluateDiag()
    {
      if (board[0, 2] == 1 && board[1, 1] == 1 && board[2, 0] == 1 ||
          board[0, 0] == 1 && board[1, 1] == 1 && board[2, 2] == 1)
      {
        return Result.XWins;
      }

      if (board[0, 2] == 2 && board[1, 1] == 2 && board[2, 0] == 2 ||
          board[0, 0] == 2 && board[1, 1] == 2 && board[2, 2] == 2)
      {
        return Result.YWins;
      }

      if (board[0, 2] == 0 || board[1, 1] == 0 || board[2, 0] == 0 ||
          board[0, 0] == 0 || board[1, 1] == 0 || board[2, 2] == 0)
      {
        return Result.NotFinished;
      }

      return Result.Tie;
    }
  }
}