package _02Encapsulation.HomeExercise._03AnimalFarm;

public class Chicken {
    private static final int MIN_AGE = 0;
    private static final int MAX_AGE = 15;
	
	private String name;
	private int age;
	
	public Chicken(String name, int age) {
		this.setName(name);
		this.setAge(age);
	}
	
	public String getName() {
		return name;
	}
	
	private void setName(String name) {
		if (name.length() <= 0 || name.equals(" ") || name.equals(null)) {
			throw new IllegalArgumentException("Name cannot be empty.");
		}
		this.name = name;
	}
	
	public int getAge() {
		return age;
	}
	
	private void setAge(int age) {
		if (age <= MIN_AGE || age > MAX_AGE) {
			throw new IllegalArgumentException("Age should be between 0 and 15.");
		}
		this.age = age;
	}
	
	 private double calculateProductPerDay() {
		 if(this.getAge() < 6) {
			 return 2;
		 } else if (this.getAge() > 6 && this.getAge() < 12) {
			 return 1;
		 }			 
		 return 0.75; 

	 }
	 
	 public double productPerDay() {
		 return calculateProductPerDay();
	 }
	
}
