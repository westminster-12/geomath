using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class kerucut : MonoBehaviour
{
    public InputField inputRadius;
    public InputField inputTinggi;
    public GameObject objKerucut;
    private double valueRadius;
    private double valueTinggi;
    public GameObject alertMin;
    public GameObject alertMax;


    public void Start()
    {
        alertMin.SetActive(false);
        alertMax.SetActive(false);
        Text hitungLuas = GameObject.Find("hitungLuas").GetComponent<Text>();
        Text hasilLuas = GameObject.Find("hasilLuas").GetComponent<Text>();
        Text hitungVolume = GameObject.Find("hitungVolume").GetComponent<Text>();
        Text hasilVolume = GameObject.Find("hasilVolume").GetComponent<Text>();

        double vR = ((objKerucut.transform.localScale.x * 0.1) + 2) / 2;
        double vT = ((objKerucut.transform.localScale.y * 0.1) + 3);
        float valueRadius = Convert.ToSingle(vR);
        float valueTinggi = Convert.ToSingle(vT);

        inputRadius.text = valueRadius.ToString();
        inputTinggi.text = valueTinggi.ToString();


        double s = Math.Sqrt(valueRadius * valueRadius + valueTinggi * valueTinggi);
        double phir2 = 3.14 * (valueRadius * valueRadius);
        double phirs = 3.14 * valueRadius * s;
        double luas = phir2 + phirs;
        double luas2 = Math.Round(luas, 2);
        double volume = 3.14 * (valueRadius * valueRadius) * valueTinggi / 3;
        double volume2 = Math.Round(volume, 2);


        hitungLuas.text = "Luas = 3.14 * " + valueRadius + "^2 + 3.14" + " * " + valueRadius + " * (√(" + valueRadius + "^2+" + valueTinggi + "^2))";
        hasilLuas.text = "Luas = " + luas2 + "cm";
        hitungVolume.text = "Volume = 1/3 * 3.14 * " + valueRadius + "^2" + " * " + valueTinggi;
        hasilVolume.text = "Volume = " + volume2 + "cm";
    }
    public void GetInput()
    {
        alertMin.SetActive(false);
        alertMax.SetActive(false);

        Text hitungLuas = GameObject.Find("hitungLuas").GetComponent<Text>();
        Text hasilLuas = GameObject.Find("hasilLuas").GetComponent<Text>();
        Text hitungVolume = GameObject.Find("hitungVolume").GetComponent<Text>();
        Text hasilVolume = GameObject.Find("hasilVolume").GetComponent<Text>();

        float valueRadius = float.Parse(inputRadius.text);
        float valueTinggi = float.Parse(inputTinggi.text);

        float valueRadius2 = Convert.ToSingle(((valueRadius * 2) - 2) * 10);
        float valueTinggi2 = Convert.ToSingle((valueTinggi - 3) * 10);
        objKerucut.transform.localScale = new Vector3(valueRadius2, valueTinggi2, valueRadius2);

        if (valueRadius < 4.5 || valueTinggi < 10) {
            alertMin.SetActive(true);
        }
        else if (valueRadius > 10|| valueTinggi > 20)
        {
            alertMax.SetActive(true);
        }
        else { 
        
            alertMin.SetActive(false);
            alertMax.SetActive(false);

           
        }

        double s = Math.Sqrt(valueRadius * valueRadius + valueTinggi * valueTinggi);
        double phir2 = 3.14 * (valueRadius * valueRadius);
        double phirs = 3.14 * valueRadius * s;
        double luas = phir2 + phirs;
        double luas2 = Math.Round(luas, 2);
        double volume = 3.14 * (valueRadius * valueRadius) * valueTinggi / 3;
        double volume2 = Math.Round(volume, 2);

        hitungLuas.text = "Luas = 3.14 * " + valueRadius + "^2 + 3.14" + " * " + valueRadius + " * (√(" + valueRadius + "^2+" + valueTinggi + "^2))";
        hasilLuas.text = "Luas = " + luas2 + "cm";
        hitungVolume.text = "Volume = 1/3 * 3.14 * " + valueRadius + "^2" + " * " + valueTinggi;
        hasilVolume.text = "Volume = " + volume2 + "cm";


    }

}