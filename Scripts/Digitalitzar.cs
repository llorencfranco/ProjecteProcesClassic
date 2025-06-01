using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Digitalitzar : MonoBehaviour
{
    public Image etapaImatge;
    public TextMeshProUGUI textMillores;

    public void DigitalitzaEtapa()
    {
        string millores = "millor";
        etapaImatge.color = Color.green; // Canvia el color per indicar digitalització
        textMillores.text = millores;
    }
}
