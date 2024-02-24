namespace Itmo.ObjectOrientedProgramming.Lab2.VideoGraphicCards;

public interface IVideoGraphicCardBuilderDirector
{
    IVideoGraphicCardBuilder Direct(IVideoGraphicCardBuilder builder);
}