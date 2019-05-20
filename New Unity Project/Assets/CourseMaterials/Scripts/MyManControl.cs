using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MyManControl : MonoBehaviour
{

    // Use this for initialization

    public GameObject MyMan;
    public float moveSpeed;
    public float turnSpeed;
    public Joystick joystick;
    public float jumpforce = 0.5f;
    new private Rigidbody rigidbody;
    private Vector3 jmp;
    private Animator animator;
    //  public Scrollbar scrollbar;

    float OriginalY = 0;
    bool temp = false;

    private void Start()
    {
        // OriginalY = MyMan.transform.position.y;
        rigidbody = GetComponent<Rigidbody>();
        jmp = transform.up * jumpforce;
        animator = GetComponent<Animator>();
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

         if (Input.GetKeyDown(KeyCode.Space))
            {
           
           
                rigidbody.AddForce(Vector3.up*jumpforce);
           
        }
           // rigidbody.AddForce(0, 300, 0);



        /* if (Input.GetKeyDown(KeyCode.Space))
         {
             MyMan.

         }
            /* if (isGrounded())
             {
                 temp = true;
                 rigidbody.AddForce(0, 10, 0);
             }
             else
               if (temp)
             {
                // rigidbody.AddForce(0, 10, 0);
                 temp=false;
             }
         }


         /* Vector3 moveVector = (transform.right * joystick.Horizontal + transform.forward * joystick.Vertical).normalized;
         MyMan.transform.Translate(Vector3.forward * Mathf.Clamp(joystick.Vertical * 6, -1, 1) * moveSpeed * Time.deltaTime);
         MyMan.transform.Rotate(Vector3.up * joystick.Horizontal * 66 * Time.deltaTime);

         */

        //   MyMan.transform.position = new Vector3(MyMan.transform.position.x, OriginalY + scrollbar.value, MyMan.transform.position.z);
    }

  /*  bool isGrounded()
    {
        Collider[] cc = Physics.OverlapSphere(new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z), 1.5f);
        int j = 0;
        for (int i = 0; i < cc.Length; i++)
        {
            if (cc[i].gameObject != gameObject)
            {
                j++;
            }
        }
        return j > 0;
    }
/*
    void Jump()
    {
        if (isGrounded())
        {

            rigidbody.AddForce(jmp, ForceMode.Impulse);
        }
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
