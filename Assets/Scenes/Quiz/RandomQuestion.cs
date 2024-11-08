using UnityEngine;

public class RandomQuestion : MonoBehaviour
{
    public static string actualAnswer;
    public static bool DisplayQuestion = false;
    public int questionNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(DisplayQuestion == false)
            {
                questionNumber = Random.Range(1,5);
                if(questionNumber == 1)
                    {
                        DisplayQuestion = true;
                        QuestionGenerator.NewQuestion = "Cate cafele este Teo capabila sa bea?";
                        QuestionGenerator.newA = "A. Cateva(2-3)";
                        QuestionGenerator.newB = "B. Niciuna";
                        QuestionGenerator.newC = "C. Multe(4-5)";
                        QuestionGenerator.newD = "D. Foarte multe(6-7)";
                        actualAnswer = "A";
                    }
                if(questionNumber == 2)
                    {
                        DisplayQuestion = true;
                        QuestionGenerator.NewQuestion = "Ce mananca Bogdan";
                        QuestionGenerator.newA = "A. pufuleti";
                        QuestionGenerator.newB = "B. rachie";
                        QuestionGenerator.newC = "C. nimic";
                        QuestionGenerator.newD = "D. totul";
                        actualAnswer = "A";
                    }
                if(questionNumber == 3)
                    {
                        DisplayQuestion = true;
                        QuestionGenerator.NewQuestion = "Ce fac azi si maine si poimaine si raspoimaine?";
                        QuestionGenerator.newA = "A. nimic";
                        QuestionGenerator.newB = "B. tenis";
                        QuestionGenerator.newC = "C. skate";
                        QuestionGenerator.newD = "D. codez";
                        actualAnswer = "D";
                    }
                if(questionNumber == 4)
                    {
                        DisplayQuestion = true;
                        QuestionGenerator.NewQuestion = "Ce animal imi place sa mananc?";
                        QuestionGenerator.newA = "A. Pisica";
                        QuestionGenerator.newB = "B. Caine";
                        QuestionGenerator.newC = "C. Rata";
                        QuestionGenerator.newD = "D. Testoasa";
                        actualAnswer = "C";
                    }
            }
    }
}
