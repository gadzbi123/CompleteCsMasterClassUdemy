using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float temp;
    // Start is called before the first frame update
    void Start()
    {
        temp = 1000f;
        float myRandomNum = Random.Range(1f, 7f);
        Debug.Log(myRandomNum);
    }

    private void Update()
    {
        gameObject.GetComponent<Renderer>().material.color = Mathf.CorrelatedColorTemperatureToRGB(temp);
        temp++;
        if (temp > 3000f)
            temp = 1000f;

    }


}
