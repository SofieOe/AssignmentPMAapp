using UnityEngine;

[CreateAssetMenu(fileName = "NewScriptableObjectScript", menuName = "Scriptable Objects/NewScriptableObjectScript")]
public class DodgerAttributes : ScriptableObject
{
    public int health;
    public int maxHealth;
    public int curscore;


    public DodgerAttributes (int currentHealth, int healthMaximum, int currentScore)
    {
        health = currentHealth;
        maxHealth = healthMaximum;
        curscore = currentScore;

    }

    public int GetTheHealth()
    {
        return health;
    }

    public int GetTheMaxHealth(int v)
    {
        return maxHealth;
    }

    public int GetTheScore()
    {
        return curscore;
    }

    public void SetTheHealth(int newHealth)
    {
        health = newHealth;
    }

    public void SetTheScore(int newScore)
    {
        curscore = newScore;
    }

    

}
