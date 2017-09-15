using System.Collections;
using System.Collections.Generic;

public class Leaderboard_Test : ILeaderboard {
    private int level;

    public void init(int level) {

    }

	public Dictionary<string, float> get() {
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
            results["Paul Allen"] = 310.09f;
            results["Jeff Bezos"] = 310.88f;
            results["Steve Wozniak"] = 311.04f;
            results["Tim Cook"] = 315.98f;
            results["Elon Musk"] = 317.22f;
            results["Larry Page"] = 317.62f;
            results["Mark Zuckerberg"] = 321.09f;
            results["Eric Schmidt"] = 321.84f;


        }

        return results;
    }

    public bool sync() {
        return true;
    }
    
    public bool add(string user, float score) {
        return true;
    }

    public bool flush() {
        return true;
    }
}
