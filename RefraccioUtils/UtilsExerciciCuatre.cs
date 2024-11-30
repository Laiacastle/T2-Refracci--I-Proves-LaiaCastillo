namespace RefraccioUtils
{
    public class Utils
    {
        public static double CalculateArea(double width, double height)
        {
            return width * height;
        }
        public static double CalculateCircum(double radius)
        {
            return 2 * Math.PI * radius;
        }
        public static bool GraterThanZero(double num)
        {
            return num > 0;
        }
    }
}
