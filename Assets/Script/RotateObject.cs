using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 30.0f; // Adjust this value to control the rotation speed.

    public GameObject ghostPrefab;

    bool isRotate = false;

    public Animator ghostAnim;

    // Update is called once per frame
    void Update()
    {
        if(ghostPrefab == null)
        {
            ghostPrefab = GameObject.FindGameObjectWithTag("Player");
            ghostAnim = ghostPrefab.GetComponent<Animator>();
        }
        else
        {
            if (isRotate)
            {
                // Rotate the object around its up (Y) axis.
                ghostPrefab.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
            }
        }
    }

    public void RotateGhost()
    {
        isRotate = true;
        ghostAnim.SetBool("ScaleGhost", false);
    }

    public void ScaleGhost()
    {
        isRotate = false;
        ghostAnim.SetBool("ScaleGhost", true);
    }
}
