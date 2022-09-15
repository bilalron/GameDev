using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePot : MonoBehaviour
{
    #region Damage_variables
    [SerializeField]
    [Tooltip("Extra damage the player does")]
    private int dmgAmount;
    #endregion

    #region dmg_functions
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.transform.CompareTag("Player")){
            collision.transform.GetComponent<PlayerController>().dmgBuff(dmgAmount);
            Destroy(this.gameObject);
        }
    }
    #endregion
}
