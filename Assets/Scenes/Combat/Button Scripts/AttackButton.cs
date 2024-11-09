using UnityEngine;

public class AttackButton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Mrege");
        BoxManager.Instance.EnterQuiz();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
