using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Storage;

public class IStorage<T>
    where T : IComponent
{
    private Dictionary<int, T>? _repository;

    public IStorage(Dictionary<int, T>? repository)
    {
        _repository = repository;
    }

    public void Add(int id, T component)
    {
        _repository?.Add(id, component);
    }
}