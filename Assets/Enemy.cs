using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    public int health;
    public int damage;
    int defense;

    void Start()
    {
        print("Hello, I'm " + name);
        //health -= damage;
       
    }

    // Update is called once per frame
    public void Attack(int damageParam)
    {
        health -= damageParam;
        print("Health left: " + health);
        if (health <= 0)
        {
            print(name + " I'm dead ");
        }

    }

     public int GetHealth()
    {
        return health;
    }
       
}
