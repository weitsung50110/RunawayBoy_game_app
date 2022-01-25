using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_move2 : MonoBehaviour
{
    int i = 0;
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (i < 150)
        {
            this.transform.position += new Vector3(0, 0.1f, 0);
            i++;
        }
        else if (i < 300)
        {
            this.transform.position += new Vector3(0, -0.1f, 0);
            i++;
            if (i == 299)
            {
                i = 0;
            }
        }
    }
}
