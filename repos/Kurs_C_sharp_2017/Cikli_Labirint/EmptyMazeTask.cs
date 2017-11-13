namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
            GoToWall(robot, height - 3, Direction.Down);
            GoToWall(robot, width - 3, Direction.Right);
        }


        public static void GoToWall(Robot robot,int limit, Direction direction)
        {
            for (int i = 0; i < limit; i++)
            {
                robot.MoveTo(direction);
            }
        }
    }
}