using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemyHP {  get; set; }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyHP = 100;

    }

    // Update is called once per frame
    void Update()
    {
       if(enemyHP < 0)
        {
            Destroy(gameObject);
        }
    }
}
