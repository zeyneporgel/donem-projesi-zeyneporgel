﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtKayıtSistemiii
{
    public partial class FrmGiderGuncelle : Form
    {
        public FrmGiderGuncelle()
        {
            InitializeComponent();
        }
        public string elektrik, su, dogalgaz, gida, diger, internet, personel, id;


        SqlBaglantim bgl = new SqlBaglantim();

        private void BtnGuncelle_Click(object sender, EventArgs e)
        { 
            
                SqlCommand komut = new SqlCommand("update Giderler set Elektrik=@p1,Su=@p2,Dogalgaz=@p3,internet=@p4,Gıda=@p5,Personel=@p6,Diger=@p7 where Odemeid=@p8", bgl.baglanti());
                komut.Parameters.AddWithValue("@p8", TxtGiderid.Text);
                komut.Parameters.AddWithValue("@p1", TxtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", TxtSu.Text);
                komut.Parameters.AddWithValue("@p3", TxtDogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", TxtInternet.Text);
                komut.Parameters.AddWithValue("@p5", TxtGıda.Text);
                komut.Parameters.AddWithValue("@p6", TxtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", TxtDiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
               
            }

                private void FrmGiderGuncelle_Load(object sender, EventArgs e)
                {
                    TxtGiderid.Text = id;
                    TxtElektrik.Text = elektrik;
                    TxtSu.Text = su;
                    TxtPersonel.Text = personel;
                    TxtInternet.Text = internet;
                    TxtDogalgaz.Text = dogalgaz;
                    TxtDiger.Text = diger;
                    TxtGıda.Text = gida;
                }
            }
}
