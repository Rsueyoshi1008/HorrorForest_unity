using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        cube.transform.position = new Vector3(0,10f,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
