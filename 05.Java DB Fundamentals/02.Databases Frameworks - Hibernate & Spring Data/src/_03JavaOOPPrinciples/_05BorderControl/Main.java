package _03JavaOOPPrinciples._05BorderControl;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;

/**
 * Created by StefanBaltiyski on 15.7.2017 г..
 */
public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        ArrayList<Identification> allIds = new ArrayList<>();

        while(true) {
            String[] enterIds = reader.readLine().split("\\s");
            if("End".equals(enterIds[0])) {
                break;
            }

            Identification allId = null;
            switch (enterIds.length){
                case 2:
                    allId = new Robot(enterIds[0], enterIds[1]);
                    break;
                case 3:
                    allId = new Human(enterIds[0], Integer.parseInt(enterIds[1]), enterIds[2]);
                    break;
                default:
                    break;
            }
            allIds.add(allId);
        }

        String fakeIdCheck = reader.readLine();

        allIds.stream().filter(al -> al.isFake(fakeIdCheck)).forEach(al -> {
            System.out.println(al.getId());
        });

    }
}
