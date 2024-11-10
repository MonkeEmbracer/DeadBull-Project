using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CombatLogic : MonoBehaviour
{
    public static CombatLogic Instance;

    public CharacterCombat player;
    public CharacterCombat enemy;
    public GameObject nextToExplanation;
    public GameObject nextToAttack;
    public GameObject nextToEnemyTurn;
    public GameObject nextToPlayerTurn;
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
        explanation.GetComponent<TMP_Text>().text = damageString;
    }

    public void EnemyAttack()
    {
        enemy.Attack();

        nextToEnemyTurn.SetActive(false);
        nextToPlayerTurn.SetActive(true);

        string damageString = "Your opponent has struck for " + IntToString(enemy.damage) + " damage!";
        explanation.GetComponent<TMP_Text>().text = damageString;
    }

    public void BackToPlayerTurn()
    {
        nextToPlayerTurn.SetActive(false);
        gameObject.GetComponent<BoxManager>().Start();
    }
}
