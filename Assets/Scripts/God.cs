using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class God : MonoBehaviour
{
    [SerializeField] private Sprite sprite;
    void Start()
    {
        Level level = new Level(75, 75, sprite);
    }
}
