using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerAnimation _playerAnimation;
    [SerializeField] private PlayerMovement _playerMovement;

    public PlayerMovement PlayerMovement => _playerMovement;
    public PlayerAnimation PlayerAnimation => _playerAnimation;
}
