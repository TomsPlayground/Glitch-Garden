using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Attacker))]
public class Fox : MonoBehaviour
{

    Animator foxAnimator;
    Collider2D foxCollider;
    private Attacker attacker;

    public bool foxAttack = false;

    // Use this for initialization
    void Start()
    {
        foxAnimator = GetComponent<Animator>();
        attacker = GetComponent<Attacker>();
    }

    // Update is called once per frame
    void Update()
    {
        /* foxAttack = foxAnimator.GetBool("isAttacking");
        Debug.Log("called trigger: " + foxAttack); */
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        /* GameObject obj = collision.gameObject;
         if (!obj.GetComponent<Defender>())
         {
             return;
         }
         if (obj.GetComponent<Gravestone>())
         {
             foxAnimator.SetTrigger("JumpTrigger");
         } else
         {
             foxAnimator.SetBool("isAttacking", true);
             attacker.Attack(obj);
         }*/

        foxCollider = collision;
         if (collision.gameObject.name == "Gravestone")
         {
             foxAnimator.SetTrigger("JumpTrigger");
         }
         else if (collision.gameObject.name == "Zuccini")
         {
             foxAnimator.SetBool("isAttacking", false);
             Debug.Log("called trigger: " + foxAttack);
         }
         else if (collision.gameObject.name == "Axe")
         {
             foxAnimator.SetBool("isAttacking", false);
         }
         else if (collision == true)
         {
             foxAnimator.SetBool("isAttacking", true);
         }
         else
         {
             foxAnimator.SetBool("isAttacking", false);
         }
    }
}