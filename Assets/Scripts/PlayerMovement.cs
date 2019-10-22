using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Tooltip("Speed of player")]
    [SerializeField]
    private float _speed = 10f;
    [SerializeField]
    private bool _isRaw = true;

    private float _horizontalMovement;
    private float _verticalMovement;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (_isRaw)
        {
            _horizontalMovement = Input.GetAxisRaw("Horizontal");
            _verticalMovement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            _horizontalMovement = Input.GetAxis("Horizontal");
            _verticalMovement = Input.GetAxis("Vertical");
        }

        transform.Translate(new Vector3(_horizontalMovement, _verticalMovement, 0) * Time.deltaTime * _speed);
    }
}
