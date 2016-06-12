using UnityEngine;
using System.Collections;

public class FollowTarget2D : MonoBehaviour
{

    public Transform target;

    public bool doInLateUpdate = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!doInLateUpdate)
        {
            UpdatePosition();
        }

    }

    void LateUpdate()
    {
        if (doInLateUpdate)
        {
            UpdatePosition();
        }

    }

    void UpdatePosition()
    {
        Vector3 position = new Vector3(target.position.x, target.position.y, transform.position.z);
        transform.position = position;
    }
}
