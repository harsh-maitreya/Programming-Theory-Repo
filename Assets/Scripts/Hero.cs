using UnityEngine;

public class Hero : MonoBehaviour
{
    public GameObject enemy;
    protected virtual void Start()
    {
        enemy = GameObject.FindWithTag("Enemy");
    }
    protected void Move()
    {
        if(enemy != null)
        transform.position = Vector3.MoveTowards(transform.position, enemy.transform.position, 2*Time.deltaTime);
    }

    protected virtual void DealDamage()
    {
        if(enemy != null)
        enemy.GetComponent<Enemy>().enemyHP -= 10;
    }

}
