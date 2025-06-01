using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GenerarInforme : MonoBehaviour
{
    public Button botoStorageDigit;
    public TextMeshProUGUI informeText;

    public Button botoLocal;
    public TextMeshProUGUI descripLocal;
    public Image imatgeStorage;

    private string escriuText =  "INFORME FINAL DE SOSTENIBILITAT\n\n" +
        "GRUPS D'INTERES:\n" +
        "- Empreses col·laboradores i proveidors.\n" +
        "- Clients i consumidors finals.\n" +
        "- Entitats reguladores i governamentals.\n" +
        "- Comunitats locals i societat.\n\n" +
        "MILLORES IMPLEMENTADES:\n" +
        "- Sha reduit el malbaratament de materials amb tecniques d'economia circular.\n" +
        "- Shan implementat sistemes de digitalitzacio per optimitzar processos.\n" +
        "- L'us d'energies renovables ha disminuit l'impacte ambiental.\n" +
        "- La cadena de subministrament sha optimitzat per reduir emissions de CO2.\n\n" +
        "PROPOSTES DE FUTUR:\n" +
        "- Millorar la integracio amb Blockchain per garantir una traçabilitat mes segura.\n" +
        "- Potenciar la col·laboracio amb empreses certificades amb criteris ASG.\n" +
        "- Invertir en sistemes d'intelligencia artificial per optimitzar la produccio.\n" +
        "- Desenvolupar plans de sostenibilitat a llarg termini per garantir un impacte positiu.";

    
    private string textLocal = "L’emmagatzematge local utilitza servidors físics interns. Ofereix més control, però té alts costos de manteniment.";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        botoStorageDigit.onClick.AddListener(ferInforme);
        botoLocal.onClick.AddListener(premClassic);
    }


    void ferInforme()
    {
        informeText.text = escriuText;

    }

    void premClassic()
    {
        descripLocal.text = textLocal;
        descripLocal.color = Color.black;
        imatgeStorage.color = new Color(0.6f, 0.6f, 0.6f); // Gris per indicar sistema clàssic

        
    }
}
