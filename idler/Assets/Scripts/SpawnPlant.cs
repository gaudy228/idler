using System.Collections;
using UnityEngine;

public class SpawnPlant : MonoBehaviour
{
    [SerializeField] private GameObject Plant;
    [SerializeField] private GameObject prefabsPlant;
    [SerializeField] private float minTimeSpawn;
    [SerializeField] private float maxTimeSpawn;
    [SerializeField] private Transform stop;
    [SerializeField] private MaterialsForBild material;
    private bool exist = true;
    private void Update()
    {
        if(Plant == null && exist)
        {
            StartCoroutine(TimeToSpawn(Random.Range(minTimeSpawn, maxTimeSpawn)));
            exist = false;
        }
    }
    public IEnumerator TimeToSpawn(float time)
    {
        float elapsedTime = 0f;
        while (elapsedTime <= time)
        {
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        Plant = Instantiate(prefabsPlant, transform.position, Quaternion.identity);
        Plant.GetComponent<PlantWithObj>().Initiation(stop, material);
        Plant.transform.SetParent(transform, false);
        exist = true;
    }
}
