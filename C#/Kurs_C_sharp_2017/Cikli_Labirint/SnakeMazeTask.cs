namespace Mazes
{
	public static class SnakeMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
            for (int i = 0; i < height-2; i += 2)
            {
                GoToWall(robot, width - 3, Direction.Right);
                GoToWall(robot, 2, Direction.Down);
                GoToWall(robot, width - 3, Direction.Left);
                i += 2;
                if (i>height-4)
                    break;
                GoToWall(robot, 2, Direction.Down);             
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