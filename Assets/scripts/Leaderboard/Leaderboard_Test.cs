using System.Collections;
using System.Collections.Generic;

public class Leaderboard_Test : ILeaderboard {
	public Dictionary<string, float> getLeaderboard(int level, int limit, int offset) {
        Dictionary<string, float> results = new Dictionary<string, float>();

        if (level == 1) {
            results["Apple Computers"] = 300.80f;
            results["Google"] = 301.09f;
            results["Sun Microsystems"] = 303.41f;
            results["Oracle"] = 307.09f;
            results["Micro$oft"] = 307.57f;
            results["Red Hat"] = 307.81f;
            results["Hewlett-Packard"] = 308.06f;
            results["IBM"] = 308.98f;
            results["Intel"] = 309.03f;
            results["Lenovo"] = 309.79f;
            results["Dell"] = 310.09f;
            results["Compaq"] = 310.88f;
            results["Cisco Systems"] = 311.04f;
            results["Amazon"] = 315.98f;
        }
        else {
            results["Bill Gates"] = 301.09f;
            results["Steve Jobs"] = 303.41f;
            results["Denise Ritchie"] = 307.09f;
            results["Ken Thompson"] = 307.57f;
            results["Brian Kernighan"] = 307.81f;
            results["Linus Torvalds"] = 308.06f;
            results["Rob Pike"] = 308.98f;
            results["Richard Stallman"] = 309.03f;
            results["Guido van Rossum"] = 309.79f;
            results["Bjarne Stroustrup"] = 310.09f;
        }

        return results;
    }
    
    public bool saveToLeaderboard(int level, string user, float score) {
        return true;
    }
}
