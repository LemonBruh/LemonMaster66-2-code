using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetDrag : MonoBehaviour
{
    public Transform target;
    public float speedX = 1, speedY = 1, speedZ = 1;

    private void Update()
    {
        float x = Mathf.Lerp(transform.position.x, target.position.x, speedX * Time.deltaTime);
        float y = Mathf.Lerp(transform.position.y, target.position.y, speedY * Time.deltaTime);
        float z = Mathf.Lerp(transform.position.z, target.position.z, speedZ * Time.deltaTime);

        transform.position = new Vector3(x, y, z);
    }
}