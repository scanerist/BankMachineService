using System;
using Itmo.ObjectOrientedProgramming.Lab2.BIOS;
using Itmo.ObjectOrientedProgramming.Lab2.ComputerCases;
using Itmo.ObjectOrientedProgramming.Lab2.CoolingSystems;
using Itmo.ObjectOrientedProgramming.Lab2.CPUs;
using Itmo.ObjectOrientedProgramming.Lab2.HDDs;
using Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;
using Itmo.ObjectOrientedProgramming.Lab2.PowerSupplies;
using Itmo.ObjectOrientedProgramming.Lab2.RAMs;
using Itmo.ObjectOrientedProgramming.Lab2.SSDs;
using Itmo.ObjectOrientedProgramming.Lab2.VideoGraphicCards;
using Itmo.ObjectOrientedProgramming.Lab2.WiFi;

namespace Itmo.ObjectOrientedProgramming.Lab2.PersonalComputer;

public class PersonalComputerBuilder : IPersonalComputerBuilder
{
    private IMotherBoard? _motherBoard;
    private ICPU? _cpu;
    private IHDD? _hdd;
    private IComputerCase? _computerCase;
    private IVideoGraphicCard? _videoGraphicCard;
    private ISSD? _ssd;
    private ICoolingSystem? _coolingSystem;
    private IWifi? _wifi;
    private IBios? _bios;
    private IRAM? _ram;
    private IPowerSupply? _powerSupply;
    public IPersonalComputerBuilder WithMotherBoard(IMotherBoard motherBoard)
    {
        _motherBoard = motherBoard;
        return this;
    }

    public IPersonalComputerBuilder WithCpu(ICPU cpu)
    {
        _cpu = cpu;
        return this;
    }

    public IPersonalComputerBuilder WithHdd(IHDD hdd)
    {
        _hdd = hdd;
        return this;
    }

    public IPersonalComputerBuilder WithComputerCase(IComputerCase? computerCase)
    {
        _computerCase = computerCase;
        return this;
    }

    public IPersonalComputerBuilder WithVideoGraphicCard(IVideoGraphicCard videoGraphicCard)
    {
        _videoGraphicCard = videoGraphicCard;
        return this;
    }

    public IPersonalComputerBuilder WithSsd(ISSD ssd)
    {
        _ssd = ssd;
        return this;
    }

    public IPersonalComputerBuilder WithCoolingSystem(ICoolingSystem coolingSystem)
    {
        _coolingSystem = coolingSystem;
        return this;
    }

    public IPersonalComputerBuilder WithWifi(IWifi? wifi)
    {
        _wifi = wifi;
        return this;
    }

    public IPersonalComputerBuilder WithBios(IBios? bios)
    {
        _bios = bios;
        return this;
    }

    public IPersonalComputerBuilder WithRam(IRAM ram)
    {
        _ram = ram;
        return this;
    }

    public IPersonalComputerBuilder WithPowerSupply(IPowerSupply powerSupply)
    {
        _powerSupply = powerSupply;
        return this;
    }

    public IPersonalComputer Build()
    {
        return new PersponalComputer(
            _motherBoard ?? throw new ArgumentNullException(nameof(_motherBoard)),
            _cpu ?? throw new ArgumentNullException(nameof(_cpu)),
            _hdd ?? throw new ArgumentNullException(nameof(_hdd)),
            _computerCase ?? throw new ArgumentNullException(nameof(_computerCase)),
            _videoGraphicCard ?? throw new ArgumentNullException(nameof(_videoGraphicCard)),
            _ssd ?? throw new ArgumentNullException(nameof(_ssd)),
            _coolingSystem ?? throw new ArgumentNullException(nameof(_coolingSystem)),
            _wifi,
            _bios,
            _ram ?? throw new ArgumentNullException(nameof(_ram)),
            _powerSupply ?? throw new ArgumentNullException(nameof(_powerSupply)));
    }
}