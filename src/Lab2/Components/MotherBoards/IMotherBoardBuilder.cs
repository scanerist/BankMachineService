using Itmo.ObjectOrientedProgramming.Lab2.BIOS;
using Itmo.ObjectOrientedProgramming.Lab2.Services;
using Itmo.ObjectOrientedProgramming.Lab2.WiFi.Attributes;

namespace Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;

public interface IMotherBoardBuilder
{
    IMotherBoardBuilder WithSocket(MotherBoardSocket socket);
    IMotherBoardBuilder WithBios(IBios bios);
    IMotherBoardBuilder WithSataPorts(Number sataPorts);
    IMotherBoardBuilder WithPciELines(PcieVersion pciELines);
    IMotherBoardBuilder WithChipSet(MotherBoardChipset chipset);
    IMotherBoardBuilder WithNumberOfRamSLots(Number numberOfSlots);
    IMotherBoardBuilder WithDDR(Number ddr);
    IMotherBoardBuilder WithFormfactor(FormFactor formFactor);
    IMotherBoardBuilder WithName(string componentName);

    IMotherBoard Build();
}