package _03JavaOOPPrinciples._08Vehicles;

import java.text.DecimalFormat;

/**
 * Created by StefanBaltiyski on 16.7.2017 г..
 */
public class Truck extends Vehicles{
    private static final double airconditionConsum = 1.6;
    private double combineConsum = airconditionConsum + getLiterPerKm();

    public Truck(double fuelQuantity, double literPerKm) {
        super(fuelQuantity, literPerKm);
    }

    @Override
    void driv(double drive) {
        if ((combineConsum * drive) > getFuelQuantity()) {
            System.out.println("Truck needs refueling");
        } else {
            System.out.println("Truck travelled " + new DecimalFormat("0.######").format(drive) + " km");
            setFuelQuantity(getFuelQuantity() - (combineConsum * drive));
        }
    }

    @Override
    void refuel(double refuel) {
        setFuelQuantity(getFuelQuantity() + (refuel * 0.95));
    }
}
