using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WallBehaviour : MonoBehaviour
{
    public ballBehaviour ballBehaviour;
    public TMP_Text scoreTextP1;
    private int scoreP1;
    public TMP_Text scoreTextP2;
    private int scoreP2;
    // Start is called before the first frame update
    void Start()
    {
        scoreP1 = 0;
        scoreP2 = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "WallRight")
        {
            //Game reset
            StartCoroutine(ballBehaviour.StartBall(false));
            //Add point to player1
            scoreP1++;
            scoreTextP1.text = scoreP1.ToString();
        }
        else
        {
            //Game reset
            StartCoroutine(ballBehaviour.StartBall(true));
            //Add point to player2
            scoreP2++;
            scoreTextP2.text = scoreP2.ToString();
        }

        if (scoreP1 == 5 || scoreP2 == 5)
            SceneManager.LoadScene("GameOver");

    }
}
