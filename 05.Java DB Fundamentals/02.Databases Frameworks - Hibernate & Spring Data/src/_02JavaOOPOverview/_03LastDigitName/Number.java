package _02JavaOOPOverview._03LastDigitName;

/**
 * Created by StefanBaltiyski on 6.7.2017 г..
 */
public class Number {
    private static final int LASTDIGIT = 10;
    private int number ;

    public Number(int number) {
        this.number = number;
    }

    public String getNameForLastDigit() {
        this.number  = this.number % LASTDIGIT;
        String lastDigitname = "";
        switch (number){
            case 0:
                lastDigitname = "zero";
                break;
            case 1:
                lastDigitname = "one";
                break;
            case 2:
                lastDigitname = "two";
                break;
            case 3:
                lastDigitname = "three";
                break;
            case 4:
                lastDigitname = "four";
                break;
            case 5:
                lastDigitname = "five";
                break;
            case 6:
                lastDigitname = "six";
                break;
            case 7:
                lastDigitname = "seven";
                break;
            case 8:
                lastDigitname = "eight";
                break;
            case 9:
                lastDigitname = "nine";
                break;
            default:
                break;
        }
        return lastDigitname;
    }

}
