using Itmo.ObjectOrientedProgramming.Lab2.BIOS;
using Itmo.ObjectOrientedProgramming.Lab2.CPUs;
using Itmo.ObjectOrientedProgramming.Lab2.Results;
using Itmo.ObjectOrientedProgramming.Lab2.Services;
using Itmo.ObjectOrientedProgramming.Lab2.WiFi.Attributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;

public class MotherBoard : IMotherBoard
{
    public MotherBoard(IBios bios, FormFactor formFactor, Number ddr, Number sataPorts, PcieVersion pciELines, MotherBoardSocket socket, Number numberOfRamSlots, MotherBoardChipset chipset, string componentName)
    {
        BIOS = bios;
        FormFactor = formFactor;
        Ddr = ddr;
        SataPorts = sataPorts;
        PciELines = pciELines;
        Socket = socket;
        NumberOfRamSlots = numberOfRamSlots;
        Chipset = chipset;
        ComponentName = componentName;
    }

    public MotherBoardSocket Socket { get; }
    public PcieVersion PciELines { get; }
    public Number SataPorts { get; }
    public MotherBoardChipset Chipset { get; }
    public Number Ddr { get; }
    public Number NumberOfRamSlots { get; }
    public FormFactor FormFactor { get; }
    public IBios BIOS { get; }
    public string ComponentName { get; }

    public IMotherBoardBuilder Direct(IMotherBoardBuilder builder)
    {
       return builder.WithSocket(Socket)
        .WithFormfactor(FormFactor)
        .WithSataPorts(SataPorts)
        .WithBios(BIOS)
        .WithChipSet(Chipset)
        .WithDDR(Ddr)
        .WithPciELines(PciELines)
        .WithNumberOfRamSLots(NumberOfRamSlots);
    }

    public ResultType Validate(ICPU componentOne)
    {
        if (componentOne.Socket?.Name == Socket.Name)
        {
            return new Succes();
        }

        return new InvalidBuild();
    }
}