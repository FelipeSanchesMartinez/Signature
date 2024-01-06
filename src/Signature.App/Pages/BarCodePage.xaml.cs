using ZXing.Net.Maui;

namespace Signature.App.Pages;

public partial class BarCodePage : ContentPage
{
    public event EventHandler<string> BarCodeChanged;
    public BarCodePage()
    {
        InitializeComponent();
        cameraBarcodeReaderView.Options = new BarcodeReaderOptions
        {
            Formats = BarcodeFormat.Code128,
        };
    }    
    protected async void BarcodesDetected(object sender, BarcodeDetectionEventArgs e)
    {
      
        string barCode = e.Results.FirstOrDefault()?.Value;

        if (barCode is null) return;

        BarCodeChanged?.Invoke(this, barCode);
    }
}