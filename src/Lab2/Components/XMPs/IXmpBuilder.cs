using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.XMPs;

public interface IXmpBuilder
{
    IXmpBuilder Withtiming(Number timing);
    IXmpBuilder WithVoltage(Number volatge);
    IXmpBuilder WithFrequency(Number frequency);
    IXmpBuilder WithName(string compponentName);
    IXmp Build();
}