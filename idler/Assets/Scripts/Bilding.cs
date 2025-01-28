using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Bilding : MonoBehaviour
{
    private Resources resources;
    [SerializeField] private int countWoodForBuy;
    [SerializeField] private int countMetalForBuy;
    [SerializeField] private GameObject RedFrame;
    [SerializeField] private TextMeshProUGUI whatIsIt;
    [SerializeField] private string buyText;
    private bool isBuy = false;
    private void Start()
    {
        whatIsIt.text = buyText;
        resources = GameObject.FindWithTag("ManagerResources").GetComponent<Resources>();
    }
    public void Buy()
    {
        if(resources.wood >= countWoodForBuy && resources.metal >= countMetalForBuy && !isBuy)
        {
            Destroy(RedFrame);
            Destroy(whatIsIt);
            resources.wood -= countWoodForBuy;
            resources.metal -= countMetalForBuy;
            resources.TextUpDate();
            gameObject.GetComponent<Image>().color = Color.white;
            gameObject.GetComponent<Button>().enabled = false;
            isBuy = true;
        }
    }
}
