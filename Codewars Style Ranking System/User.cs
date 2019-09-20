using System;
using System.Collections.Generic;
using System.Linq;

public class User
{
    private static List<int> ranks = new List<int>{ -8, -7, -6, -5, -4, -3, -2, -1, 1, 2, 3, 4, 5, 6, 7, 8 };

    public int rank { get; private set; } = -8;

    public int progress { get; private set; } = 0;

    public User()
    { }

    public void incProgress(int activityRank)
    {
        ThrowOnInvalidRank(activityRank);
        
        var rankDifference = CalcRankDifference(activityRank, this.rank);
        this.progress += CalcProgressFrom(rankDifference);
        this.rank = CalcNewRank(this.rank, this.progress);
        this.progress = BoundProgress(this.rank, this.progress);
    }

    private static void ThrowOnInvalidRank(int rank)
    {
        if (!ranks.Contains(rank))
        {
            throw new ArgumentException();
        }
    }

    private static int CalcRankDifference(int activityRank, int rank)
    {
        var rankIndex = ranks.IndexOf(rank);
        var activityRankIndex = ranks.IndexOf(activityRank);
        return activityRankIndex - rankIndex;
    }

    private static int CalcProgressFrom(int rankDifference)
    {
        int result;
        if (rankDifference == 0)
        {
            result = 3;
        }
        else if (rankDifference == -1)
        {
            result = 1;
        }
        else if (rankDifference > 0)
        {
            result = 10 * rankDifference * rankDifference;
        }
        else
        {
            result = 0;
        }
        return result;
    }

    private static int CalcNewRank(int currentRank, int progress)
    {
        var rankIndex = ranks.IndexOf(currentRank);
        var levelUps = progress / 100;
        rankIndex += levelUps;
        if (rankIndex > ranks.Count)
        {
            rankIndex = ranks.Count;
        }
        return ranks[rankIndex];
    }
    
    private static int BoundProgress(int rank, int progress)
    {
        progress %= 100;
        if (rank == 8)
        {
          progress = 0;
        }
        return progress;
    }
}