using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class BalloonScript : MonoBehaviour
{
    public bool die = false;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up*Time.deltaTime*0.2f);
        if (die == true) {
            PhotonNetwork.Destroy(gameObject);
        }
    }

    
    //public void shot() {
    //    PhotonNetwork.Destroy(gameObject);
    //}
}
