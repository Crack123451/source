public class Quiz {

    public static void main(String[] args){
        int value=0;
        int bitIndex=1;
        int itog=0;
        char[] binaryValue = (Integer.toBinaryString(value)).toCharArray();
        if (binaryValue[bitIndex-1]=='1') binaryValue[bitIndex-1]='0';
        else binaryValue[bitIndex-1]='1';
        for (int i=0;i<binaryValue.length;i++) {
            itog += Character.getNumericValue(binaryValue[i]) * (int) Math.pow(2, i);
        }
        System.out.println(itog);
        //return itog; // put your implementation here
        }
}

