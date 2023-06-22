using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class bola: MonoBehaviour
{
    public InputField inputRadius; //textbox utk input radius
    public GameObject Objbola; //objek bola
    private float valueRadius; //nilai radius
    double valueVolume;
    double valueVolume2;
    double valueLuas;
    double valueLuas2;
    public GameObject alertMin; //alert jika ukuran < marker
    public GameObject alertMax; //alert jika ukuran < marker


    public void Start()
    {
        //find  text utk rumus
        Text hitungLuas = GameObject.Find("hitungLuas").GetComponent<Text>();
        Text hasilLuas = GameObject.Find("hasilLuas").GetComponent<Text>();
        Text hitungVolume = GameObject.Find("hitungVolume").GetComponent<Text>();
        Text hasilVolume = GameObject.Find("hasilVolume").GetComponent<Text>();

        double vR = Objbola.transform.localScale.x * 0.1;
        float valueRadius = Convert.ToSingle(vR);
        
        inputRadius.text = valueRadius.ToString();

        valueLuas = 4 * 3.14 * (Math.Pow(valueRadius, 2));
        valueLuas2 = Math.Round(valueLuas, 2);
        valueVolume = 1.33333333 * 3.14 * (Math.Pow(valueRadius, 3));
        valueVolume2 = Math.Round(valueVolume, 2);
        hitungLuas.text = "Luas = 4 * π * " + valueRadius + " ^2 ";
        hasilLuas.text = "Luas = " + valueLuas2 + "cm";
        hitungVolume.text = "Volume = 4/3 * π * " + valueRadius + " ^3 ";
        hasilVolume.text = "Volume = " + valueVolume2 + "cm";


    }
    public void GetInput()
    {
        alertMin.SetActive(false);
        alertMax.SetActive(false);

        Text hitungLuas = GameObject.Find("hitungLuas").GetComponent<Text>();
        Text hasilLuas = GameObject.Find("hasilLuas").GetComponent<Text>();
        Text hitungVolume = GameObject.Find("hitungVolume").GetComponent<Text>();
        Text hasilVolume = GameObject.Find("hasilVolume").GetComponent<Text>();

        valueRadius = float.Parse(inputRadius.text); //ambil value dari input field
        float valueRadius2 = Convert.ToSingle(valueRadius * 10);
        
        if (valueRadius > 10)
        {
            alertMax.SetActive(true);
        }
        else if (valueRadius < 3)
        {
            alertMin.SetActive(true);
        }
        else
        {
            alertMin.SetActive(false);
            alertMax.SetActive(false);
        }
        Objbola.transform.localScale = new Vector3(valueRadius2, valueRadius2, valueRadius2);

        valueLuas = 4 * 3.14 * (Math.Pow(valueRadius, 2));
        valueLuas2 = Math.Round(valueLuas, 2);
        valueVolume = 1.33333333 * 3.14 * (Math.Pow(valueRadius, 3));
        valueVolume2 = Math.Round(valueVolume, 2);
        hitungLuas.text = "Luas = 4 * π * " + valueRadius + " ^2 ";
        hasilLuas.text = "Luas = " + valueLuas2 + "cm";
        hitungVolume.text = "Volume = 4/3 * π * " + valueRadius + " ^3 ";
        hasilVolume.text = "Volume = " + valueVolume2 + "cm";
    }
 

}
