using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.5f);

    }
    private void OnCollisionEnter(Collision collision)
    {

        if (!collision.gameObject.name.StartsWith("Terrain"))
        {
            Destroy(collision.gameObject);
        }
        Destroy(transform.gameObject);
    }

    /*private void OnTriggerEnter(Collider col)
    {
        if (!col.gameObject.name.StartsWith("Terrain"))
        {
            Destroy(col.gameObject);
        }

    }*/
}
