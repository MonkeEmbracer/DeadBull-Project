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

    public int minDamage;
    public int maxDamage;
    public int damage;

    public bool correctAnswer;

    public Slider hpBar;
    public GameObject hpText;
    //public Slider manaBar;

    public bool isPlayer;

    public float fallSpeed; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = maxHP = 0;
        hpBar.maxValue = hpBar.value = maxHP;
        
        mana = maxMana;
        //manaBar.maxValue = manaBar.value = maxMana;
        
        correctAnswer = false;

        hpText.GetComponent<TMP_Text>().text = IntToString(HP) + "/" + IntToString(maxHP);
    }

    // Update is called once per frame
    void Update()
    {
        if (HP == 0)
            DieAnimation();
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
        }
        else if (HP >= maxHP)
            HP = maxHP;

        hpBar.value = HP;

        hpText.GetComponent<TMP_Text>().text = IntToString(HP) + "/" + IntToString(maxHP);
    }

    public void Attack()
    {
        damage = Random.Range(minDamage, maxDamage);

        if (correctAnswer == true)
        {
            correctAnswer = false;
            damage *= 3;
        }

        enemy.TakeDamage(damage);
    }

    public void DieAnimation()
    {
        Vector3 pos = gameObject.transform.position;
        pos.y += fallSpeed;
        gameObject.transform.position = pos;
        //gameObject.transform.position += (0, fallSpeed);
        //Transform transform.position 
    }
}
