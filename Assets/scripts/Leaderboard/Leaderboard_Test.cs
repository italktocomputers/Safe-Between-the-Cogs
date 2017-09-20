/*
 * Copyright (C) 2017 Andrew Schools
 * 
 * This program is free software: you can redistribute it and/or modify it under the terms 
 * of the GNU General Public License as published by the Free Software Foundation, either 
 * version 3 of the License, or (at your option) any later version.
 * This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; 
 * without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
 * See the GNU General Public License for more details.
 * You should have received a copy of the GNU General Public License along with this program. 
 * If not, see http://www.gnu.org/licenses/.
 * 
 */

using System.Collections;
using System.Collections.Generic;

public class Leaderboard_Test : ILeaderboard {
    private int level;

    public void init(int level) {
        this.level = level;
    }

	public List<KeyValuePair<string, float>> get() {
        List<KeyValuePair<string, float>> leaderboard = new List<KeyValuePair<string, float>>();

        if (level == 1) {
            leaderboard.Add(new KeyValuePair<string, float>("Apple Computers", 300.80f));
            leaderboard.Add(new KeyValuePair<string, float>("Google", 301.09f));
            leaderboard.Add(new KeyValuePair<string, float>("Sun Microsystems", 303.41f));
            leaderboard.Add(new KeyValuePair<string, float>("Oracle", 307.09f));
            leaderboard.Add(new KeyValuePair<string, float>("Micro$oft", 307.57f));
            leaderboard.Add(new KeyValuePair<string, float>("Red Hat", 307.81f));
            leaderboard.Add(new KeyValuePair<string, float>("Hewlett-Packard", 308.06f));
            leaderboard.Add(new KeyValuePair<string, float>("IBM", 308.98f));
            leaderboard.Add(new KeyValuePair<string, float>("Intel", 309.03f));
            leaderboard.Add(new KeyValuePair<string, float>("Lenovo", 309.79f));
            leaderboard.Add(new KeyValuePair<string, float>("Dell", 310.09f));
            leaderboard.Add(new KeyValuePair<string, float>("Compaq", 310.88f));
            leaderboard.Add(new KeyValuePair<string, float>("Cisco Systems", 311.04f));
            leaderboard.Add(new KeyValuePair<string, float>("Amazon", 315.98f));
        }
        else {
            leaderboard.Add(new KeyValuePair<string, float>("Bill Gates", 301.09f));
            leaderboard.Add(new KeyValuePair<string, float>("Steve Jobs", 303.41f));
            leaderboard.Add(new KeyValuePair<string, float>("Denise Ritchie", 307.09f));
            leaderboard.Add(new KeyValuePair<string, float>("Ken Thompson", 307.57f));
            leaderboard.Add(new KeyValuePair<string, float>("Brian Kernighan", 307.81f));
            leaderboard.Add(new KeyValuePair<string, float>("Linus Torvalds", 308.06f));
            leaderboard.Add(new KeyValuePair<string, float>("Rob Pike", 308.98f));
            leaderboard.Add(new KeyValuePair<string, float>("Richard Stallman", 309.03f));
            leaderboard.Add(new KeyValuePair<string, float>("Guido van Rossum", 309.79f));
            leaderboard.Add(new KeyValuePair<string, float>("Bjarne Stroustrup", 310.09f));
            leaderboard.Add(new KeyValuePair<string, float>("Paul Allen", 310.09f));
            leaderboard.Add(new KeyValuePair<string, float>("Jeff Bezos", 310.88f));
            leaderboard.Add(new KeyValuePair<string, float>("Steve Wozniak", 311.04f));
            leaderboard.Add(new KeyValuePair<string, float>("Tim Cook", 315.98f));
            leaderboard.Add(new KeyValuePair<string, float>("Elon Musk", 317.22f));
            leaderboard.Add(new KeyValuePair<string, float>("Larry Page", 317.62f));
            leaderboard.Add(new KeyValuePair<string, float>("Mark Zuckerberg", 321.09f));
            leaderboard.Add(new KeyValuePair<string, float>("Eric Schmidt", 321.84f));
        }

        return leaderboard;
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
