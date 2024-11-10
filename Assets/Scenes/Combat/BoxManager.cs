using UnityEngine;
using UnityEngine.UI;

public class BoxManager : MonoBehaviour
{
    //public static BoxManager Instance;

    public GameObject combatBox;
    public GameObject quizBox;

    public GameObject attackButton;
    public GameObject abilityButton;
    public GameObject itemButton;
    
    public GameObject quizCanvas1;
    public GameObject quizCanvas2;
    public GameObject nextToExplanation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        combatBox.SetActive(true);
        quizBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitiateAttack()
    {
        EnterQuiz();
    }

    public void EnterQuiz()
    {
        combatBox.SetActive(false);
        quizBox.SetActive(true);
        quizCanvas1.SetActive(true);
        quizCanvas2.SetActive(false);
        nextToExplanation.SetActive(false);
    }

    public void ShowExplanation()
    {
        quizCanvas1.SetActive(false);
        quizCanvas2.SetActive(true);
    }
}
