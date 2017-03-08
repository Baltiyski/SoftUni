package _03Inheritance.HomeExercise._04MordorsCrueltyPlan;

public class Mood extends Food{
	private String mood;
	
	public String getMood(){
		return this.mood;
	}
	
	public void setMood(){
		if(this.getPoints() < -5) {
			this.mood = "Angry";
		} else if (this.getPoints() < 0) {
			this.mood = "Sad";
		} else if (this.getPoints() <= 15) {
			this.mood = "Happy";
		} else {
			this.mood = "JavaScript";
		}
	}
}
