using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public GameObject dhamaka;
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
        print("Bullet collision");

        
        if(collision.gameObject.name.StartsWith("Enemy"))
        {
           Vector3 enemypos= collision.gameObject.transform.position;
            enemypos.x = Random.Range(0, 1000);
            enemypos.z = Random.Range(0, 1000);
            collision.gameObject.transform.position = enemypos;
        }
        Destroy(transform.gameObject);
        Instantiate(dhamaka, transform.position, transform.rotation);
    }

    /*private void OnTriggerEnter(Collider col)
    {
        if (!col.gameObject.name.StartsWith("Terrain"))
        {
            Destroy(col.gameObject);
        }

    }*/
}
