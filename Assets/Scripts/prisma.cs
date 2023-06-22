using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class prisma : MonoBehaviour
{
    public InputField inputTinggi;
    public InputField inputPanjangSisi;
    public GameObject Objprisma;
    double valueKelilingAlas;
    double valueLuasAlas;
    double valueLuas;
    double valueVolume;
    double valuePanjangSisi;
    public GameObject alertMin;
    public GameObject alertMax;


    public void Start()
    {
        alertMin.SetActive(false);
        alertMax.SetActive(false);
        Text hitungLuasAlas = GameObject.Find("hitungLuasAlas").GetComponent<Text>();
        Text hasilLuasAlas = GameObject.Find("hasilLuasAlas").GetComponent<Text>();
        Text hitungLuas = GameObject.Find("hitungLuas").GetComponent<Text>();
        Text hasilLuas = GameObject.Find("hasilLuas").GetComponent<Text>();
        Text hitungVolume = GameObject.Find("hitungVolume").GetComponent<Text>();
        Text hasilVolume = GameObject.Find("hasilVolume").GetComponent<Text>();

        /* valueTinggi = Objprisma.transform.localScale.y;
        valuePanjangSisi = Objprisma.transform.localScale.z; */

        double vP = (Objprisma.transform.localScale.x * 0.1 * 0.6) + 0.2;
        double vT0 = (Objprisma.transform.localScale.y * 0.1 * 1.1) + 0.2;
        double vT = Math.Round(vT0, 2);
        float valuePanjangSisi = Convert.ToSingle(vP);
        float valueTinggi = Convert.ToSingle(vT);
        
        inputTinggi.text = valueTinggi.ToString();
        inputPanjangSisi.text = valuePanjangSisi.ToString();


        //hitung luas alas
        double valueLuasAlas = 0.5 * valuePanjangSisi * valueTinggi;
        double valueLuasAlas2 = Math.Round(valueLuasAlas, 2);
        hitungLuasAlas.text = "La = 1/2 * " + valuePanjangSisi + "*" + valueTinggi;
        hasilLuasAlas.text = "La =" + valueLuasAlas2;
        //Luas permukaan prisma segitiga = (2 x luas alas) + (3 x luas salah satu bidang tegak)
        valueLuas = (2 * valueLuasAlas2) + (3 * (valueTinggi * valuePanjangSisi));
        hitungLuas.text = "L = (2 * " + valueLuasAlas2 + ") + (3 * (" + valueTinggi + "*" + valuePanjangSisi + ")";
        hasilLuas.text = "L =" + Math.Round(valueLuas, 2);
        //hitung volume
        valueVolume = valueLuasAlas * valueTinggi;
        double valueVolume2 = Math.Round(valueVolume, 2);
        hitungVolume.text = "V =" + valueLuasAlas2 + "*" + valueTinggi;
        hasilVolume.text = "V =" + valueVolume2;

    }
    public void GetInput()
    {
        alertMin.SetActive(false);
        alertMax.SetActive(false);

        Text hitungLuasAlas = GameObject.Find("hitungLuasAlas").GetComponent<Text>();
        Text hasilLuasAlas = GameObject.Find("hasilLuasAlas").GetComponent<Text>();
        Text hitungLuas = GameObject.Find("hitungLuas").GetComponent<Text>();
        Text hasilLuas = GameObject.Find("hasilLuas").GetComponent<Text>();
        Text hitungVolume = GameObject.Find("hitungVolume").GetComponent<Text>();
        Text hasilVolume = GameObject.Find("hasilVolume").GetComponent<Text>();

        float valuePanjangSisi = float.Parse(inputPanjangSisi.text);
        float valueTinggi = float.Parse(inputTinggi.text);

        if (valuePanjangSisi < 6.67 || valueTinggi < 6.79)
        {
            alertMin.SetActive(true);
        }
        else if (valuePanjangSisi > 20 || valueTinggi > 20)
        {
            alertMax.SetActive(true);
        }
        else
        {
            alertMin.SetActive(false);
            alertMax.SetActive(false);
        }

        float valuePanjangSisi2 = Convert.ToSingle((valuePanjangSisi - 0.2) * 10 / 0.6);
        float valueTinggi2 = Convert.ToSingle((valueTinggi - 0.2) * 10 / 1.1);
        Objprisma.transform.localScale = new Vector3(valuePanjangSisi2, valueTinggi2, valuePanjangSisi2);

        //hitung luas alas
        double valueLuasAlas = 0.5 * valuePanjangSisi * valueTinggi;
        double valueLuasAlas2 = Math.Round(valueLuasAlas, 2);
        hitungLuasAlas.text = "La = 1/2 * " + valuePanjangSisi + "*" + valueTinggi;
        hasilLuasAlas.text = "La =" + valueLuasAlas2;
        //Luas permukaan prisma segitiga = (2 x luas alas) + (3 x luas salah satu bidang tegak)
        valueLuas = (2 * valueLuasAlas2) + (3 * (valueTinggi * valuePanjangSisi));
        hitungLuas.text = "L = (2 * " + valueLuasAlas2 + ") + (3 * (" + valueTinggi + "*" + valuePanjangSisi + ")";
        hasilLuas.text = "L =" + Math.Round(valueLuas, 2);
        //hitung volume
        valueVolume = valueLuasAlas * valueTinggi;
        double valueVolume2 = Math.Round(valueVolume, 2);
        hitungVolume.text = "V =" + valueLuasAlas2 + "*" + valueTinggi;
        hasilVolume.text = "V =" + valueVolume2;

    }
}