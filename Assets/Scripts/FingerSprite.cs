using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerSprite : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.position = Utility.ScreenToWorldPos(Input.mousePosition);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter2D hit a " + collision.gameObject.name);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("OnCollisionExit2D left a " + collision.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OnTriggerEnter2D hit a " + collision.gameObject.name);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("OnTriggerExit2D left a " + collision.gameObject.name);
    }
}
