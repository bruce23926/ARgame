using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class Score : MonoBehaviourPun
{
    private Text score;
    
    public GameObject main;

    // Start is called before the first frame update
    void Start()
    {
        
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    private void Update()
    {
        score.text = main.GetComponent<onlineSpawner>().scoreA.ToString();
    }

}
