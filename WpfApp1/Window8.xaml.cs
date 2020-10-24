using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        public Window8()
        {
            InitializeComponent();
            canvas.ManipulationDelta += Canvas_ManipulationDelta;
            canvas.ManipulationInertiaStarting += Canvas_ManipulationInertiaStarting;
        }

        private void Canvas_ManipulationInertiaStarting(object sender, ManipulationInertiaStartingEventArgs e)
        {
            e.TranslationBehavior.DesiredDeceleration = 0.01;
            e.RotationBehavior.DesiredDeceleration = 0.01;
            e.ExpansionBehavior.DesiredDeceleration = 0.01;
        }

        private void Canvas_ManipulationDelta(object sender, ManipulationDeltaEventArgs e)
        {
            MatrixTransform transform = photo.RenderTransform as MatrixTransform;
            if (transform != null)
            {
                // Apply any deltas to the matrix,
                // then apply the new Matrix as the MatrixTransform data:
                Matrix matrix = transform.Matrix;
                matrix.Translate(e.DeltaManipulation.Translation.X,
                e.DeltaManipulation.Translation.Y);
                matrix.RotateAt(e.DeltaManipulation.Rotation, e.ManipulationOrigin.X, e.ManipulationOrigin.Y);
                matrix.ScaleAt(e.DeltaManipulation.Scale.X, e.DeltaManipulation.Scale.Y,
                e.ManipulationOrigin.X, e.ManipulationOrigin.Y);
                transform.Matrix = matrix;
                e.Handled = true;
            }
        }
    }
}
