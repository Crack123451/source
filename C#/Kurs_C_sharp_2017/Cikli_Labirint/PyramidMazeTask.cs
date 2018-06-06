namespace Mazes
{
	public static class PyramidMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
            for (int i = 0; i < height - 2; i += 4)
            {
                GoToWall(robot, width - 3-i, Direction.Right);
                GoToWall(robot, 2, Direction.Up);
                GoToWall(robot, width - 5-i, Direction.Left);
                if (i>=height-5)
                    break;
                GoToWall(robot, 2, Direction.Up);
            }
        }

        public static void GoToWall(Robot robot, int limit, Direction direction)
        {
            for (int i = 0; i < limit; i++)
            {
                robot.MoveTo(direction);
            }
        }
    }
}