import java.util.Scanner;

public class App {
    static int[] Numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

    public static void main(String[] args) {
        Scanner reader = new Scanner(System.in);

        System.out.println("Enter a number: ");

        int number = Integer.parseInt(reader.nextLine());

        reader.close();

        System.out.println(lineare_serach(number));
        System.out.println(binary_search(number, 0, Numbers.length - 1));
    }

    private static String lineare_serach(int value) {
        for (int i = 0; i < Numbers.length; i++) {
            if (Numbers[i] == value) {
                return Numbers[i] + " is the number you are looking for and it is at index " + i;
            }
        }

        return "Number not found";
    }

    private static String binary_search(int value, int start, int end) {
        int middle = (start + end) / 2;
        
        if (start > end) {
            return "Number not found";
        }

        if (value == Numbers[middle]) {
            return Numbers[middle] + " is the number you are looking for and it is at index " + middle;
        }

        if (value < Numbers[middle]) {
            return binary_search(value, start, middle - 1);
        } else {
            return binary_search(value, middle + 1, end);
        }
    }
}
