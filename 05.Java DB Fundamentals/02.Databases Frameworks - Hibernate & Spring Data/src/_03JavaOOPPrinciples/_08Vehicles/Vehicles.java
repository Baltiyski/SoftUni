package _03JavaOOPPrinciples._08Vehicles;

/**
 * Created by StefanBaltiyski on 16.7.2017 г..
 */
public abstract class Vehicles {
    private double fuelQuantity;
    private double literPerKm;

    protected Vehicles(double fuelQuantity, double literPerKm) {
        this.setFuelQuantity(fuelQuantity);
        this.setLiterPerKm(literPerKm);
    }

    abstract void driv(double drive);
    abstract void refuel(double refuel);

    public double getFuelQuantity() {
        return this.fuelQuantity;
    }

    protected void setFuelQuantity(double fuelQuantity) {
        this.fuelQuantity = fuelQuantity;
    }

    public double getLiterPerKm() {
        return this.literPerKm;
    }

    private void setLiterPerKm(double literPerKm) {
        this.literPerKm = literPerKm;
    }
}
