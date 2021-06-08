using UnityEngine;
using UnityEngine.UI;

public class ColorButton : SimpleButton
{
    [SerializeField] private Button _button;

    private Color[] _colors;

    public void Start()
    {
        _colors = new Color[] {
            Color.cyan, Color.grey, Color.gray,
            Color.magenta, Color.red, Color.yellow,
            Color.white, Color.green, Color.blue
        };
    }

    public override void Action()
    {
        if (_button == null)
        {
            return;
        }

        ColorBlock colors = _button.colors;
        colors.selectedColor = _colors[Random.Range(0, _colors.Length)];
        _button.colors = colors;
    }
}
