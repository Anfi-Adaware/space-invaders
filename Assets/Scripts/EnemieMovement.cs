using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieMovement : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 pos = transform.position;
        pos = one.transform.position;
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        if (pos.x <= two.transform.position.x)
        {
            pos.x += 15f * Time.deltaTime;
        }
        else if(pos.x >= two.transform.position.x)
        {
            pos.x -= 15f * Time.deltaTime;
        }
        

        transform.position = pos;
    }
}
