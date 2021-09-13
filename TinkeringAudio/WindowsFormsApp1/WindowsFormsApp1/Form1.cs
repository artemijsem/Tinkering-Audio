/// <summary>
/// Created by Artemi Semensenko
/// </summary>
namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;
    using NAudio.Wave;

    /// <summary>
    /// This class implements a WIN Form for manipulating and creating WAV audio using NAudio library
    /// </summary>
    /// <remarks>Prepeared by Artemi Sementsenko and Gatis Silnieks</remarks>
    public partial class Form1 : Form
    {
        private readonly int SAMPLE_RATE = 44100;
        private int CHANNEL = 1;
        private int SHORT_MAX_VALUE;
        private readonly int MAX_VALUE = (int)Math.Pow(2, 15);
        private double volume = 0.08;
        private delegate double WaveFunction(double frequency, int position);
        private WaveFunction waveFunction = null;
        public int audio_duration;
        public int frequency;
        private List<byte> GenerateSilence(double durationInSeconds)
        {
            List<byte> silence = new List<byte>();
            for (int i = 0; i < (int)(durationInSeconds * SAMPLE_RATE); i++)
            {
                silence.Add(0);
                silence.Add(0);
            }
            return silence;
        }

        private IWaveProvider convertToWaveProvider16(List<int> sample, int sampleRate, int channelCount)
        {
            byte[] byteBuffer = new byte[sample.Count * 2];

            int byteArrayIndex = 0;
            short value;
            for (int i = 0; i < sample.Count; i++)
            {
                if (sample[i] > SHORT_MAX_VALUE)
                {
                    value = (short)SHORT_MAX_VALUE;
                }
                else if (sample[i] < -SHORT_MAX_VALUE)
                {
                    value = (short)-SHORT_MAX_VALUE;
                }
                else
                {
                    value = (short)sample[i];
                }
                byteBuffer[byteArrayIndex++] = BitConverter.GetBytes(value)[0];
                byteBuffer[byteArrayIndex++] = BitConverter.GetBytes(value)[1];
            }
            IWaveProvider waveProvider = new RawSourceWaveStream(new MemoryStream(byteBuffer), new WaveFormat(sampleRate, 16, channelCount));
            return waveProvider;
        }


        private List<int> GenerateTone(double durationInSeconds, WaveFunction waveFunction, double[] frequencies)
        {
            List<int> tone = new List<int>();
            short value;
            for (int i = 0; i < (int)(durationInSeconds * SAMPLE_RATE); i++)
            {
                value = 0;
                for (int j = 0; j < frequencies.Length; j++)
                {
                    value += (short)(SHORT_MAX_VALUE * volume * waveFunction.Invoke(frequencies[j], i));
                }
                tone.Add(BitConverter.GetBytes(value)[0]);
                tone.Add(BitConverter.GetBytes(value)[1]);
            }
            return tone;
        }



        // Algorithm which generates a note
        private List<int> GenerateMelody(int countOfNotesToPlay, int frequency)
        {
            List<int> melody = new List<int>();

            double[] frequencies = new double[2];
            for (int i = 0; i < countOfNotesToPlay; i++)
            {
                frequencies[0] = frequency;
                frequencies[1] = frequency;
                melody.AddRange(
                    GenerateTone(
                        1,
                        this.waveFunction,
                        frequencies
                    ));
            }
            return melody;
        }

        private double SquareWave(double frequency, int position)
        {
            double value = Math.Sin(2.0 * Math.PI * frequency * (position / (double)SAMPLE_RATE));
            if (value > 0)
            {
                return 1.0;
            }
            else
            {
                return -1.0;
            }
        }

        private double SinWave(double frequency, int position)
        {
            return Math.Sin(2.0 * Math.PI * frequency * (position / (double)SAMPLE_RATE));
        }
        private double TriangleWave(double frequency, int position)
        {
            return (2 / Math.PI) * Math.Asin(Math.Sin(2.0 * Math.PI * frequency * (position / (double)SAMPLE_RATE)));
        }

        private double SawtoothWave(double frequency, int position)
        {
            return (-2 / Math.PI) * Math.Atan(1 / Math.Tan(frequency * (position / (double)SAMPLE_RATE)));
        }
        //Some interesting wave type which I've accidently created
        private double MyWave(double frequency, int position)
        {
            return Math.Cos(5 * Math.PI * frequency * (position / (double)SAMPLE_RATE));
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            numericUpDown2.Maximum = 20000;
            numericUpDown2.Value = 440;
        }



        //Save button
        private void button2_Click_1(object sender, EventArgs e)
        {
            /*byte[] audioSample = GenerateMelody(audio_duration,frequency).ToArray();

            waveProvider = new RawSourceWaveStream(new MemoryStream(audioSample), new WaveFormat(SAMPLE_RATE, 1));

            string filename = Path.Combine(Environment.CurrentDirectory + Path.DirectorySeparatorChar + "sample.wav");
            WaveFileWriter.CreateWaveFile(filename, waveProvider);*/

            string filename = Path.Combine(Environment.CurrentDirectory + Path.DirectorySeparatorChar + "sample.wav");
            List<int> audio = GenerateTone(audio_duration, this.waveFunction, new double[] { frequency });
            WaveFileWriter.CreateWaveFile(filename, convertToWaveProvider16(audio, SAMPLE_RATE, CHANNEL));
            UpdateChart(chart1, audio);
        }
        //Audio Duration changer
        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            audio_duration = (int)numericUpDown1.Value;
        }

        //Play button
        private void button3_Click_1(object sender, EventArgs e)
        {
            WaveOut waveOut = new WaveOut();
            waveOut.Init(convertToWaveProvider16(GenerateMelody(audio_duration, frequency), SAMPLE_RATE, 1));
            waveOut.Play();
        }

        ///Frequency changer
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

            frequency = (int)numericUpDown2.Value;
        }

        //Sine Wave Type button
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.waveFunction = SinWave;
        }
        //Square Wave Type button
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.waveFunction = SquareWave;
        }
        private void Sawtooth_CheckedChanged(object sender, EventArgs e)
        {
            this.waveFunction = SawtoothWave;
        }

        private void Triangle_CheckedChanged(object sender, EventArgs e)
        {
            this.waveFunction = TriangleWave;
        }
        // Wave Type 1
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            this.waveFunction = MyWave;
        }

        /// <summary>
        /// Controller for amount of bits using in formatting the audio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void x8bit_CheckedChanged(object sender, EventArgs e)
        {
            SHORT_MAX_VALUE = (int)Math.Pow(2, 7);
        }

        private void x16bit_CheckedChanged(object sender, EventArgs e)
        {
            SHORT_MAX_VALUE = (int)Math.Pow(2, 15);
        }

        private void x24bit_CheckedChanged(object sender, EventArgs e)
        {
            SHORT_MAX_VALUE = (int)Math.Pow(2, 23);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            volume = (double)numericUpDown3.Value / 100;
        }

        private void UpdateChart (Chart chart, List<int> data)
        {
            Series dataSeries = new Series();
            dataSeries.ChartType = SeriesChartType.Line;
            dataSeries.Points.DataBindY(data);

            chart.Series.Clear();
            chart.ChartAreas[0].AxisX.Maximum = SAMPLE_RATE;
            chart.Series.Add(dataSeries);
        }
        private void Normalisation(List<int> sample)
        {
            int normalisation = 0;
            for (int i = 0; i < sample; i++)
            {
                normalisation = MAX_VALUE(normalisation, sample)
                
            }
            double O = ((MAX_VALUE - 1) / normalisation);
            for (int i = 0; i < sample; i++)
            {
                double p = 0;
                p = (O * sample);
                sample = p;

            }
            return sample;



        }

        private class Note
        {
            public double frequency;
            public double duration;
            public Note (double frequency, double duration)
            {
                this.frequency = frequency;
                this.duration = duration;
            }
        }
        private class MusicalScale
        {
            private double[] noteDurations;
            private List<Note> notes;

            public MusicalScale(int startNote, int endNote, int increment, double [] noteDurations, double baseNote = 440.0 , double musicalBase = 2.0, double octaveDivision = 12.0)
            {
                this.noteDurations = noteDurations;

                double ESTIMATOR = Math.Pow(musicalBase, (1.0 / octaveDivision));

                notes = new List<Note>();
                for (int i = startNote; i < endNote; i+=increment)
                {
                    notes.Add(new Note(baseNote * Math.Pow(ESTIMATOR, i), 1.0));
                }

            }
            private static T GetNextElement<T>(IEnumerable<T> enumerable)
            {
                for (int i = 0; i < enumerable.Count(); i++)
                {
                    int index = i;
                }
                return enumerable.ElementAT(index);
            }
            public Note GetNote()
            {
                return ;
            }
        }
    }
}
