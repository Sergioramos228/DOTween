using UnityEngine;
using TMPro;

public class DropdownToText : MonoBehaviour
{
    public TMP_Text Text;
    public TMP_Dropdown Dropdown;

    public void DropDownToText(int num)
    {
        Text.text = Dropdown.options[num].text;
    }
}
