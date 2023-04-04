using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviourPunCallbacks
{
    
    [SerializeField]
    private GameObject playerPrefab;

    [SerializeField]
    private Vector2 spawnPointX;
    [SerializeField]
    private Vector2 spawnPointZ;

    void Start()
    {

        Vector3 randomPosition = new Vector3(Random.Range(spawnPointX.x, spawnPointX.y), 1.5f, Random.Range(spawnPointZ.x, spawnPointZ.y));
        GameObject player = PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);
        player.GetComponent<PlayerSetup>().IsLocalPLayer();
        
    }

}
