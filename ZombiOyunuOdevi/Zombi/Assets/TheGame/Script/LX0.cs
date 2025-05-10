using UnityEngine;
using System.Collections;

public class LX0 : MonoBehaviour
{
    [SerializeField] float _mouseX = 0.0f;
    
    void Update()
    {
        _mouseX = Input.GetAxis("Mouse X");
    }
}