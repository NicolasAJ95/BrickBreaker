using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour {

    public LevelManager levelManager;

    void OnTriggerEnter2D (Collider2D looseCollider)
    {
        print("Trigger");
        levelManager.LoadLevel ("Win");
    }




}
