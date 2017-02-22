package _01DefiningClasses.Lab.StaticIdAndRate;

import java.awt.List;
import java.util.ArrayList;

import _01DefiningClasses.Lab.BankAccEx.BankAccount;

public class Person {
	private String name;
	private int age;
	private List accounts;
	
	
	public Person(String name, int age) {
		this(name, age, new List());
	}
	
	public Person(String name, int age, List accounts) {
		this.name = name;
		this.age= age;
		this.accounts = accounts;
	}
}
