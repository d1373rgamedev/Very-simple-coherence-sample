using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        var spf = speed * Time.deltaTime;

        transform.position += transform.forward * (v * spf);
        transform.position += transform.right * (h * spf);
    }
}