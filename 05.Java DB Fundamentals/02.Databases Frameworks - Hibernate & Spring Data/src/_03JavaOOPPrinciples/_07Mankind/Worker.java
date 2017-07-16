package _03JavaOOPPrinciples._07Mankind;

/**
 * Created by StefanBaltiyski on 15.7.2017 г..
 */
public class Worker extends Human{
    private double weekSalary;
    private double workingHoursPerDay;


    protected Worker(String fname, String lname, double weekSalary, double workingHoursPerDay) {
        super(fname, lname);
        this.setWeekSalary(weekSalary);
        this.setWorkingHoursPerDay(workingHoursPerDay);
    }

    private double getWeekSalary() {
        return this.weekSalary;
    }

    private void setWeekSalary(double weekSalary) {
        if (weekSalary < 10) {
            throw new IllegalArgumentException("Expected value mismatch!Argument: " + weekSalary);
        }
        this.weekSalary = weekSalary;
    }

    private double getWorkingHoursPerDay() {
        return this.workingHoursPerDay;
    }

    private void setWorkingHoursPerDay(double workingHoursPerDay) {
        if (workingHoursPerDay < 1 || 12 < workingHoursPerDay) {
            throw new IllegalArgumentException("Expected value mismatch!Argument: workHoursPerDay");
        }

        this.workingHoursPerDay = workingHoursPerDay;
    }

    private double salaryPerHour() {
        return this.getWeekSalary() / (7 * this.getWorkingHoursPerDay());
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append("First Name: ").append(super.getFname())
                .append(System.lineSeparator())
                .append("Last Name: ").append(super.getLname())
                .append(System.lineSeparator())
                .append("Week Salary : ").append(String.format("%.2f",this.getWeekSalary()))
                .append(System.lineSeparator())
                .append("Hours per day: ").append(String.format("%.2f", this.getWorkingHoursPerDay()))
                .append(System.lineSeparator())
                .append("Salary per hour: ").append(String.format("%.2f",this.salaryPerHour()));
        return sb.toString();
    }
}
