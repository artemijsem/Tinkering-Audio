/// <summary>
/// MIT License
/// 
/// Copyright(c) 2020 Gatis Silnieks & Artemi Sementsenko
/// 
/// Permission is hereby granted, free of charge, to any person obtaining a copy  
/// of this software and associated documentation files (the "Software"), to deal  
/// in the Software without restriction, including without limitation the rights  
/// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell  
/// copies of the Software, and to permit persons to whom the Software is  
/// furnished to do so, subject to the following conditions:  
/// 
/// The above copyright notice and this permission notice shall be included in all  
/// copies or substantial portions of the Software.  
/// 
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR  
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE  
/// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER  
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
/// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE  
/// SOFTWARE.  
/// </summary>
namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;
    using BenchmarkDotNet.Mathematics;
    using NAudio.Wave;

    /// <summary>
    /// This class implements a WIN Form for manipulating and creating WAV audio using NAudio library
    /// </summary>
    /// <remarks>Prepeared by Artemi Sementsenko and Gatis Silnieks</remarks>
    public partial class Form1 : Form
    {

        private readonly int SAMPLE_RATE = 44100;
        private readonly int CHANNEL = 1;
        private readonly int MAX_VALUE = (int)Math.Pow(2, 15);
        private int SHORT_MAX_VALUE;
        private double volume = 0.08;
        private delegate double WaveFunction(double frequency, int position);
        private WaveFunction waveFunction = null;
        public int audio_duration;
        public int frequency;
        public int echo_duration;
        public float Attack_Lvl_Value, Attack_Time_Value, Decay_Time_Value, Sustain_Lvl_Value, Sustain_Time_Value, Release_Time_Value;
        public bool isStopped = false;
        /// <summary>
        /// Algorithm for generating silence
        /// </summary>
        /// <param name="durationInSeconds">
        ///     Duration of silence
        /// </param>
        /// <returns></returns>
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

        /// <summary>
        /// Converter from list of integers into bytes
        /// </summary>
        /// <param name="sample">
        /// Audio sample
        /// </param>
        /// <param name="sampleRate">
        /// Audio sample rate
        /// </param>
        /// <param name="channelCount">
        /// Number of channels
        /// </param>
        /// <returns></returns>
        private IWaveProvider ConvertToWaveProvider16(List<int> sample, int sampleRate, int channelCount)
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

        /// <summary>
        /// Algorithm for populating list of notes
        /// </summary>
        /// <param name="durationInSeconds">
        /// Audio duration
        /// </param>
        /// <param name="waveFunction">
        /// Type of wave which user chose
        /// </param>
        /// <param name="frequencies">
        /// Frequencies list
        /// </param>
        /// <returns></returns>
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
                tone.Add(value);
            }
            
            return tone;
        }



        /// <summary>
        /// Algorithm for generating melody
        /// </summary>
        /// <param name="countOfNotesToPlay">
        /// How many notes will play
        /// </param>
        /// <param name="frequency">
        /// Frequency which user chose
        /// </param>
        /// <returns></returns>
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
                        2,
                        this.waveFunction,
                        frequencies
                    ));
            }
            
            return melody;
        }

        /// <summary>
        /// Square wave type
        /// </summary>
        /// <param name="frequency">
        /// Frequency which user chose
        /// </param>
        /// <param name="position">
        /// Position in the wave
        /// </param>
        /// <returns></returns>
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

        /// <summary>
        /// Sine wave type
        /// </summary>
        /// <param name="frequency">
        /// Frequency which user chose
        /// </param>
        /// <param name="position">
        /// Position in the wave
        /// </param>
        /// <returns></returns>
        private double SinWave(double frequency, int position)
        {
            return Math.Sin(2.0 * Math.PI * frequency * (position / (double)SAMPLE_RATE));
        }

        /// <summary>
        /// Triangle wave type
        /// </summary>
        /// <param name="frequency">
        /// Frequency which user chose
        /// </param>
        /// <param name="position">
        /// Position in the wave
        /// </param>
        /// <returns></returns>
        private double TriangleWave(double frequency, int position)
        {
            return (2 / Math.PI) * Math.Asin(Math.Sin(2.0 * Math.PI * frequency * (position / (double)SAMPLE_RATE)));
        }
        /// <summary>
        /// Sawtooth wave type
        /// </summary>
        /// <param name="frequency">
        /// Frequency which user chose
        /// </param>
        /// <param name="position">
        /// Position in the wave
        /// </param>
        /// <returns></returns>
        private double SawtoothWave(double frequency, int position)
        {
            return (-2 / Math.PI) * Math.Atan(1 / Math.Tan(frequency * (position / (double)SAMPLE_RATE)));
        }

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Booting up default values and assigning ADSR Envlopes values to ADSR Controller in UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
            numericUpDown2.Maximum = 20000;
            numericUpDown2.Value = 440;
            this.waveFunction = SinWave;
        }

        /// <summary>
        /// Save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {

            string filename = Path.Combine(Environment.CurrentDirectory + Path.DirectorySeparatorChar + "sample.wav");
            List<int> audio = GenerateMelody(audio_duration, frequency );
            if (Normalize_OnOff.Checked)
            {
                Normalize(audio);
            }
            if (ADSROn.Checked)
            {
                ADSR_Envelops(audio, Attack_Lvl_Value, Attack_Time_Value, Decay_Time_Value, Sustain_Lvl_Value, Sustain_Time_Value, Release_Time_Value);
            }
            if (Echo_OnOff.Checked)
            {
                Echo(audio, echo_duration);
            }
            if (PhaseInversion.Checked)
            {
                Phase_Inversion(audio);
            }
            WaveFileWriter.CreateWaveFile(filename, ConvertToWaveProvider16(audio, SAMPLE_RATE, CHANNEL));
            UpdateChart(chart1, audio);
        }
        
        /// <summary>
        /// Button for controlling sound duration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Audio_Duration_ValueChanged(object sender, EventArgs e)
        {
            audio_duration = (int)numericUpDown1.Value;
        }


        /// <summary>
        /// Play button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PlayButton_Click(object sender, EventArgs e)
        {
            WaveOut waveOut = new WaveOut();
            List<int> audio = GenerateMelody(audio_duration, frequency);
            if (Normalize_OnOff.Checked)
            {
                Normalize(audio);
            }
            if (ADSROn.Checked)
            {
                ADSR_Envelops(audio, Attack_Lvl_Value, Attack_Time_Value, Decay_Time_Value, Sustain_Lvl_Value, Sustain_Time_Value, Release_Time_Value);
            }
            if (Echo_OnOff.Checked)
            {
                Echo(audio, echo_duration);
            }
            if (PhaseInversion.Checked)
            {
                Phase_Inversion(audio);
            }

            waveOut.Init(ConvertToWaveProvider16(audio, SAMPLE_RATE, CHANNEL));
            waveOut.Play();

        }
        /// <summary>
        /// Echo duration button controller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Echo_duration_ValueChanged(object sender, EventArgs e)
        {
            echo_duration = (int)Echo_duration.Value;
        }
        /// <summary>
        /// Button for changing frequency of sound
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frequecny_ValueChanged(object sender, EventArgs e)
        {

            frequency = (int)numericUpDown2.Value;
        }

        /// <summary>
        /// Sine Wave Type button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sin_CheckedChanged(object sender, EventArgs e)
        {
            this.waveFunction = SinWave;
        }

        /// <summary>
        /// Square Wave Type button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Square_CheckedChanged(object sender, EventArgs e)
        {
            this.waveFunction = SquareWave;
        }

        /// <summary>
        /// Triangle Wave Type button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Triangle_CheckedChanged_1(object sender, EventArgs e)
        {
            this.waveFunction = TriangleWave;
        }

        /// <summary>
        /// Sawtooth Wave Type button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sawtooth_CheckedChanged_1(object sender, EventArgs e)
        {
            this.waveFunction = SawtoothWave;
        }            



        /// <summary>
        /// 8-bit format button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void x8bit_CheckedChanged(object sender, EventArgs e)
        {
            SHORT_MAX_VALUE = (int)Math.Pow(2, 7);
        }

        /// <summary>
        /// 16-bit format button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void x16bit_CheckedChanged(object sender, EventArgs e)
        {
            SHORT_MAX_VALUE = (int)Math.Pow(2, 15);
        }

        /// <summary>
        /// 24-bit format button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void x24bit_CheckedChanged(object sender, EventArgs e)
        {
            SHORT_MAX_VALUE = (int)Math.Pow(2, 23);
        }

        /// <summary>
        /// Volume scroller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Volume_ValueChanged_1(object sender, EventArgs e)
        {
            volume = (double)numericUpDown3.Value;
        }

        /// <summary>
        /// Chart updating algorithm
        /// </summary>
        /// <param name="chart"></param>
        /// <param name="data"></param>
        private void UpdateChart(Chart chart, List<int> data)
        {
            Series dataSeries = new Series();
            dataSeries.ChartType = SeriesChartType.Line;
            dataSeries.Points.DataBindY(data);

            chart.Series.Clear();
            chart.ChartAreas[0].AxisX.Maximum = SAMPLE_RATE;
            chart.Series.Add(dataSeries);
        }

        /// <summary>
        /// Attack Level Value scroller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Attack_Level_Scroller_ValueChanged(object sender, EventArgs e)
        {
            Attack_Lvl_Value = (float)Attack_Level_Scroller.Value;

        }

        /// <summary>
        /// Attack Time Value scroller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Attack_Time_Scroller_ValueChanged(object sender, EventArgs e)
        {
            Attack_Time_Value = (float)Attack_Time_Scroller.Value;

        }

        /// <summary>
        /// Decay Time Value scroller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Decay_Time_Scroller_ValueChanged(object sender, EventArgs e)
        {
            Decay_Time_Value = (float)Decay_Time_Scroller.Value;

        }

        /// <summary>
        /// Sustain Level Value scroller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sustain_Level_Scroller_ValueChanged(object sender, EventArgs e)
        {
            Sustain_Lvl_Value = (float)Sustain_Level_Scroller.Value;

        }

        /// <summary>
        /// Sustain Time Value scroller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sustain_Time_Scroller_ValueChanged(object sender, EventArgs e)
        {
            Sustain_Time_Value = (float)Sustain_Time_Scroller.Value;

        }

        /// <summary>
        /// Release Time Value scroller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Release_Time_Scroller_ValueChanged(object sender, EventArgs e)
        {
            Release_Time_Value = (float)Release_Time_Scroller.Value;
        }





        /// <summary>
        /// Lerp function used in ADSR_Envelops
        /// </summary>
        /// <param name="v0"></param>
        /// <param name="v1"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        float Lerp(float v0, float v1, float t)
        {
            return (1 - t) * v0 + t * v1;
        }

        /// <summary>
        /// ADSR Envelope
        /// </summary>
        /// <param name="sample">
        /// Audio sample
        /// </param>
        /// <param name="attack_lvl">
        /// Attack level
        /// </param>
        /// <param name="attack_time">
        /// Attack time
        /// </param>
        /// <param name="decay_time">
        /// Decay time
        /// </param>
        /// <param name="sustain_lvl">
        /// Sustain level
        /// </param>
        /// <param name="sustain_time">
        /// Sustain time
        /// </param>
        /// <param name="release_time">
        /// Release time
        /// </param>
        /// <returns></returns>
        private List<int> ADSR_Envelops(List<int> sample, float attack_lvl, float attack_time, float decay_time, float sustain_lvl, float sustain_time, float release_time)
        {
            int samples = sample.Count();
            int attack_length = (int)(samples * attack_time);
            int decay_length = (int)(samples * decay_time);
            int sustain_length = (int)(samples * sustain_time);
            int release_length = (int)(samples * release_time);
            int progress = 0;

            ///Adding Attack
       
            for (int i = 0; i < attack_length; i++)
            {
                sample[i] *= (int)Lerp(0, attack_lvl, progress / attack_length);
            }

            ///Adding Decay

            for (int i = attack_length; i < attack_length + decay_length; i++)
            {
                sample[i] *= (int)Lerp(attack_length, sustain_length, progress / decay_length);
            }

            ///Adding Sustain

            for (int i = attack_length + decay_length; i < attack_length + decay_length + sustain_length - 10; i++)
            {
                sample[i] *= (int)sustain_lvl;
            }

            ///Adding Release

            for (int i = attack_length + decay_length + sustain_length; i < attack_length + decay_length + sustain_length + release_length; i++)
            {
                sample[i] *= (int)Lerp(sustain_lvl, 0, progress / decay_length);
            }

            ///Generating silence for the rest of the melody
            
            for (int i = attack_length + decay_length + sustain_length + release_length; i < samples; i++)
            {
                sample[i] *= 0;
            }
            return sample;
        }

        /// <summary>
        /// Echo algorithm
        /// </summary>
        /// <param name="sample">
        /// Audio sample
        /// </param>
        /// <param name="durationInSeconds">
        /// Duraion of echo
        /// </param>
        /// <returns></returns>
        private List<int> Echo(List<int> sample, int durationInSeconds)
        {
            List<int> echo = new List<int>(); 

            int seconds = SAMPLE_RATE * durationInSeconds;

            for (int i = 0; i < sample.Count + seconds; i++)
            { 
                List<int> echoDelay = new List<int>();

                if (i < sample.Count)
                { 
                    echoDelay.Add(sample[i]);
                }
                if (i - seconds > 0)
                { 
                    echoDelay.Add(sample[i - seconds]);
                }

                foreach (var item in echoDelay)
                {  
                    echo.Add(item);
                }
            }
            return echo;
        }


        /// <summary>
        /// Normalize algorithm
        /// </summary>
        /// <param name="sample">
        /// Audio sample
        /// <returns></returns>
        private List<int> Normalize(List<int> sample)
        {
            List<int> normalizeList = new List<int>();
            int normalize = 0;
            for (int i = 0; i < sample.Count; i++)
            {
                normalize = Math.Max(normalize, sample[i]);
            }
            int Percentage = ((MAX_VALUE - 1) / normalize);

            for (int i = 0; i < sample.Count; i++)
            {
               int P = 0;
                P = (Percentage * sample[i]);
                sample[i] = P;
            }
            return normalizeList;
        }
        /// <summary>
        /// Phase Inversion algorithm
        /// </summary>
        /// <param name="sample">
        /// Audio sample
        /// </param>
        /// <param name="durationInSeconds">
        /// Duraion of Phase Inversion
        /// </param>
        /// <returns></returns>
        private List<int> Phase_Inversion(List<int> sample)
        {
            List<int> phase = new List<int>( new int[sample.Count]);
            
            for (int i = 0; i < sample.Count - 1; i++)
            {
                phase[i] = (int)Math.Pow(sample[i], -1);
            }
            return phase;
        }

    }
}

