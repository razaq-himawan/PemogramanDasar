using System;
using System.Diagnostics;
using System.Net.Http.Headers;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using PenjualanMotor.ViewModels;

namespace PenjualanMotor.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void TextBoxKodeMotor_KeyUp(object sender, KeyEventArgs e)
    {
        if (tbKodeMotor.Text == "HC")
        {
            tbNamaMotor.Text = "Honda CBR";
            tbHargaMotor.Text = Convert.ToString(23000000);
            return;
        }
        else if (tbKodeMotor.Text == "KN")
        {
            tbNamaMotor.Text = "Kawasaki Ninja";
            tbHargaMotor.Text = Convert.ToString(32000000);
            return;
        }
        else if (tbKodeMotor.Text == "SS")
        {
            tbNamaMotor.Text = "Suzuki Satria";
            tbHargaMotor.Text = Convert.ToString(18500000);
            return;
        }
        else if (tbKodeMotor.Text == "YV")
        {
            tbNamaMotor.Text = "Yamaha Vixion";
            tbHargaMotor.Text = Convert.ToString(21000000);
            return;
        }

        tbNamaMotor.Text = "";
        tbHargaMotor.Text = "";
    }

    public void ButtonHitung_Click(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(tbJumlahBeli.Text, out double jumlah_beli) && double.TryParse(tbHargaMotor.Text, out double harga_motor))
        {
            if (jumlah_beli == 1)
            {
                tbBonus.Text = "Jas Hujan";
            }
            else if (jumlah_beli == 2)
            {
                tbBonus.Text = "Bonus Helm";
            }
            else if (jumlah_beli >= 3)
            {
                tbBonus.Text = "Jaket Kulit";
            }

            double diskon = harga_motor * jumlah_beli * 0.05;
            double total = harga_motor * jumlah_beli - diskon;

            tbDiskon5Persen.Text = diskon.ToString();
            tbTotalBayar.Text = total.ToString();
        }
    }

    public void ButtonClear_Click(object sender, RoutedEventArgs e)
    {
        tbKodeMotor.Text = "";
        tbNamaMotor.Text = "";
        tbHargaMotor.Text = "";
        tbJumlahBeli.Text = "";
        tbBonus.Text = "";
        tbDiskon5Persen.Text = "";
        tbTotalBayar.Text = "";
    }

    public void ButtonExit_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
}
