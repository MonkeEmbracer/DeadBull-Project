using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuestionGenerator : MonoBehaviour
{
    //public static QuestionGenerator Instance;

    public TMP_Text screenQuestion;
    public GameObject AnswerA;
    public GameObject AnswerB;
    public GameObject AnswerC;
    public GameObject AnswerD;

    public string NewQuestion = "";
    string newA = "";
    string newB = "";
    string newC = "";
    string newD = "";

    string actualAnswer;
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
        
    }

    public void GenerateQuestion()
    {
        RandomQuestion();
        ReplaceQuestion();
    }
    
    public void RandomQuestion()
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

        NewQuestion = lines[questionLine];
        newA = "A. " + questionOptions[0];
        newB = "B. " + questionOptions[1];
        newC = "C. " + questionOptions[2];
        newD = "D. " + questionOptions[3];
        actualAnswer = "";
        char indexChar = 'A';
        indexChar += (char)answerIndex;
        actualAnswer += indexChar;
    }

    public void ReplaceQuestion()
    {
        screenQuestion.GetComponent<TMP_Text>().text = NewQuestion;
        AnswerA.GetComponent<TMP_Text>().text = newA;
        AnswerB.GetComponent<TMP_Text>().text = newB;
        AnswerC.GetComponent<TMP_Text>().text = newC;
        AnswerD.GetComponent<TMP_Text>().text = newD;
    }

    public void CheckAnswer(string chosenAnswer)
    {

    }
}
