namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public interface IDisplayDriver
{
    string UpdateColor(string message);
    void Print(string message);
    void Clear();
}