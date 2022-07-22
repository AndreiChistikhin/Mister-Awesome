using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private readonly int _playerSpeed=500;
    private float _xAxisMovement;
    private float _yAxisMovement;

    private void Update()
    {
        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0) return;
        _xAxisMovement = Input.GetAxis("Horizontal") * _playerSpeed * Time.deltaTime;
        _yAxisMovement = Input.GetAxis("Vertical") *  _playerSpeed * Time.deltaTime;

        transform.position += new Vector3(_xAxisMovement, _yAxisMovement,0);
    }
}
