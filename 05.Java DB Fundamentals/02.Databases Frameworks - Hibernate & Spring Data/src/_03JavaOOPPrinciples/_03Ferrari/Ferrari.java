package _03JavaOOPPrinciples._03Ferrari;

/**
 * Created by StefanBaltiyski on 12.7.2017 г..
 */
public class Ferrari implements Car {
    private static final String model = "488-Spider" ;
    private String driver;

    public Ferrari(String driver) {
        this.setDriver(driver);
    }

    @Override
    public String breakPedal() {
        return "Brakes!";
    }

    @Override
    public String gasPedal() {
        return "Zadu6avam sA!";
    }

    public String getModel() {
        return model;
    }

    private String getDriver() {
        return driver;
    }

    private void setDriver(String driver) {
        this.driver = driver;
    }

    @Override
    public String toString() {
        return String.format("%s/%s/%s/%s\n",this.getModel(),breakPedal(),gasPedal(),this.getDriver());
    }
}
