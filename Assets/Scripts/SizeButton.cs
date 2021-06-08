using UnityEngine;
using TMPro;

// INHERITANCE
public class SizeButton : SimpleButton
{
    // ENCAPSULATION
    [SerializeField] private TextMeshProUGUI _text;

    // POLYMORPHISM
    // ABSTRACTION
    public override void Action()
    {
        if (_text == null)
        {
            return;
        }

        _text.fontSize = Random.Range(10f, 60f);
    }
}
