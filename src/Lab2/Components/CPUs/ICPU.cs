using Itmo.ObjectOrientedProgramming.Lab2.CoolingSystems;
using Itmo.ObjectOrientedProgramming.Lab2.CPUs.Attributes;
using Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;
using Itmo.ObjectOrientedProgramming.Lab2.Services;
using Itmo.ObjectOrientedProgramming.Lab2.Validation;
using Itmo.ObjectOrientedProgramming.Lab2.VideoGraphicCards;

namespace Itmo.ObjectOrientedProgramming.Lab2.CPUs;

public interface ICPU : ICPUBuilderDirector, IComponent, IValidate<ICoolingSystem>, IValidate<IVideoGraphicCard>, IValidate<IMotherBoard>
{
     CpuSocket? Socket { get; }
     Number? CoreFrequency { get; }
     VideoCore? VideoCore { get; }
     Number? CapableCoreFrequency { get; }
     Number? Tdp { get; }
     Number? Watt { get; }
}