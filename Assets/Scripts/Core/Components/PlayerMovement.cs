using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed;
    
    [SerializeField]
    private Vector2 _initialPosition;
    
    private Camera _mainCamera;
    private float _playerHeight;
    private bool _isMovementActive;

    private void Awake()
    {
        _mainCamera = Camera.main;
        _playerHeight = transform.position.y;
    }

    void Update()
    {
        if(!_isMovementActive) return;
        
        if (Input.GetMouseButton(0))
        {
            Vector3 touchPosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
            Vector2 newPosition = new(touchPosition.x, _playerHeight);
            transform.position = newPosition;
        }
    }

    public void ResetPosition()
    {
        transform.position = _initialPosition;
    }

    public void SetMovementActivity(bool isMovementActive)
    {
        _isMovementActive = isMovementActive;
    }
}
