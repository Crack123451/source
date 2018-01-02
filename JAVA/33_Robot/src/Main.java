import java.math.*;
import java.util.Arrays;

public class Main {
    public static void main(String[] args) {
        Robot robot = new Robot(0,0, Direction.DOWN);
        moveRobot(robot, 10, -5);
    }

    public enum Direction {
        UP,
        DOWN,
        LEFT,
        RIGHT
    }

    public static class Robot {
        int x;
        int y;
        Direction dir;

        public Robot (int x, int y, Direction dir) {
            this.x = x;
            this.y = y;
            this.dir = dir;
        }

        public Direction getDirection() {return dir;}

        public int getX() {return x;}

        public int getY() {return y;}

        public void turnLeft() {
            if      (dir == Direction.UP)    {dir = Direction.LEFT;}
            else if (dir == Direction.DOWN)  {dir = Direction.RIGHT;}
            else if (dir == Direction.LEFT)  {dir = Direction.DOWN;}
            else if (dir == Direction.RIGHT) {dir = Direction.UP;}
        }

        public void turnRight() {
            if      (dir == Direction.UP)    {dir = Direction.RIGHT;}
            else if (dir == Direction.DOWN)  {dir = Direction.LEFT;}
            else if (dir == Direction.LEFT)  {dir = Direction.UP;}
            else if (dir == Direction.RIGHT) {dir = Direction.DOWN;}
        }

        public void stepForward() {
            if (dir == Direction.UP)    {y++;}
            if (dir == Direction.DOWN)  {y--;}
            if (dir == Direction.LEFT)  {x--;}
            if (dir == Direction.RIGHT) {x++;}
        }
    }

    public static void moveRobot(Robot robot, int toX, int toY) {
        double stepX, stepY;

        if( toX==robot.getX() && toY==robot.getY() )
            return;
        if (robot.getX()>toX)
            stepX=-Math.sqrt( (robot.getX()-toX)*(robot.getX()-toX) );
        else stepX=Math.sqrt( (toX-robot.getX())*(toX-robot.getX()) );

        if (robot.getY()>toY)
            stepY=-Math.sqrt( (robot.getY()-toY)*(robot.getY()-toY) );
        else  stepY=Math.sqrt( (toY-robot.getY())*(toY-robot.getY()) );

        while(robot.getDirection() != Direction.UP)
            robot.turnRight();

        if(stepY<0)
        {
            robot.turnRight();
            robot.turnRight();
        }
        for(int i=0;i<Math.abs(stepY);i++)
            robot.stepForward();

        if(stepX>=0)
            robot.turnRight();
        else
            robot.turnLeft();
        for(int i=0;i<Math.abs(stepX);i++)
            robot.stepForward();
    }
}

