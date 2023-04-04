using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    
    public CharacterControls characterControls;

    public GameObject cameraHolder;

    public void IsLocalPLayer(){

        characterControls.enabled = true;
        cameraHolder.SetActive(true);

    }

}
