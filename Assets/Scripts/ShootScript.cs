using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class ShootScript : MonoBehaviourPun
{
    public GameObject arCamera;
    public GameObject smoke;
    public GameObject scoreboard;
    public GameObject scoreboard2;
    public GameObject spawner;

    public void Shoot(){
        RaycastHit hit;
        if(Physics.Raycast(arCamera.transform.position,arCamera.transform.forward,out hit)){
            if (hit.transform.name == "balloon1(Clone)"|| hit.transform.name == "balloon2(Clone)"||hit.transform.name == "balloon3(Clone)"){
                //PhotonView target = hit.transform.gameObject.GetComponent<PhotonView>() as PhotonView;
                //PhotonView Player = gameObject.GetComponent<PhotonView>() as PhotonView;
                //if (target != Player) {
                    //target.TransferOwnership();
                //}
                if (hit.transform.gameObject.GetComponent<PhotonView>().IsMine) {
                    
                    spawner.GetComponent<onlineSpawner>().s1();
                } else {
                    hit.transform.gameObject.GetComponent<BalloonScript>().request();
                    spawner.GetComponent<onlineSpawner>().s2();
                }
                
                PhotonNetwork.Destroy(hit.transform.gameObject);
                //hit.transform.gameObject.GetComponent<BalloonScript>().shot();
                //hit.transform.position = new Vector3(0, 2.9f, 0);
                
                PhotonNetwork.Instantiate(smoke.name,hit.point,Quaternion.LookRotation(hit.normal));
                
            }
        }
    }
    
    
}
