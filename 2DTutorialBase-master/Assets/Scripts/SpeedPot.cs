using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPot : MonoBehaviour
{
    #region Speed_variables
    [SerializeField]
    [Tooltip("The amount of speed a player gains")]
    private int speedAmount;
    #endregion

    #region speed_functions
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.transform.CompareTag("Player")){
            collision.transform.GetComponent<PlayerController>().speedBuff(speedAmount);
            Destroy(this.gameObject);
        }
    }
    #endregion
    
}
