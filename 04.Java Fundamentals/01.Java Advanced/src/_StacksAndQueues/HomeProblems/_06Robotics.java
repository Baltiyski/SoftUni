package _StacksAndQueues.HomeProblems;

/*
 * Somewhere in the future, there is a robotics factory. The current project is assembly line robots. 
 * Each robot has a processing time, the time it needs to process a product. 
 * When a robot is free it should take a product for processing and log his name, product and processing start time. 
 * Each robot processes a product coming from the assembly line. 
 * A product is coming from the line each second (so the first product should appear at [start time + 1 second]). 
 * If a product passes the line and there is not a free robot to take it, 
 * it should be queued at the end of the line again.The robots are standing on the line in the order of their appearance.
 */

import java.util.ArrayDeque;
import java.util.Deque;
import java.util.Scanner;

public class _06Robotics {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String[] robotsTokens = scanner.nextLine().split(";");

        String[] robots = new String[robotsTokens.length];
        int[] processTime = new int[robotsTokens.length];
        int[] robotsCounter = new int[robotsTokens.length];

        for (int i = 0; i < robotsTokens.length; i++) {
            String[] robotArgs = robotsTokens[i].split("-");
            robots[i] = robotArgs[0];
            processTime[i] = Integer.valueOf(robotArgs[1]);
        }

        String[] timeTokens = scanner.nextLine().split(":");
        long hh = Integer.valueOf(timeTokens[0]) * 60 * 60;
        long mm = Integer.valueOf(timeTokens[1]) * 60;
        long ss = Integer.valueOf(timeTokens[2]);
        long time = hh + mm + ss;

        Deque<String> products = new ArrayDeque<>();

        String product = "";
        while (!("End".equals(product = scanner.nextLine()))) {
            products.add(product);
        }

        while (!products.isEmpty()) {
            for (int i = 0; i < robots.length; i++) {
                if (robotsCounter[i] > 0) {
                    robotsCounter[i]--;
                }
            }
            time++;
            String currentProduct = products.poll();
            boolean isProductTaken = false;

            for (int i = 0; i < robots.length; i++) {
                if (robotsCounter[i] == 0) {
                    robotsCounter[i] = processTime[i];
                    System.out.printf("%s - %s [%s]%n", robots[i], currentProduct, convertSecondsToHMmSs(time));
                    isProductTaken = true;
                    break;
                }
            }
            if (!isProductTaken) {
                products.offer(currentProduct);
            }
        }
    }

    private static String convertSecondsToHMmSs(long seconds) {
        long s = seconds % 60;
        long m = (seconds / 60) % 60;
        long h = (seconds / (60 * 60)) % 24;
        return String.format("%02d:%02d:%02d", h, m, s);
    }
}
