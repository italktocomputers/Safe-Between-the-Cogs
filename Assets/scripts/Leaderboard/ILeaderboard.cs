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

public interface ILeaderboard {
    // Do whatever is required before fetching/saving to/from leaderboard.
    void init(int level);

    // Must return an already sorted list of 24 items.
    List<KeyValuePair<string, float>> get();

    // Determine if there is room for this new score, and if so, at what position.
    bool add(string user, float score);

    // From memory to storage
    bool sync();

    // Clear all stats from memory and storage
    bool flush();
}
