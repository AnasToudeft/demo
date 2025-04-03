namespace AssuranceQualiteLogicielle;

public class Point {
    private int x;
    private int y;

    public Point() {
        this.x = 0;
        this.y = 0;
    }

    public Point(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public int GetX() {
        return this.x;
    }

    public int GetY() {
        return this.y;
    }

    public void SetX(int x) {
        this.x = x;
    }

    public void SetY(int y) {
        this.y = y;
    }

    public double Distance(Point autre) {
        return Math.Sqrt(
            Math.Pow(this.x - autre.x, 2) + 
            Math.Pow(this.y - autre.y, 2)
        );
    }
}
