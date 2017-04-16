using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace Skia
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void SKCanvasView_OnPaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            // Çizim yapacağımız alanı aldık.
            var canvas = e.Surface.Canvas;
            // Alanı temizliyoruz.
            canvas.Clear(SKColors.White);

            // Ana kısmın rengini belirliyoruz.
            var vsMain = new SKPaint
            {
                Color = SKColor.Parse("#68217A"),
                StrokeCap = SKStrokeCap.Round
            };
            var vsInside = new SKPaint()
            {
                Color = SKColors.White,
                StrokeCap = SKStrokeCap.Round
            };

            using (var logoPath = new SKPath())
            {
                // Visual Studio logosunun ana kısımlarını çiziyoruz
                logoPath.MoveTo(145.142f, 314.289f);
                logoPath.LineTo(84.143f, 267.87f);
                logoPath.CubicTo(84.143f, 267.87f, 83.937f, 268.698f, 83.566f, 267.884f);
                logoPath.LineTo(71.048f, 274.18f);
                logoPath.CubicTo(71.048f, 274.18f, 70.695f, 274.57f, 70.674f, 274.75f);
                logoPath.LineTo(70.674f, 382.625f);
                logoPath.CubicTo(70.674f, 382.625f, 70.674f, 382.854f, 70.86f, 382.947f);
                logoPath.LineTo(83.619f, 389.347f);
                logoPath.CubicTo(83.619f, 389.347f, 83.803f, 389.439f, 84f, 389.25f);
                logoPath.LineTo(144.798f, 343.008f);
                logoPath.CubicTo(144.798f, 343.008f, 144.955f, 342.889f, 145.045f, 342.977f);
                logoPath.LineTo(245.365f, 440.343f);
                logoPath.CubicTo(245.365f, 440.343f, 245.465f, 440.039f, 245.589f, 440.39f);
                logoPath.LineTo(291.529f, 422.032f);
                logoPath.CubicTo(291.529f, 422.032f, 291.658f, 421.98f, 291.658f, 421.854f);
                logoPath.LineTo(291.638f, 235.313f);
                logoPath.CubicTo(291.638f, 235.313f, 291.638f, 235.186f, 291.52f, 235.138f);
                logoPath.LineTo(245.506f, 216.693f);
                logoPath.CubicTo(245.506f, 216.693f, 245.404f, 216.652f, 245.297f, 216.75f);
                logoPath.LineTo(145.142f, 314.289f);

                canvas.DrawPath(logoPath, vsMain);
                logoPath.Close();
            }
            using (var insidePath = new SKPath())
            {
                // Logo içerisindeki beyaz kısımları çiziyoruz.
                // 1. kısım
                insidePath.MoveTo(90.491f, 303.328f);
                insidePath.LineTo(90.491f, 353.792f);
                insidePath.CubicTo(90.491f, 353.792f, 90.491f, 354.061f, 90.654f, 353.943f);
                insidePath.LineTo(118.754f, 328.487f);
                insidePath.CubicTo(118.754f, 328.487f, 118.819f, 328.428f, 118.754f, 328.369f);
                insidePath.LineTo(90.563f, 303.202f);
                insidePath.CubicTo(90.563f, 303.202f, 90.491f, 303.138f, 90.491f, 303.328f);

                // 2. kısım
                insidePath.MoveTo(181.336f, 328.546f);
                insidePath.LineTo(237.69f, 370.986f);
                insidePath.CubicTo(237.69f, 370.986f, 237.813f, 371.078f, 237.813f, 370.938f);
                insidePath.LineTo(237.813f, 286.172f);
                insidePath.CubicTo(237.813f, 286.172f, 237.813f, 286.071f, 237.716f, 286.127f);
                insidePath.LineTo(181.23f, 328.354f);
                insidePath.CubicTo(181.23f, 328.354f, 181.155f, 328.409f, 181.336f, 328.546f);

                canvas.DrawPath(insidePath, vsInside);
                insidePath.Close();
            }
        }
    }
}