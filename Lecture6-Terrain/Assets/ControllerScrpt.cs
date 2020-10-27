using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerScrpt : MonoBehaviour
{
    public static int score = 0;
    public GameObject Enemy;
    public Text txtScore;
    // Start is called before the first frame update
    void Start()
    {
        print("start");
        txtScore = GameObject.Find("Text").GetComponent<Text>();
        print("start2");
        ControllerScrpt.score = 0;
        //print("start3");
        /*Vector3 pos1 = new Vector3(UnityEngine.Random.Range(0, 1000), 10, UnityEngine.Random.Range(0, 1000));
        print("start4");
        Instantiate(Enemy, pos1, Quaternion.identity);
        print("Instantiate");*/
        for (int i = 0; i < 25; i++)
        {
            Vector3 pos = new Vector3(UnityEngine.Random.Range(0, 1000), 10, UnityEngine.Random.Range(0, 1000));
            Instantiate(Enemy, pos, Quaternion.identity);
        }


    }

    // Update is called once per frame
    void Update()
    {
        txtScore.text = "Score: " + score;
        
    }
}
