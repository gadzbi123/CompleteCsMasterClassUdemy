using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class textBehaviour : MonoBehaviour
{
    public TMP_Text myText;
    int textNumber = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            textNumber++;
            myText.text = textNumber.ToString();
        }
        else if (Input.GetKeyDown(KeyCode.S))
            myText.text = "S was pressed";
    }
}
