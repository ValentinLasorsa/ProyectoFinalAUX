using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreguntasNegro : MonoBehaviour
{
     public bool Condicion;
    public string Pregunta1 { get; set; }
    public string Pregunta2 { get; set; }
    public string Pregunta3 { get; set; }
    public string Pregunta4 { get; set; }
    public PJ BlasZanetti;
    public PJ ErnestoMuller;
    public PJ JuanManuelDelPiero;
    public PJ JuanPabloBenavidez;
    public PJ LauraRochet;
    public PJ MiguelAngelRomero;
    public PJ NataliaFernandez;
    public PJ RobertoBanzas;
    public PJ RocioRodriguez;
    public PJ RominaSalgado;
    public PJ RomualdoTrass;
    public PJ TamaraLaprida;
    void Start()
    {
    BlasZanetti = GameObject.Find("BlasZanetti").GetComponent<PJ>();
    ErnestoMuller = GameObject.Find("ErnestoMuller").GetComponent<PJ>();
    JuanManuelDelPiero = GameObject.Find("JuanManuelDelPiero").GetComponent<PJ>();
    JuanPabloBenavidez = GameObject.Find("JuanPabloBenavidez").GetComponent<PJ>();
    LauraRochet = GameObject.Find("LauraRochet").GetComponent<PJ>();
    MiguelAngelRomero = GameObject.Find("MiguelAngelRomero").GetComponent<PJ>();
    NataliaFernandez = GameObject.Find("NataliaFernandez").GetComponent<PJ>();
    RobertoBanzas = GameObject.Find("RobertoBanzas").GetComponent<PJ>();
    RocioRodriguez = GameObject.Find("RocioRodriguez").GetComponent<PJ>();
    RominaSalgado = GameObject.Find("RominaSalgado").GetComponent<PJ>();
    RomualdoTrass = GameObject.Find("RomualdoTrass").GetComponent<PJ>();
    TamaraLaprida = GameObject.Find("TamaraLaprida").GetComponent<PJ>();

    }

 private void PreguntasPeloDescarte(string Pregunta1, string Pregunta2, string Pregunta3)
{
    
   if (Condicion != true)
{
    Destroy(MiguelAngelRomero.gameObject);
    Destroy(RocioRodriguez.gameObject);
    Destroy(RominaSalgado.gameObject);
    Destroy(TamaraLaprida.gameObject);

  
}
else
{
    Destroy(JuanManuelDelPiero.gameObject);
    Destroy(JuanPabloBenavidez.gameObject);
    Destroy(RomualdoTrass.gameObject);
    Destroy(BlasZanetti.gameObject);
    Destroy(ErnestoMuller.gameObject);
    Destroy(LauraRochet.gameObject);
    Destroy(RobertoBanzas.gameObject); 
    Destroy(NataliaFernandez.gameObject);
   
}
}
}