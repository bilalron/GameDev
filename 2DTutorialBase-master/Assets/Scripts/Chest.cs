using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;


public class Chest : MonoBehaviour
{
    #region GameObject_variables
    [SerializeField]
    [Tooltip("health pack")]
    private GameObject healthpack;
    
    [SerializeField]
    [Tooltip("speed pack")]
    private GameObject speedpot;

    [SerializeField]
    [Tooltip("damage pack")]
    private GameObject dmgpot;
    #endregion

    #region Chest_functions

    IEnumerator DestroyChest(){
        yield return new WaitForSeconds(0.3f);
        Random random = new Random();
        int choice =  random.Next(3);
        Debug.Log(choice);
        if (choice == 0){

            Instantiate(healthpack, transform.position, transform.rotation);

        } else if (choice == 1){

            Instantiate(speedpot, transform.position, transform.rotation);

        } else {

            Instantiate(dmgpot, transform.position, transform.rotation);

        }
        Destroy(this.gameObject);
        
    }

    public void Interact(){
        StartCoroutine("DestroyChest");
    }

    #endregion
}
