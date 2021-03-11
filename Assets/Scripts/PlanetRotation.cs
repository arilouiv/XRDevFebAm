using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public MeshRenderer meshRenderer;

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log(transform.rotation.eulerAngles.x);
        meshRenderer.material.SetFloat("_Size", Random.Range(10, 50));
    }

    // Update is called once per frame
    private void Update()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + 1, transform.rotation.eulerAngles.z);
    }
}
