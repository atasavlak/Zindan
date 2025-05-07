using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyDamageSkeleton : MonoBehaviour
{
    int x=0; 
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Melee")
            x++;
        if (x==3)
            Destroy(gameObject);
    }
}