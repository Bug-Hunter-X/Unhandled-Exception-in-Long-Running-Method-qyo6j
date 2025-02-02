# Unhandled Exception in Long-Running C# Method

This example demonstrates a common issue: an unhandled exception in a long-running method.  The `MyMethod` function simulates some work, but throws an exception when `i` reaches 5. Because there's no `try-catch` block, this crashes the application without any graceful handling or logging.

The solution demonstrates proper exception handling using a `try-catch` block.  It logs the exception details and allows the application to continue running or take alternative actions.

## How to run:
1.  Create a new C# Console Application project.
2.  Replace the contents of `Program.cs` with the code in `bug.cs` (to see the error).
3.  Then, replace it with the code in `bugSolution.cs` (to see the solution).
4. Run the application.