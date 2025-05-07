using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {

    }

    private void PlayerTakeDmg(int dmg){
        GameManager.gamemanager._playerHealth.DmgUnit(dmg);
    }
    private void PlayerHeal(int heal){
        GameManager.gamemanager._playerHealth.HealUnit(heal);
    }
}
