using UnityEngine;
using UnityEngine.UI;
public class WorkingButtons : MonoBehaviour
{
    public GameObject answerAbackBlue;
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
