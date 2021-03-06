﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehavior : MonoBehaviour
{
    public float rotationSpeed;
    public float bobDistance;
    public float bobSpeed;

    public uint Index { get; set; }
    private GameObject sprite;
    private PickupsManager manager;
    private float originalY;
    private float spawnTime;

    // Use this for initialization
    void Start ()
    {
        sprite = transform.GetChild(0).gameObject;
        originalY = transform.position.y;
        manager = GetComponentInParent<PickupsManager>();
        spawnTime = Time.time;
	}
	
	// Update is called once per frame
	void Update ()
    {
        sprite.transform.Rotate(new Vector3(0, 0, Time.deltaTime) * rotationSpeed);

        transform.position = new Vector2(transform.position.x,
            originalY + Mathf.Sin((Time.time - spawnTime) * bobSpeed) * bobDistance);
    }

    public void GetPickedUp()
    {
        manager.PickupCollected(Index);
        gameObject.SetActive(false);
    }

    public void Activate()
    {
        gameObject.SetActive(true);
        spawnTime = Time.time;
    }
}
