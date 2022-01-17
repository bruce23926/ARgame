using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class onlineSpawner : MonoBehaviour
{
    public Vector3[] spawnPoints = new Vector3[3];
    public GameObject[] balloons;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning(){
        yield return new WaitForSeconds(4);
        for(int i=0;i<3;i++){
            PhotonNetwork.InstantiateRoomObject(balloons[i].name,spawnPoints[i],Quaternion.identity);
        }

        StartCoroutine(StartSpawning());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
