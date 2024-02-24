namespace Itmo.ObjectOrientedProgramming.Lab2.MotherBoards;

public interface IMotherBoardBuilderDirector
{
    IMotherBoardBuilder Direct(IMotherBoardBuilder builder);
}