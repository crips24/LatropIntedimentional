using UnityEngine;
using UnityEngine.UI;

public class DisplayCount : MonoBehaviour
{
    public Text test;

    private void Start()
    {
        test = GetComponent<Text>();
        if (test == null)
        {
            Debug.LogError("Text component not found!");
        }
    }

    private void Update()
    {
        test.text = "Issoupes :  " + Disappear.count;
        Debug.Log(Disappear.count);
        if (Disappear.count == 7)
        {
            test.text = "Issoupes :" + Disappear.count +"  \nbravo! vous avez tout trouvé !";
        }
    }
}
