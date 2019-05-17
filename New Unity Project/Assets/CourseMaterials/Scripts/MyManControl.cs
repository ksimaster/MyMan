using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyManControl : MonoBehaviour
{

    // Use this for initialization

    public GameObject MyMan;
    public float moveSpeed;
    public float turnSpeed;
    public Joystick joystick;


  //  public Scrollbar scrollbar;

    float OriginalY = 0;


    private void Start()
    {
       // OriginalY = MyMan.transform.position.y;

    }

    void Update()
    {
        if ((Input.GetKey(KeyCode.UpArrow)) || (Input.GetKey(KeyCode.W)))
            MyMan.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.DownArrow) || (Input.GetKey(KeyCode.S)))
            MyMan.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.A)))
            MyMan.transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.D)))
            MyMan.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);




        /* Vector3 moveVector = (transform.right * joystick.Horizontal + transform.forward * joystick.Vertical).normalized;
        MyMan.transform.Translate(Vector3.forward * Mathf.Clamp(joystick.Vertical * 6, -1, 1) * moveSpeed * Time.deltaTime);
        MyMan.transform.Rotate(Vector3.up * joystick.Horizontal * 66 * Time.deltaTime);

        */

        //   MyMan.transform.position = new Vector3(MyMan.transform.position.x, OriginalY + scrollbar.value, MyMan.transform.position.z);
    }


  /*  public void ToggleDragonFlame()
    {
        InvokeRepeating("DragonFlame", 0, 2);

    }


    void DragonFlame()
    {
        Dragon.transform.Find("DragonFlame").transform.localPosition = new Vector3(0, 0.884f, 0.614f);

        if (Dragon.transform.Find("DragonFlame").gameObject.activeSelf == false)
        {
            Dragon.transform.Find("DragonFlame").gameObject.SetActive(true);
            return;
        }

        if (Dragon.transform.Find("DragonFlame").gameObject.activeSelf == true)
        {
            Dragon.transform.Find("DragonFlame").gameObject.SetActive(false);
            CancelInvoke("DragonFlame");
        }

    } */


}
