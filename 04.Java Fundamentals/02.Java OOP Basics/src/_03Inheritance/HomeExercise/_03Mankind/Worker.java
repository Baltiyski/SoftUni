package _03Inheritance.HomeExercise._03Mankind;

import java.text.DecimalFormat;

public class Worker extends Human{
	private double weekSalary;
	private double workingHours;
	
	public Worker(String firstName, String lastName, double weekSalary, double workingHours) {
		super(firstName, lastName);
		this.setWeekSalary(weekSalary);
		this.setWorkingHours(workingHours);
	}

	private double getWeekSalary() {
		return weekSalary;
	}

	private void setWeekSalary(double weekSalary) {
		if (weekSalary < 10) {
			throw new IllegalArgumentException("Expected value mismatch!Argument: weekSalary");
		}
		this.weekSalary = weekSalary;
	}

	private double getWorkingHours() {
		return workingHours;
	}

	private void setWorkingHours(double workingHours) {
		if (workingHours < 1 || workingHours > 12) {
			throw new IllegalArgumentException("Expected value mismatch!Argument: workHoursPerDay");
		}
		this.workingHours = workingHours;
	}
	
	private double getSalaryPerHour() {
		
		return (this.getWeekSalary() / 7) / this.getWorkingHours();
	}
	
	@Override
	public String toString() {
		DecimalFormat dcFormat = new DecimalFormat("0.00");
		return super.toString()
					+"Week Salay: " + dcFormat.format(this.getWeekSalary())
					+System.lineSeparator()
					+"Hours per day: " + dcFormat.format(this.getWorkingHours())
					+System.lineSeparator()
					+"Salary per hour: " + dcFormat.format(this.getSalaryPerHour());
	}
}
