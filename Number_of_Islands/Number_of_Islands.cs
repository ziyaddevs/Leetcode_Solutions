public class Solution {

    public void DFS(char[][] grid, int r, int c)
    {
        int rows = grid.Length;
        int cols = grid[0].Length;

        // 1. Base Case: Check bounds and if it's water (0)
        if (r < 0 || c < 0 || r >= rows || c >= cols || grid[r][c] == '0')
        {
            return;
        }

        // 2. Mark current node as visited by turnin it into '0' (sink it)
        grid[r][c] = '0';

        // 3. Recursively visit all 4 neigboring directions
        DFS(grid, r - 1, c); // Up
        DFS(grid, r + 1, c); // Down
        DFS(grid, r, c - 1); // Left
        DFS(grid, r, c + 1); // Right

    }

    public int NumIslands(char[][] grid) {
        if (grid == null || grid.Length == 0) return 0;

        int isLandCount = 0;
        int rows = grid.Length;
        int cols = grid[0].Length;

        // 1. Scan every cell in the grid using nested loops
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                // 2. if we find land '1', we found a new island!
                if(grid[r][c] == '1')
                {
                    isLandCount++;
                    DFS(grid, r, c);
                }
                
            }
        }
        return isLandCount;
    }
}