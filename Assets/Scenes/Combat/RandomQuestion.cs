using UnityEngine;

public class RandomQuestion : MonoBehaviour
{
    public static string actualAnswer;
    public static bool DisplayQuestion = false;
    public int questionNumber;
    public TextAsset textFile;

    private int numberOfQuestions;
    private string[] lines;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lines = textFile.text.Split('\n');
        numberOfQuestions = (lines.Length - 5) / 6;
    }

    // Update is called once per frame
    void Update()
    {
        if(DisplayQuestion == true)
            {
                questionNumber = Random.Range(1, numberOfQuestions);
                int questionLine = questionNumber * 6;
                string[] questionOptions = new string[4];
                int answerIndex = 0;

                for (int i = 0; i < 4; i++)
                    questionOptions[i] = lines[questionLine + i + 1];

                for (int t = 0; t < questionOptions.Length; t++ )
                {
                    string tmp = questionOptions[t];
                    int r = Random.Range(t, questionOptions.Length);
                    questionOptions[t] = questionOptions[r];
                    questionOptions[r] = tmp;
                }
                
                for (int i = 0; i < 4; i++)
                    if (questionOptions[i] == lines[questionLine + 1])
                        answerIndex = i;

                //DisplayQuestion = true;
                QuestionGenerator.NewQuestion = lines[questionLine];
                QuestionGenerator.newA = "A. " + questionOptions[0];
                QuestionGenerator.newB = "B. " + questionOptions[1];
                QuestionGenerator.newC = "C. " + questionOptions[2];
                QuestionGenerator.newD = "D. " + questionOptions[3];
                actualAnswer = "";
                char indexChar = 'A';
                indexChar += (char)answerIndex;
                actualAnswer += indexChar;
            }
    }
}
