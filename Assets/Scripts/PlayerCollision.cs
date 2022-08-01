
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    CharacterMovements Movements;
    [SerializeField]
    private float forcelaunch;
    Rigidbody rb;

    private void Awake()
    {
        Movements = gameObject.GetComponent<CharacterMovements>();
        rb = gameObject.GetComponent<Rigidbody>();
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Obstacles"&&Movements)
        {

            Movements.speed = 1f;
        }
        if (collision.collider.tag == "Stick")
        {
            forcelaunch = collision.collider.gameObject.transform.parent.gameObject.GetComponent<Rotator>().force;
            rb.AddForce(forcelaunch * Time.deltaTime, 0, 0);
        }
        if (collision.collider.tag == "Finish")
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        if (Movements!=null)
        {
            Movements.speed = 15f;

        }
    }

}
