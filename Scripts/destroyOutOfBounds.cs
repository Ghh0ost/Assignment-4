using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOutOfBounds : MonoBehaviour
{
    private float topBound = 6;
    private float lowerBound = -6;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > topBound)
        {
            Destroy(gameObject);
        }

        else if (transform.position.x < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
