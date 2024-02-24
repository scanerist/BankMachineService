using System;
using Itmo.ObjectOrientedProgramming.Lab2.Services;
using Itmo.ObjectOrientedProgramming.Lab2.WiFi.Attributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.WiFi;

public class WifiBuilder : IWifiBuilder
{
    private WifiVersion? _wifiVersion;
    private bool _bluetooth;
    private PcieVersion? _pcieVersion;
    private Number? _watt;
    private string? _componentName;

    public IWifiBuilder WithVersion(WifiVersion version)
    {
        _wifiVersion = version;
        return this;
    }

    public IWifiBuilder WithBluetooth(bool bluetooth)
    {
        _bluetooth = bluetooth;
        return this;
    }

    public IWifiBuilder WithPcieVersion(PcieVersion pcieVersion)
    {
        _pcieVersion = pcieVersion;
        return this;
    }

    public IWifiBuilder WithWatt(Number watt)
    {
        _watt = watt;
        return this;
    }

    public IWifiBuilder WithName(string componentName)
    {
        _componentName = componentName;
        return this;
    }

    public IWifi Build()
    {
        return new Wifi(
            _wifiVersion ?? throw new ArgumentNullException(nameof(_wifiVersion)),
            _bluetooth,
            _pcieVersion ?? throw new ArgumentNullException(nameof(_pcieVersion)),
            _watt ?? throw new ArgumentNullException(nameof(_watt)),
            _componentName ?? throw new ArgumentNullException(nameof(_componentName)));
    }
}