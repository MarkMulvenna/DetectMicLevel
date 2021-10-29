using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetectMicLevel
{
    public partial class Form1 : Form
    {
        Boolean isKeyboardEnabled = true;

        public Form1()
        {
            InitializeComponent();

            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            cmbAudioDevices.Items.AddRange(devices.ToArray());

            BuildSpeechRecognize();
        }

        private void Sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == txtSafeWord.Text && e.Result.Confidence > Convert.ToDouble(numConfidence.Value))
            {
                SendKeys.Send("{PRTSC}");

                isKeyboardEnabled = true;

                lblKeyboardStatus.Text = "Enabled";

                System.Diagnostics.Debug.WriteLine(txtSafeWord.Text);
            }
            //else if((e.Result.Text == "fuck" || e.Result.Text == "shit" || e.Result.Text == "cunt" || e.Result.Text == "bastard" || e.Result.Text == "dick" || e.Result.Text == "motherfucker" || e.Result.Text == "dickhead" || e.Result.Text == "fucker" || e.Result.Text == "pussy" || e.Result.Text == "fucking" || e.Result.Text == "asshole") && e.Result.Confidence > .95)
            //{
            //    System.Diagnostics.Debug.WriteLine("swear: " + e.Result.Text);

            //    if (isKeyboardEnabled == true)
            //    {
            //        disableKeyboard();
            //    }
            //}
            else
            {
                Console.WriteLine("Based on confidence, I dont think you said " + txtSafeWord.Text);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (cmbAudioDevices.SelectedItem != null)
            {
                var device = (MMDevice)cmbAudioDevices.SelectedItem;
                pbPeak.Value = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100));

                if (device.AudioMeterInformation.MasterPeakValue >= Convert.ToDouble(numPeakLevel.Value) && isKeyboardEnabled == true)
                {
                    System.Diagnostics.Debug.WriteLine("peak: " + device.AudioMeterInformation.MasterPeakValue);

                    disableKeyboard();
                }
            }
        }

        private void disableKeyboard()
        {
            string ThisDir = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\KeyDisabler.ahk";
            Console.WriteLine(ThisDir);
            System.Diagnostics.Process.Start(ThisDir);

            lblKeyboardStatus.Text = "Disabled";

            isKeyboardEnabled = false;
        }

        private void txtSafeWord_TextChanged(object sender, EventArgs e)
        {
            BuildSpeechRecognize();
        }

        private void BuildSpeechRecognize()
        {
            //Creating my Speech Recognition Engine
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
            sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Sre_SpeechRecognized);

            //Creating a grammar builder object to declare acceptable input/s.
            //GrammarBuilder gb = new GrammarBuilder();
            //gb.Append(new Choices("sorry", "fuck", "shit", "cunt", "bastard", "dick", "motherfucker", "dickhead", "fucker", "pussy", "fucking", "asshole"));
            //Grammar grammar = new Grammar(gb);
            //sre.LoadGrammar(grammar);

            sre.LoadGrammar(new Grammar(new GrammarBuilder(txtSafeWord.Text)));
            sre.SetInputToDefaultAudioDevice();
            sre.RecognizeAsync(RecognizeMode.Multiple);
        }
    }
}