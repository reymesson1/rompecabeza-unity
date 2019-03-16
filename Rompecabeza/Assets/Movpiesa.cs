using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movpiesa : MonoBehaviour, IPointerDownHandler
{

    // Use this for initialization

    private bool condition = false;
    private float positionsaver;
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        if (Input.GetMouseButton(0) && condition == true)
        {
            //Debug.Log("Input.Precionado");
            if (Input.GetButton("MoverP") == true)
            {
                this.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
                
            }
        }

        else
        {
            condition = false;
        }



    }

    public void OnPointerDown(PointerEventData eventData)
    {
        condition = true;

    }

    //private void OnMouseDown()
    //{
    //    if (Input.GetButton("MoverP") == true)
    //    {
    //        this.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
    //    }
    //}

    //private void OnMouseDown()
    //{
    //    Debug.Log("Apretado");
    //    condition = true;

    //}
}
