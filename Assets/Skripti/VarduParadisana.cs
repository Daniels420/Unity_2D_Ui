using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Jāimportē,lai varētu strādāt ar UI elementiem
using UnityEngine.UI;

public class VarduParadisana : MonoBehaviour {
    //Mainīgajā saglabās tekstu ko raksta teksta laukā
string teksts;
public GameObject ievadesLauks;
public GameObject tekstaAttelosana;
public void uzglabatTekstu()
{
//funkcija 
teksts = ievadesLauks.GetComponent<Text>().text;
tekstaAttelosana.GetComponent<Text>().text = "Sveiks "+teksts.ToUpper()+ "!"; 
}
}