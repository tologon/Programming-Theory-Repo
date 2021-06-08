using UnityEngine;
using TMPro;

public class SizeButton : SimpleButton
{
    [SerializeField] private TextMeshProUGUI _text;

    public override void Action()
    {
        if (_text == null)
        {
            return;
        }

        _text.fontSize = Random.Range(10f, 60f);
    }
}
