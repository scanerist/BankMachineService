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

public interface IPersonalComputer : IPersonalComputerBuilderDIrector
{
    IMotherBoard MotherBoard { get; }
    ICPU Cpu { get; }
    IHDD Hdd { get; }
    IComputerCase? ComputerCase { get; }
    IVideoGraphicCard VideoGraphicCard { get; }
    ISSD Ssd { get; }
    ICoolingSystem CoolingSystem { get; }
    IWifi? WifiModule { get; }
    IBios? Bios { get; }
    IRAM Ram { get; }
    IPowerSupply PowerSupply { get; }
}