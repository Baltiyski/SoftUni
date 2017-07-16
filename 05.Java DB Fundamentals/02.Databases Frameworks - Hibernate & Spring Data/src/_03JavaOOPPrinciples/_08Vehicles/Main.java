package _03JavaOOPPrinciples._08Vehicles;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * Created by StefanBaltiyski on 16.7.2017 г..
 */
public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String[] carInput = reader.readLine().split("\\s");
        String[] truckInput = reader.readLine().split("\\s");
        int procesTime = Integer.parseInt(reader.readLine());

        Vehicles car = new Car(Double.parseDouble(carInput[1]), Double.parseDouble(carInput[2]));
        Vehicles truck = new Truck(Double.parseDouble(truckInput[1]), Double.parseDouble(truckInput[2]));

        for (int i = 0; i < procesTime; i++) {
            String[] proces = reader.readLine().split("\\s");
            switch (proces[0]){
                case "Drive":
                    if ("Car".equals(proces[1])){
                        car.driv(Double.parseDouble(proces[2]));
                    } else {
                        truck.driv(Double.parseDouble(proces[2]));
                    }
                    break;
                case "Refuel":
                    if ("Car".equals(proces[1])){
                        car.refuel(Double.parseDouble(proces[2]));
                    } else {
                        truck.refuel(Double.parseDouble(proces[2]));
                    }
                    break;
                default:
                    break;
            }
        }

        System.out.printf("Car: %.2f\n",car.getFuelQuantity());
        System.out.printf("Truck: %.2f",truck.getFuelQuantity());

    }
}
