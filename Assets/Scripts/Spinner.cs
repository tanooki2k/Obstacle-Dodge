using UnityEngine;
using UnityEngine.Serialization;

public class Spinner : MonoBehaviour
{
   [SerializeField] float xAngle;
   [SerializeField] float yAngle;
   [SerializeField] float zAngle;

    void Update()
    {
        float xValue = xAngle * Time.deltaTime;
        float yValue = yAngle * Time.deltaTime;
        float zValue = zAngle * Time.deltaTime;
        
        transform.Rotate(xValue, yValue, zValue);
    }
}
