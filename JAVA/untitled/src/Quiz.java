import java.lang.reflect.Array;
import java.math.BigInteger;
import java.util.Arrays;

public class Quiz {

    public static void main(String[] args) {
        int[]a1=new int[]{0, 2, 2};
        int[]a2=new int[]{1, 3};
        int[]a3=new int[a1.length+a2.length];
        int i=0, j=0;
        for (int k=0; k<a3.length; k++) {
            if (i > a1.length - 1) {
                int a = a2[j];
                a3[k] = a;
                j++;
            } else if (j > a2.length - 1) {
                int a = a1[i];
                a3[k] = a;
                i++;
            } else if (a1[i] < a2[j]) {
                int a = a1[i];
                a3[k] = a;
                i++;
            } else {
                int b = a2[j];
                a3[k] = b;
                j++;
            }
        }
        System.out.println(Arrays.toString(a3));
    }
}

