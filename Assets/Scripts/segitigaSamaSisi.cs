using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class segitigaSamaSisi : MonoBehaviour
{
    public InputField inputSisi;
    public GameObject objSegitiga;
    private double valueTinggi;
    private float valueSisi;
    public GameObject alertMin;
    public GameObject alertMax;


    public void Start()
    {
        alertMin.SetActive(false);
        Text hitungLuas = GameObject.Find("hitungLuas").GetComponent<Text>();
        Text hasilLuas = GameObject.Find("hasilLuas").GetComponent<Text>();
        Text hitungKeliling = GameObject.Find("hitungKeliling").GetComponent<Text>();
        Text hasilKeliling = GameObject.Find("hasilKeliling").GetComponent<Text>();

        double vS = (objSegitiga.transform.localScale.x * 0.1 * 0.6) + 0.4;

        valueSisi = Convert.ToSingle(vS);
        //inputTinggi.text = valueTinggi.ToString();
        inputSisi.text = valueSisi.ToString();

        hitungLuas.text = "Luas = " + valueSisi + "^2 / 4 * √3";
        hasilLuas.text = "Luas = " + Math.Round(Math.Pow(valueSisi, 2) * 0.25 * Math.Sqrt(3), 2) + "cm";
        hitungKeliling.text = "Keliling = 3 * " + valueSisi;
        hasilKeliling.text = "Keliling = " + 3 * valueSisi + "cm";
    }
    public void GetInput()
    {
        alertMin.SetActive(false);
        alertMax.SetActive(false);
        Text hitungLuas = GameObject.Find("hitungLuas").GetComponent<Text>();
        Text hasilLuas = GameObject.Find("hasilLuas").GetComponent<Text>();
        Text hitungKeliling = GameObject.Find("hitungKeliling").GetComponent<Text>();
        Text hasilKeliling = GameObject.Find("hasilKeliling").GetComponent<Text>();
        
        valueSisi = float.Parse(inputSisi.text);
        float valueSisi2 = Convert.ToSingle((valueSisi - 0.4) * 10 / 0.6);

        double luas = Math.Pow(valueSisi, 2) * 0.25 * Math.Sqrt(3);
        double valueTinggi = (2 * luas) / valueSisi;
        float valueTinggi2 = Convert.ToSingle(valueTinggi);

        if (valueSisi < 3.57)
        {
            alertMin.SetActive(true);
        }
        else if (valueSisi > 20)
        {
            alertMax.SetActive(true);
        }
        else
        {
            alertMin.SetActive(false);
            alertMax.SetActive(false);
           
        }
        objSegitiga.transform.localScale = new Vector3(valueSisi2, valueSisi2, valueSisi2);

        hitungLuas.text = "Luas = " + valueSisi + "^2 / 4 * √3";
        hasilLuas.text = "Luas = " + Math.Round(Math.Pow(valueSisi, 2) * 0.25 * Math.Sqrt(3), 2) + "cm";
        hitungKeliling.text = "Keliling = 3 * " + valueSisi;
        hasilKeliling.text = "Keliling = " + Math.Round(3 * valueSisi, 2) + "cm";


    }

}
