using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpeedDisplayer : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    
    private Rigidbody2D playerPhysics;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        
        //textMeshPro.text = "ceci ets lkqdqij";

        var player = GameObject.FindWithTag("Player");
        playerPhysics = player.GetComponent<Rigidbody2D>();

    }
    private void UpdateSpeed(float speed)
    {
        textMeshPro.text = speed.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        UpdateSpeed(playerPhysics.velocity.magnitude);
    }
    
}
