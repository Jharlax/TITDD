using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour
{

    public GameObject bulletPrefab;
    public float rotationSpeed = 35f; 

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed, Space.World);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Monster>())
        {
            GameObject g = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            g.GetComponent<Bullet>().target = other.transform;
        }
    }
}
