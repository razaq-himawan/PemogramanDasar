using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace KalkulatorSederhana.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    public void ButtonAdd_Click(object source, RoutedEventArgs e)
    {
        if (double.TryParse(angka1.Text, out double angka_1) && double.TryParse(angka2.Text, out double angka_2))
        {
            hasil.Text = Convert.ToString(angka_1 + angka_2);
        }
    }
    public void ButtonSub_Click(object source, RoutedEventArgs e)
    {
        if (double.TryParse(angka1.Text, out double angka_1) && double.TryParse(angka2.Text, out double angka_2))
        {
            hasil.Text = Convert.ToString(angka_1 - angka_2);
        }
    }
    public void ButtonMulti_Click(object source, RoutedEventArgs e)
    {
        if (double.TryParse(angka1.Text, out double angka_1) && double.TryParse(angka2.Text, out double angka_2))
        {
            hasil.Text = Convert.ToString(angka_1 * angka_2);
        }
    }
    public void ButtonDiv_Click(object source, RoutedEventArgs e)
    {
        if (double.TryParse(angka1.Text, out double angka_1) && double.TryParse(angka2.Text, out double angka_2))
        {
            hasil.Text = Convert.ToString(angka_1 / angka_2);
        }
    }
    public void ButtonCalc_Click(object source, RoutedEventArgs e)
    {
        if (double.TryParse(panjang.Text, out double panjang_1) && double.TryParse(lebar.Text, out double lebar_2))
        {
            hasilpanjang.Text = Convert.ToString(panjang_1 * lebar_2);
            hasillebar.Text = Convert.ToString((panjang_1 + lebar_2) * 2);
        }
    }
}