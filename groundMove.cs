using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundMove : MonoBehaviour
{
    // Start is called before the first frame update
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
        if (i <= 200)
        {
            this.transform.position += new Vector3(-0.1f , 0, 0);
            i++;
        }
        else if (i <= 400)
        {
            this.transform.position += new Vector3(0.1f , 0, 0);
            i++;
            if (i == 400)
            {
                i = 0;
            }
        }
    }
}
