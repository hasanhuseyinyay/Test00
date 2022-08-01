using UnityEngine;
using UnityEngine.AI;

public class OpponentCharacter : MonoBehaviour
{
    public Transform finish;
    private NavMeshAgent nAgent;
    void Start()
    {
        nAgent = GetComponent<NavMeshAgent>();
      
    }

    void Update()
    {
        nAgent.SetDestination(finish.position);
    }
}
