using UnityEngine;

public class EM0 : MonoBehaviour
{

    CharacterController _controller;
    Transform _player;

    [SerializeField]
    float _moveSpeed = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject playerGameObject = GameObject.FindGameObjectWithTag("Player");
        _player = playerGameObject.transform;

        _controller = GetComponent<CharacterController>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = _player.position - transform.position;
        direction = direction.normalized;

        Vector3 velocity = direction * _moveSpeed;

        _controller.Move(velocity * Time.deltaTime);
    }
}
