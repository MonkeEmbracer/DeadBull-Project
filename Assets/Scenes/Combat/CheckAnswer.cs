using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CheckAnswer : MonoBehaviour
{
    public GameObject animatie;
    public float activeDuration = 2.0f;

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

    public GameObject wrong;
    public GameObject correct;

    public bool answered;

    public CharacterCombat player;

    void Start()
    {
        answered = false;
        wrong = wrongA;
        correct = correctA;
    }

    void Update()
    {

    }

    public void Check(string selectedOption)
    {
        if (answered == true)
            return;

        answered = true;
        gameObject.GetComponent<BoxManager>().nextToExplanation.SetActive(true);

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

            player.correctAnswer = false;
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

            player.correctAnswer = true;
             StartCoroutine(ActivateForSeconds());
        }
    }

    private IEnumerator ActivateForSeconds()
    {
        animatie.SetActive(true);
        yield return new WaitForSeconds(activeDuration);
        animatie.SetActive(false);

    }
}
