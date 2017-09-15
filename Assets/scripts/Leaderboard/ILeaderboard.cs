using System.Collections;
using System.Collections.Generic;

public interface ILeaderboard {
    void init(int level);
    Dictionary<string, float> get();
    bool add(string user, float score);
    bool sync();
    bool flush();
}
