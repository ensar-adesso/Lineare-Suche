import java.util.Scanner;

public class App {
    static int[] Numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

    public static void main(String[] args) {
        Scanner reader = new Scanner(System.in);

        System.out.println("Enter a number: ");

        int number = Integer.parseInt(reader.nextLine());

        reader.close();

        System.out.println(search(number));
    }

    private static String search(int number) {
        for (int i = 0; i < Numbers.length; i++) {
            if (Numbers[i] == number) {
                return Numbers[i] + " is the number you are looking for";
            }
        }

        return "Number not found";
    }
}
