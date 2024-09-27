using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_control : MonoBehaviour
{
    

    // Update is called once per frame private float mouseX;
    private float mouseY;
    private float mouseX;
    public float a;
    public float i;
    public Transform Player;
    public Transform Player2;
    public GameObject p3;
    [Header("���������������� ����")]
    public float sM = 200f;
    void Start()
    {
        //transform.position = new Vector3(10, 4, 10);
        i=0f;
        Cursor.lockState = CursorLockMode.Locked;
        Player.Rotate(0 * new Vector3(0, 1, 0));
        Player2.Rotate(0 * new Vector3(1, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
//(Input.GetKey(KeyCode.W))
        //Input.GetKeyDown(KeyCode.W);
        //Input.GetKeyDown(KeyCode.W);
        // Input.GetKeyDown(KeyCode.W);
        //Input.GetAxis("Horizontal");//A=-1;D=1
        //float inputMouseY = inputMouse.GetAxis("Mouse Y")
        //transform.pasitiop += nev Vector3();

        mouseX = Input.GetAxis("Mouse X") * sM * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * sM * Time.deltaTime;
        ///if (i>5){
            ///a=p3.transform.eulerAngles.x; 
            if ((a>60.0)&(a<=90.0)){
            Player2.Rotate(359 * new Vector3(1, 0, 0));
            }
            if ((a<340.0)&(a>=280.0)){
                Player2.Rotate(361 * new Vector3(1, 0, 0));
            }
        //}
        /*else{
            a=0;
        }
        
        i=i+Time.deltaTime;*/
        Player.Rotate(mouseX * new Vector3(0, 1, 0));
        if (((a >= 340.0) && (a <= 360.0))||((a>=0.0)&(a <= 60.0)))
        { 
            Player2.Rotate(mouseY * new Vector3(1, 0, 0));
            //transform.Rotate(-mouseY * new Vector3(1, 0, 0));
        }
       

        if (Input.GetKey(KeyCode.R))
        {
            a=0;
            Player.Rotate(0 * new Vector3(0, 1, 0));
            Player2.Rotate(0 * new Vector3(1, 0, 0));
        }
        if(Input.GetKey(KeyCode.Q)){
            a=p3.transform.eulerAngles.x;}
           /* transform.rotation = new Quaternion(0, 0, 0, 0);
            transform.Rotate(180 * new Vector3(0, 1, 0));
        }
            if (Input.GetKeyUp(KeyCode.R))
        {
            transform.Rotate(180 * new Vector3(0, 1, 0));
        }
        */


    }
}


