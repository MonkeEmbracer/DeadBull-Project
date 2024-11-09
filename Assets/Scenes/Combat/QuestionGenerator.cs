using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class QuestionGenerator : MonoBehaviour
{
    public static QuestionGenerator Instance;

    public GameObject screenQuestion;
    public GameObject AnswerA;
    public GameObject AnswerB;
    public GameObject AnswerC;
    public GameObject AnswerD;
    public static string NewQuestion = "";
    public static string newA = "";
    public static string newB = "";
    public static string newC = "";
    public static string newD = "";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartQuiz()
    {
        StartCoroutine(PushTextOnScreen());
    }

    IEnumerator PushTextOnScreen()
    {
        yield return new WaitForSeconds(0.25f);
        screenQuestion.GetComponent<Text>().text = NewQuestion;
        AnswerA.GetComponent<Text>().text = newA;
        AnswerB.GetComponent<Text>().text = newB;
        AnswerC.GetComponent<Text>().text = newC;
        AnswerD.GetComponent<Text>().text = newD;
    }
}
