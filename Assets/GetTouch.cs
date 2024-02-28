using UnityEngine;

public class GetTouch : MonoBehaviour
{
    
    void Start()
    {
       TouchController.OnSwipe += OnUseSwipeAction;
        TouchController.OnRelease += OnReleaseAction;

    }

    void OnUseSwipeAction(float x, float y)
    {
        Debug.Log("Przesunięto palec o " + x + " horyzontalnie i o " + y + 
            "wertykalnie względem poprzedniej pozycji");

    }

    void OnReleaseAction()
    {
        Debug.Log("Puszczono przytrzymanie");

    }
}
