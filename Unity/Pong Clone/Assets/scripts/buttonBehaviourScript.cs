using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class buttonBehaviourScript : MonoBehaviour
{

    public void OnButtonPressed(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
