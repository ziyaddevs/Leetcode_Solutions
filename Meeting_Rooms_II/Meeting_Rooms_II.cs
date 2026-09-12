public class Solution {
    public int MinMeetingRooms(int[][] intervals) {
        int n = intervals.Length;
        int[] startTimes = new int[n];
        int[] endTimes = new int[n];

        // 1. Separate start and end times
        for (int i = 0; i < n; i++) {
            startTimes[i] = intervals[i][0];
            endTimes[i] = intervals[i][1];
        }

        // 2. Sort both arrays
        Array.Sort(startTimes);
        Array.Sort(endTimes);

        // 3. Use two pointers to track rooms
        int rooms = 0;
        int endPointer = 0;

        for(int i = 0; i < n; i++)
        {
            // if the current meeting starts before the previous one ends, we need a new room
            if(startTimes[i] < endTimes[endPointer])
            {
                rooms++;
            }
            else
            {
                // otherwise, we can reuse a room and move the end pointer
                endPointer++;      
            }
        }
        return rooms;
    }

        



        
        
        // foreach(var interval in intervals)
        // {
        //     startTimes.Add(interval[0]);
        //     endTimes.Add(interval[1]);
        // }

        // for (int time = 0; time <= intervals.length; time++)
        // {
        //     if (startTime.Contains
        // }
}