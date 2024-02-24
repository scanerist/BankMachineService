using Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;
using Itmo.ObjectOrientedProgramming.Lab2.Services;
using Itmo.ObjectOrientedProgramming.Lab2.Validation;
using Itmo.ObjectOrientedProgramming.Lab2.WiFi.Attributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.WiFi;

public interface IWifi : IWifiBuilderDirector, IComponent, IValidate<IMotherBoard>
{
    WifiVersion Version { get; }
    bool Bluetooth { get; }
    PcieVersion PcieVersion { get; }
    Number Watt { get; }
}