using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Mobile;

namespace ScanQRCodes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            buttonScan.Clicked += async (sender, e) =>
            {
#if __ANDROID__
	                // Inicialice primero el escáner para que pueda rastrear el contexto actual
	                MobileBarcodeScanner.Initialize (Application);
#endif

                var scanner = new MobileBarcodeScanner();
                var result = await scanner.Scan();

                if (result != null)
                {
                    System.Diagnostics.Debug.WriteLine("Scanned Barcode: " + result.Text);
                }
            };
        }
    }
}
