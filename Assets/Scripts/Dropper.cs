using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timeToWait = 3f;

    private MeshRenderer _myMeshRenderer;
    private Rigidbody _myRigidBody;
    
    private void Start()
    {
        _myMeshRenderer = GetComponent<MeshRenderer>();
        _myRigidBody = GetComponent<Rigidbody>();
        
        _myMeshRenderer.enabled = false;
        _myRigidBody.useGravity = false;

    }

    void Update()
    {
        if (Time.time > timeToWait)
        {
            _myMeshRenderer.enabled = true;
            _myRigidBody.useGravity = true;
        }
    }
}