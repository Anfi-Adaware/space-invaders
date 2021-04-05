using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.y += 10f * Time.deltaTime;
        transform.position = pos;
        if(pos.y >= 5.99f)
        {
            Destroy(gameObject);
        }
    }
}
