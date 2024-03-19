using System;
using System.Collections.Generic;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace FormNilaiMahasiswa.Views;

public partial class MainWindow : Window
{

    /// Males dahlah skip
    public void ComboBox_SelectionChanged(object source, SelectionChangedEventArgs e)
    {
        var selected = cbKodeJurusan?.SelectedItem?.ToString();

        if (string.Equals(selected, "MIF"))
        {
            tbJurusan.Text = "Manajemen Informatika";
        }
        else if (string.Equals(selected, "AKE"))
        {
            tbJurusan.Text = "Administrasi Keuangan";
        }
        else if (string.Equals(selected, "IRM"))
        {
            tbJurusan.Text = "Informatika Rekam Medis";
        }
    }
    public void TextBoxJurusan_KeyUp(object source, KeyEventArgs e)
    {
        if (string.Equals(tbKodeJurusan.Text, "MIF"))
        {
            tbJurusan.Text = "Manajemen Informatika";
        }
        else if (string.Equals(tbKodeJurusan.Text, "AKE"))
        {
            tbJurusan.Text = "Administrasi Keuangan";
        }
        else if (string.Equals(tbKodeJurusan.Text, "IRM"))
        {
            tbJurusan.Text = "Informatika Rekam Medis";
        }
    }


    public void Button_Click(object source, RoutedEventArgs e)
    {
        string[] nilai = [nilaiAK.Text!, nilaiTQ.Text!, nilaiUTS.Text!, nilaiUAS.Text!];
        List<double> hasil = [];

        foreach (var value in nilai)
        {
            if (double.TryParse(value.Trim(), out double hasilNilaiAngka))
            {
                hasil.Add(hasilNilaiAngka);
            }
        }

        var total = (hasil[0] * 0.1) + (hasil[1] * 0.2) + (hasil[2] * 0.3) + (hasil[3] * 0.4);

        nilaiAngka.Text = total.ToString();

        if (total < 49)
        {
            nilaiHuruf.Text = "E";
            nilaiKet.Text = "Memuakkan";
        }
        else if (total >= 50 && total <= 59)
        {
            nilaiHuruf.Text = "D";
            nilaiKet.Text = "Kurang";
        }
        else if (total >= 60 && total <= 69)
        {
            nilaiHuruf.Text = "C";
            nilaiKet.Text = "Cukup";
        }
        else if (total >= 70 && total <= 79)
        {
            nilaiHuruf.Text = "B";
            nilaiKet.Text = "Baik";
        }
        else if (total >= 80 && total <= 100)
        {
            nilaiHuruf.Text = "A";
            nilaiKet.Text = "Memuaskan";
        }
    }
    public MainWindow()
    {
        InitializeComponent();
    }
}