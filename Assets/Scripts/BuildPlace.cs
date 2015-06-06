using UnityEngine;
using System.Collections;

public class BuildPlace : MonoBehaviour
{
    public GameObject towerPrefab;
    private GameObject towerInstance;

    public void OnMouseUpAsButton()
    {
        if (towerInstance == null)
        {
            towerInstance = Instantiate(towerPrefab);
            towerInstance.transform.position = transform.position + Vector3.up;
        }

    }
}
