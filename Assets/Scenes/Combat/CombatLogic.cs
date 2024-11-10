using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;


public class CombatLogic : MonoBehaviour
{
    public static CombatLogic Instance;

    public GameObject targetObject; // Asignează GameObject-ul în Inspector
    public float activeDuration = 2.0f;

    public CharacterCombat player;
    public CharacterCombat enemy;
    public GameObject nextToExplanation;
    public GameObject nextToAttack;
    public GameObject nextToEnemyTurn;
    public GameObject nextToPlayerTurn;
    public GameObject respawnButton;
    public GameObject explanation;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private string IntToString(int x)
    {
        string str1 = "", str2 = "";

        do
        {
            str2 += (char)(x % 10 + '0');
            str2 += str1;
            (str1, str2) = (str2, str1);
            str2 = "";
            x /= 10;
        }while (x > 0);

        return str1;
    }

    public void PlayerAttack()
    {
        player.Attack();

        nextToAttack.SetActive(false);
        nextToEnemyTurn.SetActive(true);

        

        string damageString = "You have dealt " + IntToString(player.damage) + " damage!";
        if (player.damage >= 24) // MUST change this later!!
            damageString += "\nKnowledge power!";
        explanation.GetComponent<TMP_Text>().text = damageString;
    }

    public void EnemyAttack()
    {
        if (enemy.HP <= 0)
        {   
            explanation.GetComponent<TMP_Text>().text = "You won! To be continued... ;)";
            nextToEnemyTurn.SetActive(false);
            //respawnButton.SetActive(true);
            return;
        }

        enemy.Attack();

        nextToEnemyTurn.SetActive(false);
        nextToPlayerTurn.SetActive(true);
        StartCoroutine(ActivateForSeconds());

        string damageString = "Your opponent has struck for " + IntToString(enemy.damage) + " damage!";
        explanation.GetComponent<TMP_Text>().text = damageString;
    }

    public void BackToPlayerTurn()
    {
        if (player.HP <= 0)
        {
            explanation.GetComponent<TMP_Text>().text = "You died!\n.";
            nextToPlayerTurn.SetActive(false);
            respawnButton.SetActive(true);
            return;
        }

        nextToPlayerTurn.SetActive(false);
        gameObject.GetComponent<BoxManager>().Start();
    }

    public void Respawn()
    {
        SceneManager.LoadScene(1);
    }

    public IEnumerator ActivateForSeconds()
    {
        targetObject.SetActive(true); // Activează obiectul
        yield return new WaitForSeconds(activeDuration); // Așteaptă durata specificată
        targetObject.SetActive(false); // Dezactivează obiectul
    }
}
