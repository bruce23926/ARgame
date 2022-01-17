using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnScript : MonoBehaviour
{
    
    public GameObject spawner;
    void Start()
    {
        PhotonNetwork.Instantiate(spawner.name, new Vector3(0,0,0),Quaternion.identity);
    }
}
