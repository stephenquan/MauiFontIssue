﻿namespace MauiFontIssue;

public partial class MainPage : ContentPage
{
    public List<string> FontFamilies { get; } = new List<string>()
    {
        "NotoSansRegular",
        "NotoSansBold",
        "NotoSansItalic",
        "NotoSansBoldItalic",

        "Arial",
        "ArialBold",
        "ArialBoldItalic",
        "ArialItalic",

        "Times",
        "TimesBold",
        "TimesBoldItalic",
        "TimesItalic",

        "OpenSansRegular",
        "OpenSansSemibold",
        "NoSuchFont",

    };

    public static readonly BindableProperty SelectedFontFamilyProperty = BindableProperty.Create(nameof(SelectedFontFamily), typeof(string), typeof(MainPage));
    public string SelectedFontFamily
    {
        get => (string)GetValue(SelectedFontFamilyProperty);
        set => SetValue(SelectedFontFamilyProperty, value);
    }

    public MainPage()
    {
        SelectedFontFamily = FontFamilies[0];
        InitializeComponent();
    }

    private void OnFontClicked(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        SelectedFontFamily = btn.Text;
    }
}
