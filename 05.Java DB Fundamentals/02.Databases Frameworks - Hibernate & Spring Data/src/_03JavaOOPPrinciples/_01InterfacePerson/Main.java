package _03JavaOOPPrinciples._01InterfacePerson;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.lang.reflect.Method;
import java.util.Arrays;

/**
 * Created by StefanBaltiyski on 11.7.2017 г..
 */
public class Main {
    public static void main(String[] args) throws IOException {
        Class[] citizenInterfaces = Citizen.class.getInterfaces();
        if (Arrays.asList(citizenInterfaces).contains(Person.class)) {
            Method[] methods = Person.class.getDeclaredMethods();

            BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
            String name = reader.readLine();
            int age = Integer.parseInt(reader.readLine());

            Person person = new Citizen(name, age);
            System.out.println(methods.length);
            System.out.println(person.getName());
            System.out.println(person.getAge());
        }
    }

}
