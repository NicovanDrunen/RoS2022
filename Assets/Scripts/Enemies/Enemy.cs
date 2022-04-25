using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float maxHitpoints;
    [SerializeField] private float attack;
    private float currentHitpoints;
    private Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        myTransform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
