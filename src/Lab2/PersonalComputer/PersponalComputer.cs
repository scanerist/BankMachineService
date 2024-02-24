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

public class PersponalComputer : IPersonalComputer
{
    public PersponalComputer(IMotherBoard motherBoard, ICPU cpu, IHDD hdd, IComputerCase? computerCase, IVideoGraphicCard videoGraphicCard, ISSD ssd, ICoolingSystem coolingSystem, IWifi? wifiModule, IBios? bios, IRAM ram, IPowerSupply powerSupply)
    {
        MotherBoard = motherBoard;
        Cpu = cpu;
        Hdd = hdd;
        ComputerCase = computerCase;
        VideoGraphicCard = videoGraphicCard;
        Ssd = ssd;
        CoolingSystem = coolingSystem;
        WifiModule = wifiModule;
        Bios = bios;
        Ram = ram;
        PowerSupply = powerSupply;
    }

    public IMotherBoard MotherBoard { get; }
    public ICPU Cpu { get; }
    public IHDD Hdd { get; }
    public IComputerCase? ComputerCase { get; }
    public IVideoGraphicCard VideoGraphicCard { get; }
    public ISSD Ssd { get; }
    public ICoolingSystem CoolingSystem { get; }
    public IWifi? WifiModule { get; }
    public IBios? Bios { get; }
    public IRAM Ram { get; }
    public IPowerSupply PowerSupply { get; }

    public IPersonalComputerBuilder Direct(IPersonalComputerBuilder builder)
    {
        return builder.WithMotherBoard(MotherBoard)
            .WithBios(Bios)
            .WithCpu(Cpu)
            .WithHdd(Hdd)
            .WithRam(Ram)
            .WithSsd(Ssd)
            .WithCoolingSystem(CoolingSystem)
            .WithPowerSupply(PowerSupply).WithVideoGraphicCard(VideoGraphicCard)
            .WithWifi(WifiModule)
            .WithComputerCase(ComputerCase);
    }
}