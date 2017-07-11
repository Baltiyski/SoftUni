package _02JavaOOPOverview._03LastDigitName;

import java.util.Scanner;

/**
 * Created by StefanBaltiyski on 6.7.2017 г..
 */
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int number = Integer.parseInt(sc.nextLine());
        Number nameDigit = new Number(number);
        System.out.println(nameDigit.getNameForLastDigit());
    }
}
