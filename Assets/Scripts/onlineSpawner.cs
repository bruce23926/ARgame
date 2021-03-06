using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class onlineSpawner : MonoBehaviourPun
{
    public Vector3[] spawnPoints = new Vector3[3];
    public GameObject[] balloons;
    public int scoreA = 0;
    public int scoreB = 0;
    // public int score1 = 0;
    // public int score2 = 0;
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
    //Update is called once per frame
    public void s1() {
        scoreA += 1;
        
    }
    public void s2() {
        scoreB += 1;
        
    }
    // public void CallRPC(int score1) {
    //     photonView.RPC("s1", RpcTarget.All, score1);
    // }
    // [PunRPC]
    // void RecieveRPC(int score1){
    //     scoreA = score1;
    // }
    // public void CallRPC2(int score2) {
    //     photonView.RPC("s2", RpcTarget.All, score2);
    // }
    // [PunRPC]
    // void RecieveRPC2(int score2){
    //     scoreB = score2;
    // }
}
