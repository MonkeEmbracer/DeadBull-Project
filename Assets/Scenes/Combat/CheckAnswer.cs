using UnityEngine;
using UnityEngine.UI;

public class CheckAnswer : MonoBehaviour
{
    //public GameObject selectedButton;
    private GameObject wrong;
    private GameObject correct;

    public GameObject optionA;
    public GameObject optionB;
    public GameObject optionC;
    public GameObject optionD;

    public GameObject wrongA;
    public GameObject wrongB;
    public GameObject wrongC;
    public GameObject wrongD;

    public GameObject correctA;
    public GameObject correctB;
    public GameObject correctC;
    public GameObject correctD;

    private BoxManager boxManager;

    void Start()
    {
        //wrong = transform.GetChild(0).gameObject;
        //wrong.SetActive(true);
    }

    void Update()
    {

    }

    public void Check(string selectedOption)
    {
        
        GameObject currentOption;
        if (selectedOption == "A")
            currentOption = optionA;
        else if (selectedOption == "B")
            currentOption = optionB;
        else if (selectedOption == "C")
            currentOption = optionC;
        else if (selectedOption == "D")
            currentOption = optionD;

        if (QuestionGenerator.actualAnswer != selectedOption)
        {
            if (selectedOption == "A")
                wrong = wrongA;
            else if (selectedOption == "B")
                wrong = wrongB;
            else if (selectedOption == "C")
                wrong = wrongC;
            else if (selectedOption == "D")
                wrong = wrongD;

            wrong.SetActive(true);
        }
        else
        {
            if (selectedOption == "A")
                correct = correctA;
            else if (selectedOption == "B")
                correct = correctB;
            else if (selectedOption == "C")
                correct = correctC;
            else if (selectedOption == "D")
                correct = correctD;

            correct.SetActive(true);
        }

        //boxManager = GetComponent<BoxManager>();  
        //boxManager.ShowExplanation();
    }

    /*public GameObject answerAbackBlue;
    public GameObject answerAbackGreen;
    public GameObject answerAbackRed;
    public GameObject answerBbackBlue;
    public GameObject answerBbackGreen;
    public GameObject answerBbackRed;
    public GameObject answerCbackBlue;
    public GameObject answerCbackGreen;
    public GameObject answerCbackRed;
    public GameObject answerDbackBlue;
    public GameObject answerDbackGreen;
    public GameObject answerDbackRed;
    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void AnswerA(){
       
        if(RandomQuestion.actualAnswer == "A")
            {
                answerAbackGreen.SetActive(true);
                answerAbackBlue.SetActive(false);
            }
        else
            {
                answerAbackRed.SetActive(true);
                answerAbackBlue.SetActive(false);
            }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
    }
    public void AnswerB(){
       
        if(RandomQuestion.actualAnswer == "B")
            {
                answerBbackGreen.SetActive(true);
                answerBbackBlue.SetActive(false);
            }
        else
            {
                answerBbackRed.SetActive(true);
                answerBbackBlue.SetActive(false);
            }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
    }
    public void AnswerC(){
       
        if(RandomQuestion.actualAnswer == "C")
            {
                answerCbackGreen.SetActive(true);
                answerCbackBlue.SetActive(false);
            }
        else
            {
                answerCbackRed.SetActive(true);
                answerCbackBlue.SetActive(false);
            }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
    }
    public void AnswerD(){
       
        if(RandomQuestion.actualAnswer == "D")
            {
                answerDbackGreen.SetActive(true);
                answerDbackBlue.SetActive(false);
            }
        else
            {
                answerDbackRed.SetActive(true);
                answerDbackBlue.SetActive(false);
            }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
    }
    /*
        public void AnswerB(){
        if(RandomQuestion.actualAnswer == "B"){
            answerBbackGreen.SetActive(true);
            answerBbackBlue.SetActive(false);
        }
        else{
            answerBbackRed.SetActive(true);
            answerBbackBlue.SetActive(false);
        }
    }
    */
}
