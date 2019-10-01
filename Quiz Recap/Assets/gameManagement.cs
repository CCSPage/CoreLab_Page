using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManagement : MonoBehaviour
{
    public GameObject platform_prefab;
    public GameObject ballPrefab;
    GameObject b;
    float width;
    float height;
    Vector2 screenUnits;

    // Start is called before the first frame update
    void Start()
    {
       for (int i = -8; i <= 8; i+= 2) 
        {
            Instantiate(platform_prefab, new Vector2(i,-2), Quaternion.identity);
        }

            width = Screen.width;
            height = Screen.height;

        b = Instantiate(ballPrefab, new Vector2(Random.Range(-8,8),5),Quaternion.identity);
        Vector2 screenUnits = Camera.main.ScreenToWorldPoint(new Vector3(width, height, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (b.transform.position.x <= screenUnits.x * -1 || b.transform.position.x >= screenUnits.x || b.transform.position.y <= screenUnits.y * -1 || b.transform.position.y >= screenUnits.y)
        {
            Destroy(b);
            b = Instantiate(ballPrefab, new Vector2(Random.Range(-8, 8), 5), Quaternion.identity);
        }

    }
}

