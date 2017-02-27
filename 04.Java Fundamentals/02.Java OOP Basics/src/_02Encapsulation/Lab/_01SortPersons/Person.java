package _02Encapsulation.Lab._01SortPersons;

public class Person {
	private String firstName;
	private String lastName;
	private Integer age;
	
	
	public Person(String firstName, String lastName, Integer age) {
		this.firstName = firstName;
		this.lastName = lastName;
		this.age = age;
	}


	public String getFirstName() {
		return this.firstName;
	}


	private void setFirstName(String firstName) {
		this.firstName = firstName;
	}


	public String getLastName() {
		return this.lastName;
	}


	private void setLastName(String lastName) {
		this.lastName = lastName;
	}


	public Integer getAge() {
		return this.age;
	}


	private void setAge(Integer age) {
		this.age = age;
	}


	@Override
	public String toString() {
		return String.format("%s %s is a %s years old.",this.getFirstName(),this.getLastName(), this.getAge());
	}
	
	
	
}
