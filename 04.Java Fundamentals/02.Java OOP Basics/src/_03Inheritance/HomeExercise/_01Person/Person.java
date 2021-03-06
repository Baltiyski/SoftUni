package _03Inheritance.HomeExercise._01Person;

public class Person {
	private String name;
	private int age;
	
	public Person(String name, int age) {
		this.setAge(age);
		this.setName(name);
	}
	
	protected String getName() {
		return name;
	}
	private void setName(String name) throws IllegalArgumentException{
		if (name.length() < 3) {
			throw new IllegalArgumentException("Name's length should not be less than 3 symbols!");
		}
		this.name = name;
	}
	protected int getAge() {
		return age;
	}
	protected void setAge(Integer age) throws IllegalArgumentException {
		if(age < 1) {
			throw new IllegalArgumentException("Age must be positive!");
		}
		this.age = age;
	}

	@Override
	public String toString() {
		StringBuilder stringBuild = new StringBuilder();
		stringBuild.append(String.format("Name: %s, Age: %s",this.getName(), this.getAge()));
		
		return stringBuild.toString();
	}
	
}
