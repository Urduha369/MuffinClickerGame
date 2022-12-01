using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDesserts : MonoBehaviour
{
    public List<GameObject> _rainDessert = new List<GameObject>();

    public float timeBetweenDesserts = 0.5f;

    private float ellapsedTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ellapsedTime += Time.deltaTime;
        if (ellapsedTime >= timeBetweenDesserts)
        {
            var position = MyToolbox.GetRandomVector2(-500, 500, 0, 0);
            var dessert = Instantiate(RandomDesserts(), transform);
            dessert.transform.localPosition = position;
            ellapsedTime = 0;
        }
    }
    public GameObject RandomDesserts()
    {
        var index = Random.Range(0, _rainDessert.Count);
        return _rainDessert[index];
    }
}


