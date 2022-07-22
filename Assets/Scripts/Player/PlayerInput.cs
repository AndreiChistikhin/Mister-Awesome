using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Player _player;
    
    private void Update()
    {
        float xMovement = Input.GetAxis("Horizontal");
        float yMovement = Input.GetAxis("Vertical");
        if (xMovement == 0 && yMovement == 0)
        {
            _player.PlayerAnimation.StopRunAnimation();
            return;
        }

        _player.PlayerMovement.MovePlayer(xMovement,yMovement);
        _player.PlayerAnimation.StartRunAnimation(xMovement);
    }
}
