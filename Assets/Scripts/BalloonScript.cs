using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class BalloonScript : MonoBehaviourPun
{
    public bool die = false;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up*Time.deltaTime*0.2f);
        
        if (die == true) {
            PhotonNetwork.Destroy(gameObject);
        }

        if (transform.position.y > 3) {
            PhotonNetwork.Destroy(gameObject);
        }
        
    }

    public void request() {
        base.photonView.RequestOwnership();
        
    }
    //public void shot() {
    //    PhotonNetwork.Destroy(gameObject);
    //}
}
