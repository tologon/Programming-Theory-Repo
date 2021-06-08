using UnityEngine;

public class SimpleButton : MonoBehaviour
{
    // POLYMORPHISM
    // ABSTRACTION
    public virtual void Action()
    {
        Debug.Log("SimpleButton -> ACTION!");
    }
}
