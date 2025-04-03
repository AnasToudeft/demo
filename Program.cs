namespace AssuranceQualiteLogicielle;

public class Program {
    public static void Main() {
        Point zero = new Point();
        Point pointA = new Point(2, 3);
        Point pointB = new Point(10, 0);
        //commmmeeennnntttaaaiiiirrrreee
        double distanceA = zero.Distance(pointA);
        double distanceB = zero.Distance(pointB);
        Console.WriteLine(distanceA);
        Console.WriteLine(distanceB);

        // Anas Toudeft
    }
}