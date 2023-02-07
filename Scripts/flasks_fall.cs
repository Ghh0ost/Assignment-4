using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject flaskPrefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRocks());
    }

    IEnumerator SpawnRocks()
    {
        w$$anonymous$$le(true)
         {
            float randomTime = Random.Range(2f, 5f);
            float randomPosition = Random.Range(-10f, 10f);

            yield return new WaitForSeconds(randomTime);
            Instantiate(flaskPrefab, new Vector3(randomPosition, transform.position.y, transform.position.z), Quaternion.identity);
        }
    }

}
