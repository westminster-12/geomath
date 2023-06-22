using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class tabung : MonoBehaviour
{
    public InputField inputRadius;
    public InputField inputTinggi;
    public GameObject cube;
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

        double vR = (cube.transform.localScale.x * 0.1 * 2.4 + 0.8) / 2;
        double vT = (cube.transform.localScale.y * 0.1 * 1.7) - 0.5;

        float valueRadius = Convert.ToSingle(vR / 2); ;
        float valueTinggi = Convert.ToSingle(vT);
        inputRadius.text = valueRadius.ToString();
        inputTinggi.text = valueTinggi.ToString();

        double luas = Math.Round(2 * 3.14 * valueRadius * (valueRadius + valueTinggi), 2);
        double volume = Math.Round(3.14 * (valueRadius * valueRadius) * valueTinggi, 2);

        hitungLuas.text = "Luas = 2 * 3.14 * " + valueRadius + " * (" + valueRadius + " + " + valueTinggi + ")";
        hasilLuas.text = "Luas = " + Math.Round(luas, 2) + "cm";
        hitungVolume.text = "Volume = 3.14 * " + valueRadius + "^2" + " * " + valueTinggi;
        hasilVolume.text = "Volume = " + Math.Round(volume, 2) + "cm";
    }

    public void GetInput()
    {
        
        Text hitungLuas = GameObject.Find("hitungLuas").GetComponent<Text>();
        Text hasilLuas = GameObject.Find("hasilLuas").GetComponent<Text>();
        Text hitungVolume = GameObject.Find("hitungVolume").GetComponent<Text>();
        Text hasilVolume = GameObject.Find("hasilVolume").GetComponent<Text>();

        float valueRadius = float.Parse(inputRadius.text);
        float valueTinggi = float.Parse(inputTinggi.text);

        alertMax.SetActive(false);
        alertMin.SetActive(false);
        if (valueRadius < 2.35 || valueTinggi < 5.61)
        {
            alertMin.SetActive(true);
        }
        else if (valueRadius > 10 || valueTinggi > 20)
        {
            alertMax.SetActive(true);
        }
        else
        {
            alertMin.SetActive(false);
            alertMax.SetActive(false);
        }

        double luas = Math.Round(2 * 3.14 * valueRadius * (valueRadius + valueTinggi), 2);
        double volume = Math.Round(3.14 * (valueRadius * valueRadius) * valueTinggi, 2);

        float valueRadius2 = Convert.ToSingle((valueRadius * 2 - 0.8) * 10 / 2.4);
        float valueTinggi2 = Convert.ToSingle((valueTinggi + 0.5) * 10 / 1.7);
        cube.transform.localScale = new Vector3(valueRadius2 * 2, valueTinggi2, valueRadius2 * 2);

        hitungLuas.text = "Luas = 2 * 3.14 * " + valueRadius + " * (" + valueRadius + " + " + valueTinggi + ")";
        hasilLuas.text = "Luas = " + Math.Round(luas, 2) + "cm";
        hitungVolume.text = "Volume = 3.14 * " + valueRadius + "^2" + " * " + valueTinggi;
        hasilVolume.text = "Volume = " + Math.Round(volume, 2) + "cm";
    }
}
