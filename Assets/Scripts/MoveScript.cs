using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    Rigidbody2D rb;
    float AxisHorizontal,AxisVertical;
    public float speed, rotarionspeed;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        InputControls();
      
    }
    private void FixedUpdate()
    {
        rb.rotation += AxisHorizontal * rotarionspeed;


        //rb.velocity = new Vector2(rb.velocity.x, AxisVertical * speed);
        //transform.Translate(transform.up * AxisVertical * rotarionspeed*Time.deltaTime);
        rb.velocity = transform.up * AxisVertical * speed;
    }
    void InputControls()
    {
        if (Input.GetKey(KeyControllers.LeftArrow) && Input.GetKey(KeyControllers.RightArrow))
        {
            AxisHorizontal = 0;
        }
        else if (Input.GetKey(KeyControllers.LeftArrow))
        {
            AxisHorizontal = 1;
        }
        else if (Input.GetKey(KeyControllers.RightArrow))
        {
            AxisHorizontal = -1;
        }
        else if (!Input.GetKey(KeyControllers.RightArrow) || !Input.GetKey(KeyControllers.LeftArrow))
        {
            AxisHorizontal = 0;
        }

        if (Input.GetKey(KeyControllers.Acelerate) && Input.GetKey(KeyControllers.Back))
        {
            AxisVertical = 0;
        }
        else if (Input.GetKey(KeyControllers.Acelerate))
        {
            AxisVertical = 1;
        }
        else if (Input.GetKey(KeyControllers.Back))
        {
            AxisVertical = -1;
        }
        else if (!Input.GetKey(KeyControllers.Acelerate) || !Input.GetKey(KeyControllers.Back))
        {
            AxisVertical = 0;
        }
    }
}
