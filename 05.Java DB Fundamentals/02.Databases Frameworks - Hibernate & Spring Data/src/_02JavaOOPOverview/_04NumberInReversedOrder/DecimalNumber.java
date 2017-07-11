package _02JavaOOPOverview._04NumberInReversedOrder;

/**
 * Created by StefanBaltiyski on 6.7.2017 г..
 */
public class DecimalNumber {
    private double number;

    public DecimalNumber() {

    }

    public void reverNum (double number) {
        String st = String.valueOf(number);

        String[] divid = st.split("\\.");
        int beforDot = Integer.parseInt(divid[0]);
        int afterDot = Integer.parseInt(divid[1]);
        String st1 = "";
        String st2 = "";
        String combine = "";

        if(afterDot <= 0) {
            st1 = String.valueOf(revers(beforDot));
            combine = st1;
            int dv = Integer.parseInt(combine);
            System.out.println(dv);
        } else {
            st1 = String.valueOf(revers(beforDot));
            st2 = String.valueOf(revers(afterDot));
            combine = st2.concat(".").concat(st1);
            double rev = Double.parseDouble(combine);
            System.out.println(rev);
        }
    }

    private int revers(int number) {
        int  mod;
        int sum = 0;

        while (number != 0) {
            mod = number % 10;
            sum = sum * 10 + mod;

            number /= 10;
        }

        return sum;
    }
}
