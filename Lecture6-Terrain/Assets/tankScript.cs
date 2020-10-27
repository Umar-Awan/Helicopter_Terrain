using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankScript : MonoBehaviour
{
    GameObject me;
    // Start is called before the first frame update
    void Start()
    {
        me = GameObject.Find("Helicopter");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 destination = me.transform.position;
        destination.y = 0;
        transform.LookAt(destination);

        if (Vector3.Distance(transform.position, destination) < 1)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
        else
        {
            if (GetComponent<Rigidbody>().velocity.z < 6)
                GetComponent<Rigidbody>().AddRelativeForce(0, 0, 7);

        }
    }
}
