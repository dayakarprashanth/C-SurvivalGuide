using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private float _verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

  
    // Update is called once per frame
    void Update()
    {
        //We are hard coding so has to move left and right. Inorder to not use it we use WSAD (called horizontal axis)

        //Vector3.left is same as new Vector3(-1, 0, 0)

        //transform.Translate(Vector3.right * _speed * Time.deltaTime);
        //transform.Translate(Vector3.left * _speed * Time.deltaTime);

        _verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput, 0, 0) * _speed * Time.deltaTime);
        transform.Translate(new Vector3(0, _verticalInput, 0) * _speed * Time.deltaTime);

    }
}
