using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] Transform player;
    Vector3 _playerPosition;


    void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        _playerPosition = player.transform.position;
    }
 
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, _playerPosition, speed * Time.deltaTime);
    }

    void DestroyWhenReached()
    {
        if (transform.position == _playerPosition)
        {
            Destroy(gameObject);
        }
    }
}