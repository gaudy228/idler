using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Bilding : MonoBehaviour
{
    private MaterialsForBild materials;
    [SerializeField] private int countWoodForBuy;
    [SerializeField] private int countMetalForBuy;
    [SerializeField] private GameObject RedFrame;
    [SerializeField] private TextMeshProUGUI whatIsIt;
    [SerializeField] private string buyText;
    private bool isBuy = false;
    private void Start()
    {
        whatIsIt.text = buyText;
        materials = gameObject.transform.parent.GetComponent<MaterialsForBild>();
    }
    public void Buy()
    {
        if(materials.wood >= countWoodForBuy && materials.metal >= countMetalForBuy && !isBuy)
        {
            Destroy(RedFrame);
            materials.wood -= countWoodForBuy;
            materials.metal -= countMetalForBuy;
            materials.TextUpDate();
            gameObject.GetComponent<Image>().color = Color.white;
            gameObject.GetComponent<Button>().enabled = false;
            isBuy = true;
        }
    }
}
