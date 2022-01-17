using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class score2 : MonoBehaviourPun
{
    private Text score;
    private int scoreAmount;

    // Start is called before the first frame update
    void Start()
    {
        scoreAmount = 0;
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    private void Update()
    {
        score.text = scoreAmount.ToString();
    }

    public void AddScore()
    {
        scoreAmount += 1;
    }

}
