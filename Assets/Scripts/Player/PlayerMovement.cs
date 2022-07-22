using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private readonly int _playerSpeed=500;
    private float _xAxisMovement;
    private float _yAxisMovement;

    public void MovePlayer(float xInput, float yInput)
    {
        _xAxisMovement = xInput * _playerSpeed * Time.deltaTime;
        _yAxisMovement = yInput *  _playerSpeed * Time.deltaTime;

        transform.position += new Vector3(_xAxisMovement, _yAxisMovement,0);
    }
}
