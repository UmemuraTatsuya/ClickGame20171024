using UnityEngine;
using System.Collections;

public class ballGenerator : MonoBehaviour {

    public GameObject ballprefab;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject ball =
                Instantiate(ballprefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            ball.GetComponent<ballController>().Shoot(
                worldDir.normalized*2000);
            Debug.Log("飛んでるよ");
        }

       

	}
}
