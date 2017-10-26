using UnityEngine;
using System.Collections;

public class targetControlla : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.GetComponent<ballController>())
        {
            Debug.Log("当たったよ");
            Destroy(gameObject);
        }

    }
}