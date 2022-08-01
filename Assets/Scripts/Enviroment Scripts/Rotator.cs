using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed;
    public float force;
    


    void Update()
    {
        transform.Rotate(0, 1 * rotationSpeed,0);
    }
    
}
