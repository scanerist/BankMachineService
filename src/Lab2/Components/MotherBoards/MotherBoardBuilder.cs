using System;
using Itmo.ObjectOrientedProgramming.Lab2.BIOS;
using Itmo.ObjectOrientedProgramming.Lab2.Services;
using Itmo.ObjectOrientedProgramming.Lab2.WiFi.Attributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;

public class MotherBoardBuilder : IMotherBoardBuilder
{
    private MotherBoardSocket? _socket;
    private IBios? _bios;
    private MotherBoardChipset? _chipset;
    private PcieVersion? _pciELines;
    private Number? _numberOfSlots;
    private Number? _sataPorts;
    private Number? _ddr;
    private FormFactor? _formFactor;
    private string? _componentName;
    public IMotherBoardBuilder WithSocket(MotherBoardSocket socket)
    {
        _socket = socket;
        return this;
    }

    public IMotherBoardBuilder WithBios(IBios bios)
    {
        _bios = bios;
        return this;
    }

    public IMotherBoardBuilder WithSataPorts(Number sataPorts)
    {
        _sataPorts = sataPorts;
        return this;
    }

    public IMotherBoardBuilder WithPciELines(PcieVersion pciELines)
    {
        _pciELines = pciELines;
        return this;
    }

    public IMotherBoardBuilder WithChipSet(MotherBoardChipset chipset)
    {
        _chipset = chipset;
        return this;
    }

    public IMotherBoardBuilder WithNumberOfRamSLots(Number numberOfSlots)
    {
        _numberOfSlots = numberOfSlots;
        return this;
    }

    public IMotherBoardBuilder WithDDR(Number ddr)
    {
        _ddr = ddr;
        return this;
    }

    public IMotherBoardBuilder WithFormfactor(FormFactor formFactor)
    {
        _formFactor = formFactor;
        return this;
    }

    public IMotherBoardBuilder WithName(string componentName)
    {
        _componentName = componentName;
        return this;
    }

    public IMotherBoard Build()
    {
        return new MotherBoard(
            _bios ?? throw new ArgumentNullException(nameof(_bios)),
            _formFactor ?? throw new ArgumentNullException(nameof(_formFactor)),
            _ddr ?? throw new ArgumentNullException(nameof(_ddr)),
            _sataPorts ?? throw new ArgumentNullException(nameof(_sataPorts)),
            _pciELines ?? throw new ArgumentNullException(nameof(_pciELines)),
            _socket ?? throw new ArgumentNullException(nameof(_socket)),
            _numberOfSlots ?? throw new ArgumentNullException(nameof(_numberOfSlots)),
            _chipset ?? throw new ArgumentNullException(nameof(_chipset)),
            _componentName ?? throw new ArgumentNullException(nameof(_componentName)));
    }
}