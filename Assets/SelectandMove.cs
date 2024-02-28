using UnityEngine;

public class SelectandMove : MonoBehaviour
{
    GameObject selected;
    Vector2 movetopoint;
    public void NextAction(Touch touch, Camera mainCamera)
    {
        Collider2D hit = Physics2D.OverlapPoint(mainCamera.ScreenToWorldPoint(touch.position));
        SelectObj(hit);
        if (selected != null)
        {
            Move(touch, mainCamera);
        }
    }
    public void Move(Touch touch, Camera mainCamera)
    {
        movetopoint = mainCamera.ScreenToWorldPoint(touch.position);
    }
    private void Update()
    {
        if (selected)
        {
            selected.gameObject.transform.position = Vector2.MoveTowards(selected.transform.position, movetopoint, 5f * Time.deltaTime);
        }
    }
    void SelectObj(Collider2D hit) {
        if (hit != null)
        {
            if (selected != null)
            {
                selected.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
            }
            selected = hit.transform.gameObject;
            hit.gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 0, 0);
        }
    }
}