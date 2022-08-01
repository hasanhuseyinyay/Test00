using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public CharacterMovements movements;
    private bool gameisEnded = false;
    [SerializeField]
    private float restartDeley;


    public void EndGame()
    {
        if (!gameisEnded)
        {
            gameisEnded = true;
            movements.enabled = false;
            Invoke("Restart", restartDeley);

        }
    }
    public void Restart()
    {
        movements.enabled = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
