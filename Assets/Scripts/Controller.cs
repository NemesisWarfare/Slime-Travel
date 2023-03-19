using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    public Data data;

    public TMP_Text gooText;

    private void Start()
    {
        data = new Data();
        data.goo = 1;
    }

    private void Update()
    {
        gooText.text = data.goo + " Goo";
        data.goo *= 100;
        print(data.goo);
    }

    public void GenerateGoo()
    {
        data.goo += 1;
    }
}
