using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUScaleUpController : MonoBehaviour
{
    public Collider2D paddleKanan;
    public Collider2D paddleKiri;
    public float magnitude;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision = paddleKanan)
        {
            paddleKanan.GetComponent<PaddleContoroller>().ActivatePUScaleUp(magnitude);
            Destroy(gameObject);
        }

        if(collision = paddleKiri)
        {
            paddleKiri.GetComponent<PaddleContoroller>().ActivatePUScaleUp(magnitude);
            Destroy(gameObject);
        }
    }
}
