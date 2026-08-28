# LeetCode Solutions

A growing collection of LeetCode solutions written in C#. Each problem is kept in its own folder and includes a small `Main` method so it can be run locally with sample input.

## Problems

| Problem | Approach | Time | Space |
| --- | --- | ---: | ---: |
| [Contains Duplicate](Contains_Duplicate/Contains_Duplicate.cs) | Hash set lookup | O(n) | O(n) |
| [Two Sum](Two_Sum/Two_Sum.cs) | Pair search | O(n^2) | O(1) |
| [Missing Number](Missing_Number/Missing_Number.cs) | Hash set lookup | O(n) | O(n) |
| [Find All Numbers Disappeared in an Array](Find_All_Numbers_Dissapeared_In_An_Array/Find_All_Numbers_Dissapeared_In_An_Array.cs) | Hash set lookup | O(n) | O(n) |

## Running a solution

Install the [.NET SDK](https://dotnet.microsoft.com/download) and run a solution from its folder:

```bash
cd Missing_Number
dotnet run Missing_Number.cs
```

Replace the folder and filename with the problem you want to run. The sample output is printed by the file's `Main` method.

## Repository structure

```text
LeetCodeSolutions/
├── Contains_Duplicate/
├── Find_All_Numbers_Dissapeared_In_An_Array/
├── Missing_Number/
└── Two_Sum/
```

## Goals

- Practice common data structures and algorithm patterns.
- Track solutions as new problems are completed.
- Keep each solution easy to read, run, and review.
