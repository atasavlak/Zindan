using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrigger : MonoBehaviour
{

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.name=="Player"){
            PlayerHeal(100);
            Debug.Log(GameManager.gamemanager._playerHealth.Health);
        }
        void PlayerHeal(int dmg){
        GameManager.gamemanager._playerHealth.HealUnit(dmg);
    }

    }
}
