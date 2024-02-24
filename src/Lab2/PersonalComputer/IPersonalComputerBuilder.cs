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

public interface IPersonalComputerBuilder
{
    IPersonalComputerBuilder WithMotherBoard(IMotherBoard motherBoard);
    IPersonalComputerBuilder WithCpu(ICPU cpu);
    IPersonalComputerBuilder WithHdd(IHDD hdd);
    IPersonalComputerBuilder WithComputerCase(IComputerCase? computerCase);
    IPersonalComputerBuilder WithVideoGraphicCard(IVideoGraphicCard videoGraphicCard);
    IPersonalComputerBuilder WithSsd(ISSD ssd);
    IPersonalComputerBuilder WithCoolingSystem(ICoolingSystem coolingSystem);
    IPersonalComputerBuilder WithWifi(IWifi? wifi);
    IPersonalComputerBuilder WithBios(IBios? bios);
    IPersonalComputerBuilder WithRam(IRAM ram);
    IPersonalComputerBuilder WithPowerSupply(IPowerSupply powerSupply);
    IPersonalComputer Build();
}