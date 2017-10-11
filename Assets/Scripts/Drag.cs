using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler {

    public Transform currentParent = null;

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("OnDrag");
        this.transform.position = eventData.position;
        
    }

    public void OnBeginDrag(PointerEventData eventData) {
       Debug.Log("OnBeginDrag");

        currentParent = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnEndDrag(PointerEventData eventData) {
        Debug.Log("OnEndDrag");

        this.transform.SetParent(currentParent);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
    
}
