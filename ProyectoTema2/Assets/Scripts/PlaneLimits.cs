using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneLimits : MonoBehaviour
{

    private Vector3 objectPos = new Vector3(0, 0.5f, 0);
    private float limX = 49.0f;
    private float limZ = 24.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = objectPos;
    }

    // Update is called once per frame
    void Update()
    {
        MoveGameObject(Vector3.right, KeyCode.RightArrow);
        MoveGameObject(Vector3.left, KeyCode.LeftArrow);
        MoveGameObject(Vector3.forward, KeyCode.UpArrow);
        MoveGameObject(Vector3.back, KeyCode.DownArrow);

        if (transform.position.x >= limX)
        {
            transform.position = new Vector3(limX, transform.position.y, transform.position.z);
        }

        if (transform.position.x <= -limX)
        {
            transform.position = new Vector3(-limX, transform.position.y, transform.position.z);
        }

        if (transform.position.z >= limZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, limZ);
        }

        if (transform.position.z <= -limZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -limZ);
        }

    }

    public void MoveGameObject(Vector3 direction, KeyCode keyCode)
    {
        if (Input.GetKeyDown(keyCode))
        {
            transform.position += direction;
        }
    }
}
