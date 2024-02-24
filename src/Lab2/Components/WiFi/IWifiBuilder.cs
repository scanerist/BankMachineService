using Itmo.ObjectOrientedProgramming.Lab2.Services;
using Itmo.ObjectOrientedProgramming.Lab2.WiFi.Attributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.WiFi;

public interface IWifiBuilder
{
    IWifiBuilder WithVersion(WifiVersion version);
    IWifiBuilder WithBluetooth(bool bluetooth);
    IWifiBuilder WithPcieVersion(PcieVersion pcieVersion);
    IWifiBuilder WithWatt(Number watt);
    IWifiBuilder WithName(string componentName);
    IWifi Build();
}