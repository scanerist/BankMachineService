using Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;
using Itmo.ObjectOrientedProgramming.Lab2.Results;
using Itmo.ObjectOrientedProgramming.Lab2.Services;
using Itmo.ObjectOrientedProgramming.Lab2.WiFi.Attributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.WiFi;

public class Wifi : IWifi
{
    public Wifi(WifiVersion version, bool bluetooth, PcieVersion pcieVersion, Number watt, string componentName)
    {
        Version = version;
        Bluetooth = bluetooth;
        PcieVersion = pcieVersion;
        Watt = watt;
        ComponentName = componentName;
    }

    public WifiVersion Version { get; }
    public bool Bluetooth { get; }
    public PcieVersion PcieVersion { get; }
    public Number Watt { get; }
    public string ComponentName { get; }

    public IWifiBuilder Direct(IWifiBuilder builder)
    {
        return builder.WithBluetooth(Bluetooth)
            .WithVersion(Version)
            .WithPcieVersion(PcieVersion)
            .WithWatt(Watt);
    }

    public ResultType Validate(IMotherBoard componentOne)
    {
        if (componentOne.PciELines.Name == PcieVersion.Name)
        {
            return new Succes();
        }

        return new InvalidBuild();
    }
}