namespace Models;

public abstract record OperationsResult
{
    private OperationsResult()
    {
    }

    public sealed record Success : OperationsResult;

    public sealed record Failure(string Message) : OperationsResult;
}