using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkForObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray mouse = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(mouse, out hit, 100f))
        {
            print("Hit with mouse: " + hit.collider.gameObject.name);
        }
        /*
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 100f))
        {
            print("we hit sth" + hit.transform.position);
        }*/
    }
}
