package _03Inheritance.Lab._04FragileBaseClass;

import java.util.Collections;

public class Predator extends Animal{

    private int health;

    public void feed(Food food) {
        super.eat(food);
        health++;
    }

    public void feedAll(Food[] foods) {
        Collections.addAll(super.foodEaten, foods);
        health += foods.length;
    }
}