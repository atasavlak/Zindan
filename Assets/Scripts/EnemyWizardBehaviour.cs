using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWizardBehaviour : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
       
    }

    private void EnemyTakeDmg(int dmg){
        GameManager.gamemanager._enemyWizardHealth.DmgUnit(dmg);
    }
    private void EnemyHeal(int heal){
        GameManager.gamemanager._enemyWizardHealth.HealUnit(heal);
    }
}
