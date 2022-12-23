using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] float topBound = 100;

    private void Update()
    {
        if (transform.position.z > topBound)
        {
            Debug.Log("hi");
            // Destroy(gameObject);
        }
    }
}
