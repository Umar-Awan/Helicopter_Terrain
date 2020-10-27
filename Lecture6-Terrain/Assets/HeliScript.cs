using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HeliScript : MonoBehaviour
{
    public GameObject bullet;
    public Camera cam1, cam2;
    // Start is called before the first frame update
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, 0.3f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0, -0.3f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0.5f, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -0.5f, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0.1f, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -0.1f, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, 0);
        }
       /* if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Rotate(-3, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Rotate(3, 0, 0);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.Rotate(3, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.Rotate(-3, 0, 0);
        }*/
        /*if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, 3);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -3);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, 3);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, -3);
        }*/
        if(Input.GetKeyDown(KeyCode.X))
        {
            Vector3 myposition = transform.position;
            myposition.y -= 1;
            Instantiate(bullet, myposition, transform.rotation);
        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            switchCamera();
        }

    }
    private void switchCamera()
    {
        if(cam1.enabled==true)
        {
            cam1.enabled = false;
            cam2.enabled = true;
        }
        else
        {
            cam1.enabled = true;
            cam2.enabled = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {

        SceneManager.LoadScene("GameOverScene");
    }
}