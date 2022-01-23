using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Drawing.Drawing2D;

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        private bool dragging = false;
        private Point dragCursor;
        private Point dragForm;

        public Form1()
        {
            InitializeComponent();

            // Initial text
            speechBox.Text = ("A supernova is the biggest explosion that humans have ever seen. Each blast is the extremely bright, super-powerful explosion of a star. \n" +
                "What causes a supernova? \n" +
                "One type of supernova is caused by the “last hurrah” of a dying massive star.This happens when a star at least five times the mass of our sun goes out with a fantastic bang! \n" +
                "Massive stars burn huge amounts of nuclear fuel at their cores, or centers.This produces tons of energy, so the center gets very hot. Heat generates pressure, and the pressure created by a star’s nuclear burning also keeps that star from collapsing. \n" +
                "A star is in balance between two opposite forces.The star’s gravity tries to squeeze the star into the smallest, tightest ball possible. But the nuclear fuel burning in the star’s core creates strong outward pressure. This outward push resists the inward squeeze of gravity.");
        }

        // Text to speech button
        private async void speech_Click(object sender, EventArgs e)
        {
            if (speechBox.Text != "")
            {
                synthesizer = new SpeechSynthesizer();
                synthesizer.SpeakAsync(speechBox.Text);
            }
            else
            {
                speechBox.Text = ("You have not written anything");
                synthesizer = new SpeechSynthesizer();
                synthesizer.SpeakAsync(speechBox.Text);

                await Task.Delay(2000);
                speechBox.Clear();
                speechBox.Focus();
            }
        }

        private void pause_Click(object sender, EventArgs e)
        {
            if (synthesizer.State == SynthesizerState.Speaking)
            {
                synthesizer.Pause();
            }
        }

        private void resume_Click(object sender, EventArgs e)
        {
            if (speechBox.Text == "")
            {
                synthesizer = new SpeechSynthesizer();
                synthesizer.SpeakAsync(speechBox.Text);
            } 
            else if ((synthesizer.State == SynthesizerState.Paused) && (speechBox.Text != ""))
            {
                synthesizer.Resume();
            }   
        }

        private void Exit_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Do you want to exit the application?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                if (speechBox.Text != "")
                {
                    synthesizer.Pause();
                }
            }
        }

        /*************************************************************************************/

        // Make form window movable
        private void Clear_Click(object sender, EventArgs e)
        {
            speechBox.Clear();
            synthesizer.Dispose();
        }

        private void Form1_mousedown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursor = Cursor.Position;
            dragForm = this.Location;
        }

        private void Form1_mousemove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursor));
                this.Location = Point.Add(dragForm, new Size(dif));
            }
        }

        private void Form1_mouseup(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        /*************************************************************************************/


        // Make rounded corners for buttons and form
        private GraphicsPath GetRoundPath(RectangleF rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(rect.X + r2, rect.Y, rect.Width - r2, rect.Y);
            GraphPath.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(rect.Width, rect.Y + r2, rect.Width, rect.Height - r2);
            GraphPath.AddArc(rect.X + rect.Width - radius,
                             rect.Y + rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(rect.Width - r2, rect.Height, rect.X + r2, rect.Height);
            GraphPath.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(rect.X, rect.Height - r2, rect.X, rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            using (GraphicsPath GraphPath = GetRoundPath(Rect, 25))
            {
                this.Region = new Region(GraphPath);
                using (Pen pen = new Pen(Color.White, 1.50f))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }
    }
}





    






