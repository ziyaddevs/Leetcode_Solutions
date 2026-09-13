public class Solution {
    public int OrangesRotting(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length; // Fixed lowercase 'l' to uppercase 'L'
        
        // Fixed C# generic tuple syntax for the Queue
        Queue<(int, int)> queue = new Queue<(int, int)>();
        int freshCount = 0;
        
        // 1. SCAN FIRST: Populate the queue and count fresh oranges before the BFS starts
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (grid[r][c] == 2)
                {
                    queue.Enqueue((r, c)); // Found a starting rotten orange!
                }
                else if (grid[r][c] == 1)
                {
                    freshCount++; // Count the fresh targets
                }
            }
        }

        // Edge Case: If there are no fresh oranges to begin with, we need 0 minutes.
        if (freshCount == 0) return 0;

        int minutes = 0;
        int[] dr = {-1, 1, 0, 0};
        int[] dc = {0, 0, -1, 1};

        // 2. BFS LOOP: Process level by level
        while (queue.Count > 0)
        {
            int levelSize = queue.Count; // How many rotten oranges are spreading right now
            bool rottedThisMinute = false;

            // Process all oranges rotting at this exact minute
            for (int i = 0; i < levelSize; i++)
            {
                var (r, c) = queue.Dequeue();

                // Check all 4 directions for this orange
                for (int d = 0; d < 4; d++)
                {
                    int nr = r + dr[d];
                    int nc = c + dc[d];

                    // 1. Is the neighbor inside the grid?
                    // 2. Is the neighbor a fresh orange ('1')?
                    if (nr >= 0 && nc >= 0 && nr < rows && nc < cols && grid[nr][nc] == 1) {
                        grid[nr][nc] = 2; // Rot it!
                        freshCount--;     // One less fresh orange
                        queue.Enqueue((nr, nc)); // Add it to the queue for the next minute
                        rottedThisMinute = true;
                    }
                }
            }
            
            // If any oranges rotted during this wave, 1 minute has passed
            if (rottedThisMinute) {
                minutes++;
            }
        }
        
        // 3. FINAL RETURN: Only check this AFTER the entire BFS queue has emptied out
        return freshCount == 0 ? minutes : -1;
    }
}