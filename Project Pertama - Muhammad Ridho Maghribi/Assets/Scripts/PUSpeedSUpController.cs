using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedSUpController : MonoBehaviour
{
    public Collider2D paddleKanan;
    public Collider2D paddleKiri;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision = paddleKanan)
        {
            paddleKanan.GetComponent<PaddleContoroller>().ActivatePUSpeedSUp();
            Destroy(gameObject);
        }

        if(collision = paddleKiri)
        {
            paddleKiri.GetComponent<PaddleContoroller>().ActivatePUSpeedSUp();
            Destroy(gameObject);
        }
    }
}
