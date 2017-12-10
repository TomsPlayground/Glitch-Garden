using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour {

    Animator lizardAnimator;
    Collider2D lizardCollider;

    private bool lizardAttack = false;
    

    // Use this for initialization
    void Start () {
        lizardAnimator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        lizardAttack = lizardAnimator.GetBool("isAttacking");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        lizardCollider = collision;
        if (collision.gameObject.name == "Zuccini")
        {
            lizardAnimator.SetBool("isAttacking", false);
        }
        else if (collision.gameObject.name == "Axe")
        {
            lizardAnimator.SetBool("isAttacking", false);
        }
        else if (collision == true)
        {
            lizardAnimator.SetBool("isAttacking", true);
        } else
        {
            lizardAnimator.SetBool("isAttacking", false);
        }
    }

}
