using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ListenerBotons : MonoBehaviour
{
    
    public Button botoStorageDigit;
    public Button botoStorageEco;
    public TextMeshProUGUI descripcioEtapa;
    public TextMeshProUGUI milloresDigitStorage;
    public Image imatgeStorage;
    

    private string textDescripcio =  "ENTRADA DE RECURSOS:\n"+
    "L'entrada de recursos és el procés d'incorporar materials, informació o altres elements necessaris per a un projecte o sistema.\n"+
    " En un videojoc, per exemple, podria ser la càrrega d'objectes 3D, textures o sons.";
    
    

    private string milloresStorage = "Podríem digitalitzar l’entrada de recursos amb formularis digitals, fulls de càlcul, aplicacions de gestió, escaneig de documents i bases de dades";
    private string ecoStorageText = "Model d’economia circular aplicat: Reducció de residus i ús eficient dels recursos.";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        botoStorageDigit.onClick.AddListener(digitStorage); 
        botoStorageEco.onClick.AddListener(ecoStorage);

        //botoStorageEco.onClick.AddListener(ecoStorage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void digitStorage()
    {
        imatgeStorage.color = Color.green; // Canvia el color per indicar digitalització
        milloresDigitStorage.text = milloresStorage; 
        descripcioEtapa.text = textDescripcio;
    }

    public void ecoStorage()
    {
        imatgeStorage.color = Color.blue; // Canvia el color per indicar procés circular
        descripcioEtapa.text = textDescripcio;
        milloresDigitStorage.text = ecoStorageText; 
    }
}
