using UnityEngine;
using System.Collections;
public class PM0 : MonoBehaviour
{
    public float _h = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _h = Input.GetAxis("Horizontal");
    }
}
