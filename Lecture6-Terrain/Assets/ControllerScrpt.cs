using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScrpt : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 1; i++)
        {
            Vector3 pos = new Vector3(Random.Range(0, 1000), 0, Random.Range(0, 1000));
            Instantiate(enemy, pos, Quaternion.identity);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
