using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public GameObject mycube;
    public Vector3 movementvector;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        if (mycube.transform.position.x < 8 )
        {
            mycube.transform.position += movementvector;
        }
    }
}
