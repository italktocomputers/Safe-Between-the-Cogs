using System.Collections;
using System.Collections.Generic;

public interface ILeaderboard {
    Dictionary<string, float> getLeaderboard(int level, int limit, int offset);
    bool saveToLeaderboard(int level, string user, float score);
}
