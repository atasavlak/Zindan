using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySkeletonBehaviour : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
       
    }

    private void EnemyTakeDmg(int dmg){
        GameManager.gamemanager._enemySkeletonHealth.DmgUnit(dmg);
    }
    private void EnemyHeal(int heal){
        GameManager.gamemanager._enemySkeletonHealth.HealUnit(heal);
    }
}
