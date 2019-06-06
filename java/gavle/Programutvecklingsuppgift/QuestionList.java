/**
 * <h1>Question class</h1>
 * This class create a questionlist object.
 * <p>
 * class to create game and add questions,
 * only first game is implemented for the moment
 *A question object has questions, 4 answers and an int for correct.
 * @author  Tomas Berggren
 * @version 1.0
 * @since   2019-06-01
 */
import java.util.ArrayList;
public class QuestionList {

    private String gameName;
    private String creator;
    private ArrayList<Question> questionList = new ArrayList<Question>();

    //constructor
    public QuestionList(String gameName,
                        String creator) {
        this.gameName = gameName;
        this.creator = creator;
    }

    //method to add question
    public void addQuestion(String questionText,
                            String answer1,
                            String answer2,
                            String answer3,
                            String answer4,
                            int correct) {
        Question question = new Question(questionText, answer1, answer2, answer3, answer4, correct);
        // Lagg till raden till listan
        questionList.add(question);
    }

    //method to print all questions
    public void printQuestions() {
        for (Question line : questionList) {
            System.out.println(line.question + " " + line.answer1 + " " +
                    line.answer2 + " " + line.answer3 + " Correct:" + line.correct);
        }
    }

    //method to count number of questions
    public int countQuestions() {
        return questionList.size();
    }

    //method to print game info
    public void printGame() {
        System.out.println(this.gameName + " " + this.creator);
    }

    //method to print out question and return correct number
    public int drawQuestion(int nr) {
        System.out.println(questionList.get(nr).question + "?");
        System.out.println("1. " + questionList.get(nr).answer1);
        System.out.println("2. " + questionList.get(nr).answer2);
        System.out.println("3. " + questionList.get(nr).answer3);
        System.out.println("4. " + questionList.get(nr).answer4);
        return questionList.get(nr).correct;
    }
}