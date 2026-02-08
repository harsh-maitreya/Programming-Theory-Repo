using UnityEngine;

public class Hero_2 : Hero//child class, inheriting all methods from Hero class
{
    protected override void DealDamage()//method overriding; inheritance
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
        base.Start();//inheritance
    }
    private void Update()
    {
        Move();
    }
}
