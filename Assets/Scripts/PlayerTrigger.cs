using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="EnemySkeleton"){
            EnemySkeletonTakeDmg(10);
            Debug.Log(GameManager.gamemanager._enemySkeletonHealth.Health);
        }
        else if(other.gameObject.tag=="EnemyWizard"){
            EnemyWizardTakeDmg(10);
            Debug.Log(GameManager.gamemanager._enemyWizardHealth.Health);
            }
        }
        void EnemySkeletonTakeDmg(int dmg){
            GameManager.gamemanager._enemySkeletonHealth.DmgUnit(dmg);
    }
        void EnemyWizardTakeDmg(int dmg){
            GameManager.gamemanager._enemyWizardHealth.DmgUnit(dmg);
    }
}

