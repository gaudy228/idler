using UnityEngine;
using UnityEngine.UI;

public class PlantWithObj : MonoBehaviour
{
    [SerializeField] private int countClickPlant;
    [SerializeField] private int countClickObj;
    [SerializeField] private float speed;
    [SerializeField] private GameObject Plant;
    [SerializeField] private GameObject Obj;
    [SerializeField] private int countGetMaterials;
    private Transform stop;
    private bool plantKill = false;
    private MaterialsForBild materials;
    private void Start()
    {
        Obj.GetComponent<Button>().enabled = false;
    }
    public void ClickObject()
    {
        if(countClickPlant > 0)
        {
            countClickPlant--;
        }
        if(countClickPlant <= 0 && !plantKill)
        {
            Destroy(Plant);
            Obj.GetComponent<Button>().enabled = true;
            plantKill = true;
        }
        else if (plantKill)
        {
            countClickObj--;
        }
        if(countClickObj <= 0)
        {
            int rnd = Random.Range(0, 2);
            if(rnd == 0)
            {
                materials.SetMaterialsWood(countGetMaterials);
            }
            if(rnd == 1)
            {
                materials.SetMaterialsMetal(countGetMaterials);
            }
            Destroy(gameObject);
        }
    }
    public void Initiation(Transform trans, MaterialsForBild mater)
    {
        stop = trans;
        materials = mater;
    }
    private void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        if(transform.position.x >= stop.position.x)
        {
            Destroy(gameObject);
        }
    }
}
