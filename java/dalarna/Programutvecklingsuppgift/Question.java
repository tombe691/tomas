/**
 * <h1>Question class</h1>
 * This class create a question object.
 * <p>
 * A question object has questions, 4 answers and an int for correct.
 *
 *
 * @author  Tomas Berggren
 * @version 1.0
 * @since   2019-06-01
 */
public class Question {
    String question;
    String answer1;
    String answer2;
    String answer3;
    String answer4;
    int correct;

    public Question(String question,
                    String Answer1,
                    String Answer2,
                    String Answer3,
                    String Answer4,
                    int correct) {
        this.question = question;
        this.answer1 = Answer1;
        this.answer2 = Answer2;
        this.answer3 = Answer3;
        this.answer4 = Answer4;
        this.correct = correct;
    }
}
