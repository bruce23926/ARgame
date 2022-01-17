using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class score2 : MonoBehaviourPun
{
    private Text score;
    
    public GameObject main;
    void Start()
    {
        
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    private void Update()
    {
         score.text = main.GetComponent<onlineSpawner>().scoreB.ToString();
    }


}
