using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class bujurSangkar : MonoBehaviour
{
    public InputField inputSisi;
    public GameObject objBujurSangkar;
    private float valueSisi;
    public GameObject alertMin;
    public GameObject alertMax;


    public void Start()
    {
        Text hitungLuas = GameObject.Find("hitungLuas").GetComponent<Text>();
        Text hasilLuas = GameObject.Find("hasilLuas").GetComponent<Text>();
        Text hitungKeliling = GameObject.Find("hitungKeliling").GetComponent<Text>();
        Text hasilKeliling = GameObject.Find("hasilKeliling").GetComponent<Text>();


        double vS = objBujurSangkar.transform.localScale.x * 0.01 * 0.6 + 0.2;
        valueSisi = Convert.ToSingle(vS);
        
        inputSisi.text = valueSisi.ToString();

        hitungLuas.text = "Luas = " + valueSisi + " * " + valueSisi;
        hasilLuas.text = "Luas = " + Math.Round(valueSisi * valueSisi, 2) + "cm";
        hitungKeliling.text = "Keliling = 4 * " + valueSisi;
        hasilKeliling.text = "Keliling = " + Math.Round(4 * valueSisi, 2) + "cm";
    }
    public void GetInput()
    {
        alertMin.SetActive(false);
        alertMax.SetActive(false);
        Text hitungLuas = GameObject.Find("hitungLuas").GetComponent<Text>();
        Text hasilLuas = GameObject.Find("hasilLuas").GetComponent<Text>();
        Text hitungKeliling = GameObject.Find("hitungKeliling").GetComponent<Text>();
        Text hasilKeliling = GameObject.Find("hasilKeliling").GetComponent<Text>();

        valueSisi= float.Parse(inputSisi.text);
        float valueSisi2 = Convert.ToSingle((valueSisi - 0.2) * 100 / 0.6);
        
        if (valueSisi < 3.43)
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
        objBujurSangkar.transform.localScale = new Vector3(valueSisi2, valueSisi2, valueSisi2);

        hitungLuas.text = "Luas = " + valueSisi + " * " + valueSisi;
        hasilLuas.text = "Luas = " + Math.Round(valueSisi * valueSisi, 2) + "cm";
        hitungKeliling.text = "Keliling = 4 * " + valueSisi;
        hasilKeliling.text = "Keliling = " + Math.Round(4 * valueSisi, 2) + "cm";


    }

}
