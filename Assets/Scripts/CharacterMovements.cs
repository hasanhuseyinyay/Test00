using UnityEngine;


public class CharacterMovements : MonoBehaviour
{
    
    public float speed = 15f;
   

    private void Update()
    {
        transform.position += new Vector3(0, 0, 1) * Time.deltaTime * speed;
    }

}
