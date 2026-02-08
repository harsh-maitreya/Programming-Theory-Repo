using UnityEngine;

public class Hero : MonoBehaviour//Hero is the Parent class
{
    public GameObject enemy;
    protected virtual void Start()
    {
        enemy = GameObject.FindWithTag("Enemy");
    }
    protected void Move()//abstraction
    {
        if(enemy != null)
        transform.position = Vector3.MoveTowards(transform.position, enemy.transform.position, 2*Time.deltaTime);
    }

    protected virtual void DealDamage()//abstraction and inheritance
    {
        if(enemy != null)
        enemy.GetComponent<Enemy>().enemyHP -= 10;
    }

}
