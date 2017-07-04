package _01JavaBasicExercises;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

/**
 * Created by stefa on 4.7.2017 г..
 */
public class URLParser {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String url = reader.readLine();
        String protocol = "";
        String resource = "";

        int protocolIndex = url.indexOf("://");
        if (protocolIndex != -1) {
            protocol = url.substring(0,protocolIndex);
            url = url.substring(protocolIndex + 3);
        }

        int resourceIndex = url.indexOf("/");
        if (resourceIndex != -1) {
            resource = url.substring(resourceIndex + 1);
            url = url.substring(0, resourceIndex);
        }

        System.out.printf("[protocol] = \"%s\"%n", protocol);
        System.out.printf("[server] = \"%s\"%n", url);
        System.out.printf("[resource] = \"%s\"%n", resource);
    }
}
