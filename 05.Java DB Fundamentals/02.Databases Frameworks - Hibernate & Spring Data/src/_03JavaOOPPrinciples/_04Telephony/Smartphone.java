package _03JavaOOPPrinciples._04Telephony;

/**
 * Created by StefanBaltiyski on 12.7.2017 г..
 */
public class Smartphone implements Call, Browes {


    public Smartphone() {
    }

    @Override
    public String call(String number) {
        for (char digit : number.toCharArray()) {
            if (!Character.isDigit(digit)){
                return "Invalid number!";
            }
        }
        return String.format("Calling... " + number);
    }

    @Override
    public String browse(String url) {
        for (char digit : url.toCharArray()) {
            if (Character.isDigit(digit)){
                return "Invalid URL!";
            }
        }
        return String.format("Browsing: " + url + "!");
    }
}
