using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meleeatack : MonoBehaviour
{
    public GameObject myObject;
    // vars
    Animator anim;


    private void Start()
    {
       anim = GetComponent<Animator>();
    }

    
    private void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            anim.SetBool("attacking", true);
            myObject.GetComponent<BoxCollider>().enabled=true;
        }
        else if(this.anim.GetCurrentAnimatorStateInfo(0).IsName("SwordAnimation")){
            myObject.GetComponent<BoxCollider>().enabled=true;
        }
        else{
            anim.SetBool("attacking", false);
            myObject.GetComponent<BoxCollider>().enabled=false;
        }
        



    }
}