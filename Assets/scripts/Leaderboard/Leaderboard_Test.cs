using System.Collections;
using System.Collections.Generic;

public class Leaderboard_Test : ILeaderboard {
	public Dictionary<string, float> getLeaderboard(int level, int limit, int offset) {
        Dictionary<string, float> results = new Dictionary<string, float>();

        results["User 0"] = 300.80f;
        results["User 1"] = 301.09f;
        results["User 2"] = 303.41f;
        results["User 3"] = 307.09f;
        results["User 4"] = 307.57f;
        results["User 5"] = 307.81f;
        results["User 6"] = 308.06f;
        results["User 7"] = 308.98f;
        results["User 8"] = 309.03f;
        results["User 9"] = 309.79f;

        return results;
    }
    
    public bool saveToLeaderboard(int level, string user, float score) {
        return true;
    }
}
