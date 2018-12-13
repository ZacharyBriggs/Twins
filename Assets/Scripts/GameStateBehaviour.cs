using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateBehaviour : MonoBehaviour
{

    //gamestart
    //gameend
    //roundend
    [Header("Events")]
    [SerializeField]
    public GameEvent GameStarted;

    [SerializeField]
    public GameEvent GameUpdate;

    [SerializeField]
    public GameEvent GameEnded;

    public void Start()
    {
        GameStarted.Raise();
    }

    public void Update()
    {
        GameUpdate.Raise();
    }
}