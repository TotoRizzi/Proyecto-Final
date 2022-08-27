using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Player player { get { return player; } }
    public LayerMask wallLayer { get { return wallLayer; } }

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    public Vector3 GetDistanceToPlayer(Transform transform)
    {
        return player.transform.position - transform.position;
    }
}
