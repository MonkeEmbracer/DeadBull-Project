using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharacterCombat : MonoBehaviour
{
    public CharacterCombat enemy;

    public int maxHP;
    public int maxMana;

    public int HP;
    public int mana;

    public Slider hpBar;
    public GameObject hpText;
    //public Slider manaBar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = maxHP;
        hpBar.maxValue = hpBar.value = maxHP;
        
        mana = maxMana;
        //manaBar.maxValue = manaBar.value = maxMana;
<<<<<<< Updated upstream
=======
        
        correctAnswer = false;

        hpText.GetComponent<TMP_Text>().text = IntToString(HP) + "/" + IntToString(maxHP);
>>>>>>> Stashed changes
    }

    // Update is called once per frame
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

    public void TakeDamage(int damage)
    {
        HP -= damage;
        if (HP < 0)
        {
            HP = 0;
            Die();
        }
        else if (HP >= maxHP)
            HP = maxHP;

        hpBar.value = HP;
        
        hpText.GetComponent<TMP_Text>().text = IntToString(HP) + "/" + IntToString(maxHP);
    }

    public void Attack()
    {
        //TakeDamage(15);
        enemy.TakeDamage(15);
    }

    public void Die()
    {

    }
}
