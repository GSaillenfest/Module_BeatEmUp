using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEnemies : MonoBehaviour
{
    //public GameObject record;
    //public GameObject tape;
    public float healthinit;
    public Animator victim;

    public bool isAttacking;
    bool simpleCombo;
    bool superAttack;
    public float health;

    private void Awake()

    {
        health = healthinit;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        isAttacking = victim.GetBool("isAttacking");
        Debug.Log(health);
    }


    public void Hit(bool simpleCombo, bool superAttack)
    {
        Debug.Log("HIT is called");
        if (!simpleCombo && !superAttack)
        {
            if (health > (healthinit / 2) && !isAttacking)
            {
                health -= 7.5f;
                victim.SetTrigger("Hurt");
            }

            else if (health <= (healthinit / 2) && health > (healthinit / 6) && !isAttacking)
            {
                health -= 7.5f;

                if (health > 0 && health >= (healthinit / 4))
                {
                    victim.SetTrigger("Hurt");

                }
                else if (health > 0 && health <= (healthinit / 4))
                {
                    victim.SetTrigger("Hurt");
                    DropCollectibles();
                }
                else if (health <= 0)
                {
                    health = 0;
                    victim.SetBool("isDead", true);
                    DropCollectibles();
                }

            }
            else if (health <= (healthinit / 6) && !isAttacking)
            {
                health -= 7.5f;
                if (health > 0)
                {
                    victim.SetTrigger("Hurt");
                    DropCollectibles();
                }
                else if (health <= 0)
                {
                    health = 0;
                    victim.SetTrigger("Hurt");
                    victim.SetBool("isDead", true);
                    DropCollectibles();
                }
            }
        }


        if (simpleCombo)
        {
            if (health > (healthinit / 2) && !isAttacking)
            {
                health -= 20f;
                victim.SetTrigger("Hurt");
            }

            else if (health <= (healthinit / 2) && health > (healthinit / 6) && !isAttacking)
            {
                health -= 20f;

                if (health > 0 && health >= (healthinit / 4))
                {
                    victim.SetTrigger("Hurt");
                    DropCollectibles();
                }
                else if (health > 0 && health <= (healthinit / 4))
                {
                    victim.SetTrigger("Hurt");
                    DropCollectibles();
                }
                else if (health <= 0)
                {
                    health = 0;
                    victim.SetTrigger("Hurt");
                    victim.SetBool("isDead", true);
                    DropCollectibles();
                }

            }
            else if (health <= (healthinit / 6) && !isAttacking)
            {
                health -= 20f;
                if (health > 0)
                {
                    victim.SetTrigger("Hurt");
                    DropCollectibles();
                }
                else if (health <= 0)
                {
                    health = 0;
                    victim.SetTrigger("Hurt");
                    victim.SetBool("isDead", true);
                    DropCollectibles();
                }
            }
        }

        if (superAttack)
        {
            if (health > (healthinit / 2) && !isAttacking)
            {
                health -= 50f;
                victim.SetTrigger("Hurt");
            }

            else if (health <= (healthinit / 2) && health > (healthinit / 6) && !isAttacking)
            {
                health -= 50f;

                if (health > 0 && health >= (healthinit / 4))
                {
                    victim.SetTrigger("Hurt");
                    DropCollectibles();
                }
                else if (health > 0 && health <= (healthinit / 4))
                {
                    victim.SetTrigger("Hurt");
                    DropCollectibles();
                }
                else if (health <= 0)
                {
                    health = 0;
                    victim.SetTrigger("Hurt");
                    victim.SetBool("isDead", true);
                    DropCollectibles();
                }

            }
            else if (health <= (health / 6) && !isAttacking)
            {
                health -= 50f;
                if (health > 0)
                {
                    victim.SetTrigger("Hurt");
                    DropCollectibles();
                }
                else if (health <= 0)
                {
                    health = 0;
                    victim.SetTrigger("Hurt");
                    victim.SetBool("isDead", true);
                    DropCollectibles();
                }

            }
        }
    }


    public void DropCollectibles()
    {
        Debug.Log("Drops");
    }

}

