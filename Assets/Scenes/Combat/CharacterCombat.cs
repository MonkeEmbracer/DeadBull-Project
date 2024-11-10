using UnityEngine;
using UnityEngine.UI;

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
    //public Slider manaBar;

    public string type;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = maxHP;
        hpBar.maxValue = hpBar.value = maxHP;
        
        mana = maxMana;
        //manaBar.maxValue = manaBar.value = maxMana;
        
        correctAnswer = false;
    }

    // Update is called once per frame
    void Update()
    {

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

    public void Die()
    {

    }
}
