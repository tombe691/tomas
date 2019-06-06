/**
 * <h1>Main class</h1>
 * This class run a question game.
 * <p>
 * A menu with chocies to run, add, print.
 *
 *
 * @author  Tomas Berggren
 * @version 1.0
 */
import java.util.Random;
import java.util.Scanner;

public class Main {
    public static int ReadIntInput(String text, int[] correct) {
        int number = 0;
        boolean correctInput = false;

        while (!correctInput) {
            // Create a Scanner object
            Scanner myObj = new Scanner(System.in);
            System.out.print("Valj " + text + " :");
            if (myObj.hasNext()) {
                if (myObj.hasNextInt()) {
                    // Read user input
                    number = myObj.nextInt();
                } else {
                    // Output user input
                    System.out.println("Tal " + text + " ar inte ett tal, du matade in: " + myObj.nextLine());
                }
            } else {
                // Output user input
                System.out.println("Felaktig inmatning, returnerar 0");

            }
            //check correct answers
            for (int i = 0; i<correct.length;i++) {
                if (number==correct[i]){
                    correctInput = true;
                    break;
                }
            }
            if (!correctInput){
                System.out.println("Ogiltigt svar! Forsok igen!");
            }
        }
        return number;
    }

    public static String ReadStringInput(String text) {
        String input = "";
        // Create a Scanner object
        Scanner myObj = new Scanner(System.in);
        System.out.print(text);
        if (myObj.hasNext()) {
            if (myObj.hasNextLine()) {
                // Read user input
                input = myObj.nextLine();
            } else {
                // Output user input
                System.out.println("Inmatningen for " + text + " ar inte text, du matade in: " + myObj.nextLine());
            }
        } else {
            // Output user input
            System.out.println("Felaktig inmatning, returnerar tom strang");
        }
        return input;
    }


    public static void main(String[] args) {
        //System.out.println("Hello World!");
        QuestionList game1 = new QuestionList("testgame", "nisse");
        game1.addQuestion("Hur manga dagar ar det pa en vecka?", "3", "10", "5",
                "7", 4);
        game1.addQuestion("Vad blir blatt och gult", "rott", "vitt", "gront",
                "lila", 3);

        //create a random object
        Random rand = new Random();
        boolean isRunning = true;
        while (isRunning) {
            //printout menu
            System.out.println("Hej och valkommen till min fragesport!");
            System.out.println("1. Spela fragesport");
            System.out.println("2. Lagg till fraga");
            System.out.println("3. Visa alla fragor och svar");
            System.out.println("4. Visa antal olika fragor just nu");
            System.out.println("5. Avsluta");
            int[] correctInput = new int[5];
            correctInput[0] = 1;
            correctInput[1] = 2;
            correctInput[2] = 3;
            correctInput[3] = 4;
            correctInput[4] = 5;
            int[] correctQuestionInput = new int[5];
            correctQuestionInput[0] = 1;
            correctQuestionInput[1] = 2;
            correctQuestionInput[2] = 3;
            correctQuestionInput[3] = 4;

            int choice = ReadIntInput(" ett alternativ", correctInput);
            switch (choice) {
                case 1:
                    
                    
                    int points = 0;
                    for (int i = 0; i < 3; i++) {
                        int n = rand.nextInt(game1.countQuestions());
                        int correct = game1.drawQuestion(n);
                        int answer = ReadIntInput(" en siffra", correctQuestionInput);
                        System.out.format("--------------------------------\n");
                        System.out.format("Ditt svar: %d\n", answer);
                        System.out.format("--------------------------------\n");


                        if (answer == correct) {
                            points++;
                            System.out.println("Korrekt! Dina poang: " + points);
                        } else {
                            System.out.println("Fel svar. Antal poang: " + points);
                        }
                    }
                    break;
                case 2:
                    String question = ReadStringInput("Skriv en fraga");
                    String answer1 = ReadStringInput("Skriv svar 1");
                    String answer2 = ReadStringInput("Skriv svar 2");
                    String answer3 = ReadStringInput("Skriv svar 3");
                    String answer4 = ReadStringInput("Skriv svar 4");
                    int correct = ReadIntInput("Skriv numret pa det ratta svaret", correctQuestionInput);

                    game1.addQuestion(question, answer1, answer2, answer3, answer4, correct);
                    break;
                case 3:
                    game1.printQuestions();
                    break;
                case 4:
                    System.out.println("total " + game1.countQuestions());
                    break;
                case 5:
                    isRunning = false;
                    break;
                default:
                    // simple default error handling
                    System.out.println("felaktigt val, forsok igen ");
                    break;
            }
        }
   }
}
