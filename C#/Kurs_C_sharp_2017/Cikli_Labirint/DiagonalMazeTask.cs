namespace Mazes
{
    public static class DiagonalMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            if (width >= height)
                MoveOnDiagonalMaze(robot, (width - 3) / (height - 2), height - 2, Direction.Right);
            if (width < height)
                MoveOnDiagonalMaze(robot, (height - 3) / (width - 2), width - 2, Direction.Down);
        }

        public static void GoToWall(Robot robot, int limit, Direction direction)
        {
            for (int i = 0; i < limit; i++)
                robot.MoveTo(direction);
        }

        public static void MoveOnDiagonalMaze(Robot robot, int lengthPassage, int numberPassage, Direction direction)
        {
            for (int i = 0; i < numberPassage; i++)
            {
                GoToWall(robot, lengthPassage, direction);
                if (i == numberPassage - 1)
                    break;
                if (direction == Direction.Right)
                    GoToWall(robot, 1, Direction.Down);
                else
                    GoToWall(robot, 1, Direction.Right);
            }
        }
    }
}