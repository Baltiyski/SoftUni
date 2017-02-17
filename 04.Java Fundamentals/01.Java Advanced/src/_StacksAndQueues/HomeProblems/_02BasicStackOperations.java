/*
 * You will be given an integer N representing the number of elements to push onto the stack, 
 * an integer S representing the number of elements to pop from the stack and finally an integer X, 
 * an element that you should check whether is present in the stack. If it is, 
 * print true on the console. 
 * If it’s not, print the smallest element currently present in the stack.
 */
package _StacksAndQueues.HomeProblems;

import java.util.ArrayDeque;
import java.util.Collections;
import java.util.Scanner;

public class _02BasicStackOperations {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] input = scanner.nextLine().split(" ");

        int countToPush = Integer.parseInt(input[0]);
        int countToPop = Integer.parseInt(input[1]);
        int element = Integer.parseInt(input[2]);

        String[] numbers = scanner.nextLine().split("\\s+");

        ArrayDeque<Integer> stack = new ArrayDeque<>();

        int minElement = Integer.MAX_VALUE;

        for (int i = 0; i < countToPush; i++) {
            stack.push(Integer.parseInt(numbers[i]));
        }

        for (int i = 0; i < countToPop; i++) {
            stack.pop();
        }

        if (stack.contains(element)) {
            System.out.println(true);
        } else if (stack.size() == 0){
            System.out.println("0");
        } else {

            for (Integer integer : stack) {
                if (integer < minElement){
                    minElement = integer;
                }
            }

            System.out.println(minElement);
        }
	}
}
