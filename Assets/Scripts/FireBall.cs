using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public float lifetime = 5f; 
     void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.name=="Player"){
            PlayerTakeDmg(10);
            Debug.Log(GameManager.gamemanager._playerHealth.Health);
            Destroy(gameObject);
        }
        void PlayerTakeDmg(int dmg){
        GameManager.gamemanager._playerHealth.DmgUnit(dmg);
    }

    }
}
