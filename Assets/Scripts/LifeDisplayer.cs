using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeDisplayer : MonoBehaviour
{
    public GameObject heart;
    private HealthBehaviour playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        var player = GameObject.FindWithTag("Player");
        playerHealth = player.GetComponent<HealthBehaviour>();
    }
    public void UpdateHearts(int hearthNumber)
    {
        foreach(Transform child in transform)
        {
            Destroy(child.gameObject);
        }
        for(var i =0; i<hearthNumber; i++)
        {
            Instantiate(heart, Vector3.zero, Quaternion.identity, transform);
        }
    }
    // Update is called once per frame
    void Update()
    {
        UpdateHearts(playerHealth.currentHealth);
    }
}
