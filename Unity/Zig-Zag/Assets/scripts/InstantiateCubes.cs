using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateCubes : MonoBehaviour
{
    public Transform prefab;
    int counter = 1;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("CreateNewCube", 3f, 1f);
        //Invoke("CreateNewCube", 1f);
    }

    // Update is called once per frame


    public void CreateNewCube()
    {
        Instantiate(prefab, new Vector3(counter++ * 3f, 0, 0), Quaternion.identity);

        if (counter > 10)
            CancelInvoke("CreateNewCube");
    }
}
