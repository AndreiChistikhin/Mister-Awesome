using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private readonly string _boolAnimatorName = "IsRunning";

    public void StartRunAnimation(float xMovement)
    {
        ChangeAnimation(true);
        if (xMovement == 0)
            return;
        int playerScale=xMovement > 0 ? 1 : -1;
        transform.localScale = new Vector3(playerScale, 1, 1);
    }

    public void StopRunAnimation()
    {
        ChangeAnimation(false);
    }

    private void ChangeAnimation(bool newAnimatorBool)
    {
        if (_animator.GetBool(_boolAnimatorName) == newAnimatorBool)
            return;
        _animator.SetBool(_boolAnimatorName,newAnimatorBool);
    }
}
