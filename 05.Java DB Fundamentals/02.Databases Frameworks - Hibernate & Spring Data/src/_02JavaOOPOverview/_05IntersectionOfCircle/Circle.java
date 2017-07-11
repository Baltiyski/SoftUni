package _02JavaOOPOverview._05IntersectionOfCircle;

/**
 * Created by StefanBaltiyski on 6.7.2017 г..
 */
public class Circle {
    private Point center;
    private double radius;

    public Circle(Point center, double radius) {
        this.center = center;
        this.radius = radius;
    }

    public Point getCenter() {
        return center;
    }

    public double getRadius() {
        return radius;
    }
}
