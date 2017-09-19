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
