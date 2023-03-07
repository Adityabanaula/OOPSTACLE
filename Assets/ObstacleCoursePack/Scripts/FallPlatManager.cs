using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlatManager : MonoBehaviour
{
    public static FallPlatManager Instance = null;
    [SerializeField] private GameObject fallPlatPrefab;

    private void Awake(){

        if(Instance == null){
            Instance = this;
        }else if(Instance != this){
            Destroy(gameObject);
        }

    }

    IEnumerator RespawnFallPlat(Vector3 position){

        yield return new WaitForSeconds(3f); 
        Instantiate(fallPlatPrefab, position, Quaternion.identity);

    }

}
