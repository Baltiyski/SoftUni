package _03JavaOOPPrinciples._08Vehicles;

import java.text.DecimalFormat;

/**
 * Created by StefanBaltiyski on 16.7.2017 г..
 */
public class Car extends Vehicles{
    private static final double airconditionConsum = 0.9;
    private double combineConsum = airconditionConsum + getLiterPerKm();

    public Car(double fuelQuantity, double literPerKm) {
        super(fuelQuantity, literPerKm);
    }

    @Override
    void driv(double drive) {
        if ((combineConsum * drive) > getFuelQuantity()) {
            System.out.println("Car needs refueling");
        } else {
            System.out.println("Car travelled " + new DecimalFormat("0.######").format(drive) + " km");
            setFuelQuantity(getFuelQuantity() - (combineConsum * drive));
        }
    }

    @Override
    void refuel(double refuel) {
        setFuelQuantity(getFuelQuantity() + refuel);
    }

}
