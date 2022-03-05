using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSpawning : MonoBehaviour
{
    public GameObject brick;
    public float offset;
    public GameObject[] brickarray;

    // Start is called before the first frame update
    void Start()
    {
        brickarray = new GameObject[7];
        for(int i=0;i<brickarray.Length;i++)
        {
            transform.position = new Vector3(transform.position.x + 2.0f, 10.0f, 0);
            brickarray[i] = Instantiate(brick, transform.position, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
