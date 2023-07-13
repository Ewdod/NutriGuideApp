using Microsoft.Data.SqlClient;
using NutriGuide.DataAccessLayer.Concrets;
using NutriGuide.Entity.Data;
using NutriGuide.Entity.Enums;
using System.Text;

namespace NutriGuide.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            if (lblSignUp.Text == "Sign Up!")
            {
                string text = "SIGN UP";
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < text.Length; i++)
                {
                    Thread.Sleep(20);
                    sb.Append(text[i]);
                    btnLogin.Text = sb.ToString();
                    Refresh();
                }
                lblYazi.Text = "Already have an account?";
                lblSignUp.Text = "Login";
            }
            else if (lblSignUp.Text == "Login")
            {
               // btnLogin.Text = "";
                string text = "LOGIN";
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < text.Length; i++)
                {
                    Thread.Sleep(20);
                    sb.Append(text[i]);
                    btnLogin.Text = sb.ToString();
                    Refresh();
                }
                lblYazi.Text = "Don't have an account?";
                lblSignUp.Text = "Sign Up!";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //btnLogin.Text = "";
            //string text = "LOGIN";
            //StringBuilder sb = new StringBuilder();
            //for (int i = 0; i < text.Length; i++)
            //{
            //    Thread.Sleep(50);
            //    sb.Append(text[i]);
            //    btnLogin.Text = sb.ToString();
            //    Refresh();
            //}
            using (NutriGuideContext _Db = new NutriGuideContext())
            {
                string Pwd = txtPassword.Text;
                string hashedPwd = PasswordHasher.HashPassword(Pwd);
                var kisi = _Db.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == txtUsername.Text && PasswordHasher.HashPassword(txtPassword.Text) == x.KullaniciPassword);
                if (btnLogin.Text == "LOGIN" && _Db.Kullanicilar.Contains(kisi) && kisi.KullaniciPassword == hashedPwd && txtUsername.Text == kisi.KullaniciAdi)
                {
                    MessageBox.Show("Giri� Ba�ar�l�");
                    MainMenu mainMenu = new MainMenu(kisi);
                    mainMenu.Show();
                    this.Hide();
                }

                else if (lblSignUp.Text == "Login")
                {
                    using (NutriGuideContext _db = new NutriGuideContext())
                    {
                        Kullanici k1 = new Kullanici();
                        k1.KullaniciAdi = txtUsername.Text;
                        k1.KullaniciPassword = hashedPwd; // Hashlenmi� �ifre kullan�c� nesnesine atan�yor
                        if (_db.Kullanicilar.Contains(kisi))
                        {
                            MessageBox.Show("Boyle bir kullanici zaten bulunuyor");
                            return;

                        }
                        else
                        {
                            _db.Kullanicilar.Add(k1);
                            _db.SaveChanges();
                            MessageBox.Show("Ba�ar�yla �ye oldunuz.");
                        }
                       
                        
                        

                        


                        string text1 = "LOGIN";
                        StringBuilder sb1 = new StringBuilder();
                        for (int i = 0; i < text1.Length; i++)
                        {
                            Thread.Sleep(20);
                            sb1.Append(text1[i]);
                            btnLogin.Text = sb1.ToString();
                            Refresh();
                        }
                    }
                    //MessageBox.Show("Ba�ar�yla �ye oldunuz.");

                    lblYazi.Text = "Don't have an account?";
                    lblSignUp.Text = "Sign Up!";
                }
                else if (lblSignUp.Text == "Sign Up!" &&  ((_Db.Kullanicilar.Contains(kisi)! && kisi.KullaniciPassword != hashedPwd && txtUsername.Text != kisi.KullaniciAdi) || (_Db.Kullanicilar.Contains(kisi) && (kisi.KullaniciPassword != hashedPwd || txtUsername.Text != kisi.KullaniciAdi))))
                {

                    string text2 = "LOGIN";
                    StringBuilder sb2 = new StringBuilder();
                    for (int i = 0; i < text2.Length; i++)
                    {
                        Thread.Sleep(20);
                        sb2.Append(text2[i]);
                        btnLogin.Text = sb2.ToString();
                        Refresh();
                    }
                    MessageBox.Show("Giri� ba�ar���z.");
                }
                else
                {

                    MessageBox.Show("Giri� ba�ar���z.");
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}