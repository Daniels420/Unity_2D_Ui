using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//Piesaista pointer interfeisu
public class Objektuparvietosana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform transformacijuLogs;
    public Canvas kanva;

    private void Awake()
    {
    transformacijuLogs = GetComponent<RectTransform>();
    }
//Funkcija nostrādā,kad uzklikšķināts uz pārvietojamā objekta
public void OnPointerDown(PointerEventData notikums)
    {  
Debug.Log("Uzsākta pārvietošana!");
    }
    //Funkcija nostrādā uzsākot pārvietošanu
    
    public void OnBeginDrag(PointerEventData notikums)
    {
        Debug.Log("Vilkšana pabeigta!");
    }
    
    //Funkcija nostrādā pārvietošanas brīdī
    public void OnDrag(PointerEventData notikums)
    
    {
        transformacijuLogs.anchoredPosition += notikums.delta/kanva.scaleFactor;
    }

}   


