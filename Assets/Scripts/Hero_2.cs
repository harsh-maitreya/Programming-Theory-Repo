using UnityEngine;

public class Hero_2 : Hero
{
    protected override void DealDamage()
    {
        if (enemy != null)
            enemy.GetComponent<Enemy>().enemyHP -= 30;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            DealDamage();
            Debug.Log("Damage Dealt = " + 30);
            Debug.Log(enemy.GetComponent<Enemy>().enemyHP);
        }
    }
    protected override void Start()
    {
        base.Start();
    }
    private void Update()
    {
        Move();
    }
}
