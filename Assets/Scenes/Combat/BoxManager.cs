using UnityEngine;

public class BoxManager : MonoBehaviour
{
    public static BoxManager Instance;

    public GameObject combatBox;
    public GameObject quizBox;

    public GameObject attackButton;
    public GameObject abilityButton;
    public GameObject itemButton;

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

        RandomQuestion.DisplayQuestion = true;
        QuestionGenerator.Instance.StartQuiz();
    }
}
