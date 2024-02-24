using Itmo.ObjectOrientedProgramming.Lab2.BIOS;
using Itmo.ObjectOrientedProgramming.Lab2.CPUs;
using Itmo.ObjectOrientedProgramming.Lab2.Services;
using Itmo.ObjectOrientedProgramming.Lab2.Validation;
using Itmo.ObjectOrientedProgramming.Lab2.WiFi.Attributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;

public interface IMotherBoard : IMotherBoardBuilderDirector, IComponent, IValidate<ICPU>
{
    public MotherBoardSocket Socket { get; }
    public PcieVersion PciELines { get; }
    public Number SataPorts { get; }
    public MotherBoardChipset Chipset { get; }
    public Number Ddr { get; }
    public Number NumberOfRamSlots { get; }
    public FormFactor FormFactor { get; }
    public IBios BIOS { get; }
}