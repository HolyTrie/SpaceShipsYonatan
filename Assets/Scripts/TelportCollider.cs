using UnityEngine;

public class TeleportCollider : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform _otherSide;
    private Transform _thisSide;
    private float _offsetDirection;
    private float _destX;

    void Start()
    {
        _thisSide = GetComponent<Transform>();
        _offsetDirection = _otherSide.transform.position.x < _thisSide.position.x ? 1f : -1f;
        _destX = _otherSide.transform.position.x;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            Vector3 destination = other.transform.position;
            float offsetSize = other.bounds.size.x;
            destination.x = _destX + _offsetDirection * offsetSize;
            other.transform.position = destination;
            //Debug.Log(destination);
        }
    }
}
