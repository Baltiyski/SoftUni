package _03Inheritance.HomeExercise._03Mankind;

public class Student extends Human{
	private String facultyNum;
	
	public Student(String firstName, String lastName, String facultyNum) {
		super(firstName, lastName);
		this.setFacultyNum(facultyNum);
		// TODO Auto-generated constructor stub
	}

	private String getFacultyNum() {
		return facultyNum;
	}

	private void setFacultyNum(String facultyNum) {
		if(facultyNum.length() < 5 || facultyNum.length() > 10) {
			throw new IllegalArgumentException("Invalid faculty number!");
		}
		this.facultyNum = facultyNum;
	}

	@Override
	public String toString() {
		return super.toString() + "Faculty Number: " + this.getFacultyNum();
	}
	
}
