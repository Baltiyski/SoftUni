package _03Inheritance.HomeExercise._01Person;

public class Child extends Person{

	public Child(String name, int age) {
		super(name, age);
		// TODO Auto-generated constructor stub
	}
	
	@Override
	protected void setAge(Integer age) throws IllegalArgumentException{
		if(age > 15) {
			throw new IllegalArgumentException("Child's age must be lesser than 15!");
		}
		super.setAge(age);
	}
	
}
