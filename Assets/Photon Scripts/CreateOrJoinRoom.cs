using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class CreateOrJoinRoom : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private TMP_InputField createField;
    [SerializeField]
    private TMP_InputField joinField;

    public void CreateRoom(){

        PhotonNetwork.CreateRoom(createField.text);

    }

    public void JoinRoom(){

        PhotonNetwork.JoinRoom(joinField.text);

    }

    public override void OnJoinedRoom(){

        PhotonNetwork.LoadLevel("Level1");

    }

}
