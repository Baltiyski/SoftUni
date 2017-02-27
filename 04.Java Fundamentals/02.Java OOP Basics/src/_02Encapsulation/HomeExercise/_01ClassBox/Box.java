package _02Encapsulation.HomeExercise._01ClassBox;

public class Box {
	private double length;
	private double width ;
	private double height;
	
	public Box(double lenght, double width, double height) {
		this.length = lenght;
		this.width = width;
		this.height = height;
	}
	
	public double surfaceArea(double l, double w, double h) {
		double area = (2*l*w) + (2*l*h) + (2*w*h);
		return area;
	}
	
	public double lateralSurfArea(double l, double w, double h) {
		double area = (2*l*h) + (2*w*h);
		return area;
	}
	
	public double volume(double l, double w, double h) {
		double area = l * w * h;
		return area;
	}
	
}
