using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSystem : MonoBehaviour
{
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        if (Input.GetKeyDown(KeyCode.L))
        {
            Instantiate(bullet,pos, Quaternion.identity);
        }
    }
}
