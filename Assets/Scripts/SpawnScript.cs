using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnScript : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] balloons;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());
    }

    IEnumerator StartSpawning(){
        yield return new WaitForSeconds(4);
        for(int i=0;i<3;i++){
            PhotonNetwork.Instantiate(balloons[i].name,spawnPoints[i].position,Quaternion.identity);
        }

        StartCoroutine(StartSpawning());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
