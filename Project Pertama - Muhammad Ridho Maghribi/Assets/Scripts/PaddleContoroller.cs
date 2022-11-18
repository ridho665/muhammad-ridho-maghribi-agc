using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleContoroller : MonoBehaviour
{
    public int speed, normalSpeed, boostedSpeed;
    public int speedCooldown;
    public Vector3 boostedScale;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        normalSpeed = speed;    
    }

    private void Update()
    {
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {
        
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }
        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        Debug.Log("Test : "+movement);
        rig.velocity = movement;  
    }

    public void ActivatePUScaleUp(float magnitude)
    {
        transform.localScale = new Vector3(0.3f, magnitude, 1);
        StartCoroutine("SpeedDuration");
    }

    public void ActivatePUSpeedSUp()
    {
        speed = boostedSpeed;
        StartCoroutine("SpeedDuration");       
    }

    IEnumerator SpeedDuration ()
    {
        yield return new WaitForSeconds (speedCooldown);
        speed = normalSpeed;
        transform.localScale = new Vector3(0.3f, 2, 1);
    }

}

