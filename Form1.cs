using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DepremParse
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private DataTable SemaYarat()
    {
      DataTable dt = new DataTable();
      DataColumn tarih;
      DataColumn saat;
      DataColumn yer;
      // Dosyaya uygun sayida kolon uret
      tarih = new DataColumn("Tarih", typeof(string));
      dt.Columns.Add(tarih);
      saat = new DataColumn("Saat", typeof(string));
      dt.Columns.Add(saat);
      yer = new DataColumn("Yer", typeof(string));
      dt.Columns.Add(yer);
      
      return dt;
      
    }

    private DataTable SatirSatirYukle(string FileName)
    {
      DataTable sonuc = SemaYarat();
      StreamReader sr = new StreamReader(FileName);
      
      try
      {
        // satir baslangici gelene kadar sonraki satira gec
        // (readline her satir okuyusunda sonraki satira gecer)
        while(sr.ReadLine().Substring(0,4)!="----") ;
        // simdi ilk tarih satirindayiz, substring kullanarak tarih, saat ve yer alinabilir
        string simdikisatir;
        simdikisatir = sr.ReadLine();
        while (simdikisatir != "" && simdikisatir != null)
        {
          sonuc.Rows.Add(new string[] {
            simdikisatir.Substring(0,10), // tarih
            simdikisatir.Substring(11,8),  // saat
            simdikisatir.Substring(71)  // yer            
          });
          simdikisatir = sr.ReadLine();
           
        }
      }
      finally
      {
        sr.Close();
      }
      return sonuc;
    }

    public void filtrele()
    {
        try
        {
                
                DataTable dt = (DataTable)this.dg.DataSource;
                DataView dv = new DataView(dt);
                dv.RowFilter = "Yer like " + "'%" + tbFilter.Text + "%'";
                dg.DataSource = dv;
                int satir = dg.Rows.Count - 1;
                tbsonuc.Text = "Aradığınız Yer içinToplam Deprem Sayısı: " + satir.ToString();
        }
        catch
        {
            
                MessageBox.Show("Arama Kriterinize Uygun Sonuç Bulunamadı...");
        }
        
        
    }

    private void tsbParse_Click(object sender, EventArgs e)
    {
      dg.DataSource = SatirSatirYukle(Application.StartupPath + "\\depremler.txt");
        
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
        filtrele();
    }
  }
}