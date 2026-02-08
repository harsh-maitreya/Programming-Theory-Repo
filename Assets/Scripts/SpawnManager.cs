using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject Hero_1Prefab;
    [SerializeField]
    private GameObject Hero_2Prefab;
    [SerializeField]
    private GameObject Enemy;


    private void Start()
    {
        Instantiate(Enemy, new Vector3(0,1,4), Enemy.transform.rotation);
    }
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Hero_1Prefab, new Vector3(-3,1,-4), Hero_1Prefab.transform.rotation);
            if (GameObject.FindWithTag("Hero_2") != null)
            {
                Destroy(GameObject.FindWithTag("Hero_2"));
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            Instantiate(Hero_2Prefab, new Vector3(3, 1, -4), Hero_2Prefab.transform.rotation);
            if (GameObject.FindWithTag("Hero_1") != null)
            {
                Destroy(GameObject.FindWithTag("Hero_1"));
            }
        }
    }
}
