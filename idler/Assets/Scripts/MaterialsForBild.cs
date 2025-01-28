using TMPro;
using UnityEngine;

public class MaterialsForBild : MonoBehaviour
{
    public int wood;
    public int metal;
    [SerializeField] private TextMeshProUGUI woodText;
    [SerializeField] private TextMeshProUGUI metalText;
    public void SetMaterialsWood(int Materials)
    {
        wood += Materials;
        TextUpDate();
    }
    public void SetMaterialsMetal(int Materials)
    {
        metal += Materials;
        TextUpDate();
    }
    public void TextUpDate()
    {
        woodText.text = $"Доски: {wood}";
        metalText.text = $"Металл: {metal}";
    }
}
