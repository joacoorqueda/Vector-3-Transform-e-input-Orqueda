using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPosition : MonoBehaviour
{
    public Vector3 newPosition;
    public GameObject mycube; 
    // Start is called before the first frame update
    void Start()
    {
        mycube.transform.position = newPosition;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
