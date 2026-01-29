using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 10f;

    void Update()
    {
        Vector3 pos = transform.position;
        pos.y += flySpeed * Time.deltaTime;
        transform.position = pos;
    }
}