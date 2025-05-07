using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Player"){
            PlayerTakeDmg(10);
            Debug.Log(GameManager.gamemanager._playerHealth.Health);
        }
        void PlayerTakeDmg(int dmg){
        GameManager.gamemanager._playerHealth.DmgUnit(dmg);
    }

    }
}
