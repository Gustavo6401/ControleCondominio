using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video.DirectShow;

namespace ServicoPortaria.Presentation.Morador
{
    public partial class ucInserir : UserControl
    {
        private ServicoPortaria.Presentation.Capture _camera;
        public ucInserir()
        {
            InitializeComponent();

            const int VIDEODEVICE = 0;
            const int VIDEOWIDTH = 640;
            const int VIDEOHEIGHT = 480;
            const int VIDEOBITSPERPIXEL = 24;

            _camera = new Capture(VIDEODEVICE, VIDEOWIDTH, VIDEOHEIGHT, VIDEOBITSPERPIXEL, imgWebCam);
        }
        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var bitmap = new Bitmap(imgWebCam.Width, imgWebCam.Height);
            using (var graphics = Graphics.FromImage(bitmap))
            {
                var webCamPoint = imgWebCam.PointToScreen(new Point(0, 0));
                graphics.CopyFromScreen(webCamPoint.X, webCamPoint.Y, 0, 0, bitmap.Size);
            }
            bitmap.Save("snapshot.png", System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
