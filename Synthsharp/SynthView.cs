﻿using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Synthsharp
{

    public partial class SynthView : Form
    {
        Oscillator o1;
        Oscillator o2;
        Oscillator o3;
        int frequency;
        private const int SAMPLE_RATE = 44100;
        private const short BITS_PER_SAMPLE = 16;
        private const int DEFAULT_FREQUENCY = 440;
        private const int FREQUENCY_FOR_C2_NOTE = 65;
        private const int FREQUENCY_FOR_C3_NOTE = 131;
        private const int FREQUENCY_FOR_C4_NOTE = 262;
        private const int FREQUENCY_FOR_C5_NOTE = 523;
        private const int FREQUENCY_FOR_C6_NOTE = 1047;
        private const int FREQUENCY_FOR_C7_NOTE = 2093;
        private const int FREQUENCY_FOR_C8_NOTE = 4186;

        public SynthView()
        {
            InitializeComponent();
            KeyPreview = true;
        }


        private void SynthView_Load(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// Initialize the combobox values
        /// </summary>
        /// <param name="cbs">Array of ComboBox</param>
        /// <param name="dataCbx">Elements of the ComboBox</param>
        public void InitializeComboBox(ComboBox[] cbs, string[] dataCbx)
        {
            foreach (ComboBox combobox in cbs)
            {
                combobox.Items.AddRange(dataCbx);
            }
        }


        private void SynthView_KeyUp(object sender, KeyEventArgs e)
        {
            o1.StopWave();
            o2.StopWave();
            o3.StopWave();
        }





        private void SynthView_KeyDown(object sender, KeyEventArgs e)
        {
            frequency = DEFAULT_FREQUENCY;

            /* Frenquencies available at this address : https://en.wikipedia.org/wiki/Piano_key_frequencies (using C2 to C8)*/
            switch (e.KeyCode)
            {
                case Keys.Y:
                    frequency = FREQUENCY_FOR_C2_NOTE;
                    break;
                case Keys.X:
                    frequency = FREQUENCY_FOR_C3_NOTE;
                    break;
                case Keys.C:
                    frequency = FREQUENCY_FOR_C4_NOTE;
                    break;
                case Keys.V:
                    frequency = FREQUENCY_FOR_C5_NOTE;
                    break;
                case Keys.B:
                    frequency = FREQUENCY_FOR_C6_NOTE;
                    break;
                case Keys.H:
                    frequency = FREQUENCY_FOR_C7_NOTE;
                    break;
                case Keys.M:
                    frequency = FREQUENCY_FOR_C8_NOTE;
                    break;
                default:
                    break;
            }

            if (o1 != null)
            {
                o1.CreateWave(1, frequency);
            }
            if (o2 != null)
            {
                o2.CreateWave(1, frequency);
            }
            if (o3 != null)
            {
                o3.CreateWave(1, frequency);
            }

        }
        private void btnSine1_Click(object sender, EventArgs e)
        {
            if (o1 == null)
            {
                o1 = new Oscillator(1, frequency, new WaveOut(), SignalGeneratorType.Sin);
            }
        }
        private void btnSquare1_Click(object sender, EventArgs e)
        {
            if (o1 == null)
            {
                o1 = new Oscillator(1, frequency, new WaveOut(), SignalGeneratorType.Square);
            }
        }

        private void btnSawTooth1_Click(object sender, EventArgs e)
        {
            if (o1 == null)
            {
                o1 = new Oscillator(1, frequency, new WaveOut(), SignalGeneratorType.SawTooth);
            }
        }

        private void btnNoise1_Click(object sender, EventArgs e)
        {
            if (o1 == null)
            {
                o1 = new Oscillator(1, frequency, new WaveOut(), SignalGeneratorType.White);
            }
        }

        private void btnTriangle1_Click(object sender, EventArgs e)
        {
            if (o1 == null)
            {
                o1 = new Oscillator(1, frequency, new WaveOut(), SignalGeneratorType.Triangle);
            }
        }

        private void btnSine2_Click(object sender, EventArgs e)
        {
            if (o2 == null)
            {
                o2 = new Oscillator(1, frequency, new WaveOut(), SignalGeneratorType.Square);
            }
        }

        private void btnSawTooth2_Click(object sender, EventArgs e)
        {
            if (o2 == null)
            {
                o2 = new Oscillator(1, frequency, new WaveOut(), SignalGeneratorType.SawTooth);
            }
        }

        private void btnTriangle2_Click(object sender, EventArgs e)
        {
            if (o2 == null)
            {
                o2 = new Oscillator(1, frequency, new WaveOut(), SignalGeneratorType.Triangle);
            }
        }

        private void btnNoise2_Click(object sender, EventArgs e)
        {
            if (o2 == null)
            {
                o2 = new Oscillator(1, frequency, new WaveOut(), SignalGeneratorType.White);
            }
        }
        private void btnSquare2_Click(object sender, EventArgs e)
        {
            if (o2 == null)
            {
                o2 = new Oscillator(1, frequency, new WaveOut(), SignalGeneratorType.Square);
            }
        }

        private void btnSine3_Click(object sender, EventArgs e)
        {
            if (o3 == null)
            {
                o3 = new Oscillator(1, frequency, new WaveOut(), SignalGeneratorType.Sin);
            }
        }

        private void btnSquare3_Click(object sender, EventArgs e)
        {
            if (o3 == null)
            {
                o3 = new Oscillator(1, frequency, new WaveOut(), SignalGeneratorType.Square);
            }
        }

        private void btnSawTooth3_Click(object sender, EventArgs e)
        {
            if (o3 == null)
            {
                o3 = new Oscillator(1, frequency, new WaveOut(), SignalGeneratorType.SawTooth);
            }
        }

        private void btnNoise_Click(object sender, EventArgs e)
        {
            if (o3 == null)
            {
                o3 = new Oscillator(1, frequency, new WaveOut(), SignalGeneratorType.White);
            }
        }

        private void btnTriangle3_Click(object sender, EventArgs e)
        {
            if (o3 == null)
            {
                o3 = new Oscillator(1, frequency, new WaveOut(), SignalGeneratorType.Triangle);
            }
        }
    }
}
