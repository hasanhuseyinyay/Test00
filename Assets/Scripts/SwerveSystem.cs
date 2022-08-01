using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveSystem : MonoBehaviour
{
    private SwerveMechanics swerveMechanics;
    [SerializeField]
    private float swerveSpeed = 1f;
    [SerializeField]
    private float maxSwerveAmout = 1f;
    private void Awake()
    {
        swerveMechanics = GetComponent<SwerveMechanics>();

    }
    private void Update()
    {
        float swerveAmout = Time.deltaTime * swerveSpeed * swerveMechanics.moveX;
        swerveAmout = Mathf.Clamp(swerveAmout, -maxSwerveAmout, maxSwerveAmout);
        if (transform.position.x > maxSwerveAmout)
        {
            transform.position = new Vector3(maxSwerveAmout, 0, transform.position.z);
        }
        if (transform.position.x<-maxSwerveAmout)
        {
            transform.position = new Vector3(-maxSwerveAmout, 0, transform.position.z);

        }
        else
            transform.Translate(swerveAmout, 0, 0);
    }
}
