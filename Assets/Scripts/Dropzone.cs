using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Dropzone : MonoBehaviour, IDropHandler {

    public Sprite orb1Img;
    public Sprite checkmark;

    public int red = 0, green = 0, blue = 0, yellow = 0;
    public int star = 0, moon = 0, sun = 0;
    public bool[] Ciclos = new bool[8]; 

    
    public void OnDrop(PointerEventData e) {
        Debug.Log("OnDrop to " + gameObject.name);

        Drag d = e.pointerDrag.GetComponent<Drag>();
        if (d != null){
            d.currentParent = this.transform;
        }

        VerCarta(e);

        if (star > 0){
            Ciclos[0] = true;
            var img = GameObject.Find("Orb1");
            img.GetComponent<Image>().sprite = orb1Img;
            Color a = img.GetComponent<Image>().color;
            a.a = 255;
            img.GetComponent<Image>().color = a;

            var orb1 = GameObject.Find("Ciclo 1");
            orb1.GetComponent<Toggle>().isOn = true;


        }




    }
    private void Update()
    {
        
    }


    public void VerCiclo(){

        if (Ciclos[0] == true) {


        }

    }
    public void VerCarta(PointerEventData eventData)
    {
        if (eventData.pointerDrag.CompareTag("Blue-Star"))
        {

            blue += 1;
            star += 1;

            Debug.Log("blue: " + blue + " star: " + star);
        }

        if (eventData.pointerDrag.CompareTag("Red-Star"))
        {

            red += 1;
            star += 1;

            Debug.Log("red: " + blue + " star: " + star);
        }

        if (eventData.pointerDrag.CompareTag("Green-Star"))
        {

            green += 1;
            star += 1;

            Debug.Log("green: " + blue + " star: " + star);
        }

        if (eventData.pointerDrag.CompareTag("Yellow-Star"))
        {

            yellow += 1;
            star += 1;

            Debug.Log("yellow: " + blue + " star: " + star);
        }

        if (eventData.pointerDrag.CompareTag("Blue-Moon"))
        {

            blue += 1;
            moon += 1;

            Debug.Log("blue: " + blue + " star: " + star);
        }

        if (eventData.pointerDrag.CompareTag("Red-Moon"))
        {

            red += 1;
            moon += 1;

            Debug.Log("red: " + blue + " star: " + star);
        }

        if (eventData.pointerDrag.CompareTag("Green-Moon"))
        {

            green += 1;
            moon += 1;

            Debug.Log("green: " + blue + " star: " + star);
        }

        if (eventData.pointerDrag.CompareTag("Yellow-Moon"))
        {

            yellow += 1;
            moon += 1;

            Debug.Log("yellow: " + blue + " star: " + star);
        }

        if (eventData.pointerDrag.CompareTag("Blue-Sun"))
        {

            blue += 1;
            sun += 1;

            Debug.Log("blue: " + blue + " star: " + star);
        }

        if (eventData.pointerDrag.CompareTag("Red-Sun"))
        {

            red += 1;
            sun += 1;

            Debug.Log("red: " + blue + " star: " + star);
        }

        if (eventData.pointerDrag.CompareTag("Green-Sun"))
        {

            green += 1;
            sun += 1;

            Debug.Log("green: " + blue + " star: " + star);
        }

        if (eventData.pointerDrag.CompareTag("Yellow-Sun"))
        {

            yellow += 1;
            sun += 1;

            Debug.Log("yellow: " + blue + " star: " + star);
        }
    }

}
