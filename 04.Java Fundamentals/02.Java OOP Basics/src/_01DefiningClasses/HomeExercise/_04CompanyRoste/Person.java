package _01DefiningClasses.HomeExercise._04CompanyRoste;

public class Person {
	private final static int DEFAULT_AGE = -1;
	
	private int age;
	private String name;
	
	public Person(String name) {
		this(name,DEFAULT_AGE);
	}
	
	public Person(String name, int age) {
		this.name = name;
		this.age= age;
	}

	public int getAge() {
		return this.age;
	}

	public String getName() {
		return this.name;
	}
	
	
}
