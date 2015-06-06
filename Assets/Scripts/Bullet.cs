using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
    public float speed = 10;
    //set bei tower
    public Transform target;

    private Rigidbody rb;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        if (target != null)
        {
            Vector3 dir = target.position - transform.position;
            rb.velocity = dir.normalized * speed * Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        HealthBar healthbar = other.GetComponentInChildren<HealthBar>();
        if(healthbar != null)
        {
            healthbar.decreaseHealthPoints();
            Destroy(gameObject);
        }
    }
}
