using UnityEngine;
using System.Collections;
public class PM1 : MonoBehaviour
{
    public float _h = 5.0f;
    CharacterController _controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _controller.Move(direction);
    }
}
