using UnityEngine;
using System.Collections;

public class PM3 : MonoBehaviour
{
    [SerializeField] float _h = 5.0f;
    [SerializeField] float _jumpSpeed = 20.0f;
    [SerializeField] float _gravity = 1.0f;
    float _yVelocity = 0.0f;

    CharacterController _controller;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 velocity = direction * _h;

        if (_controller.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                _yVelocity = _jumpSpeed;
            }
            else
            {
                _yVelocity = 0; // Yere temas ediyorsa ve z�plam�yorsa yVelocity s�f�rlanmal�
            }
        }
        else
        {
            _yVelocity -= _gravity;
        }

        velocity.y = _yVelocity;
        
        _controller.Move(velocity * Time.deltaTime);
    }
}