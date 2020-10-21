using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHelicopter : MonoBehaviour
{
    public GameObject me;
    // Start is called before the first frame update
    void Start()
    {
        me = GameObject.Find("Helicopter");
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.05f);
        transform.LookAt(me.transform);

    }
}
