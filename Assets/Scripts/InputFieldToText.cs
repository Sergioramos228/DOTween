using UnityEngine;
using TMPro;

public class InputFieldToText : MonoBehaviour
{
    public TMP_Text Text;

    public void ToText(string row)
    {
        Text.text = row;
    }
}
