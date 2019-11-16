using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour
{
    public float lifetime;
    private WordManager wordManager;

    void Start()
    {
        Destroy(gameObject, lifetime);
        wordManager.score -= 10;
    }
}
