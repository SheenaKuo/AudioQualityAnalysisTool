using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioQualityAnalysisTool
{
    public partial class AudioQualityAnalysisTool : Form
    {
        private NAudio.Wave.WaveIn sourceStream = null;
        private NAudio.Wave.WaveFileWriter waveWriter = null;
        private NAudio.Wave.WaveFileReader wave = null;
        private NAudio.Wave.DirectSoundOut output = null;
        private SaveFileDialog savefile = null;
        private OpenFileDialog openfile = null;

        public AudioQualityAnalysisTool()
        {
            InitializeComponent();
            Stopbtn.Enabled = false;
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            List<NAudio.Wave.WaveInCapabilities> sources = new List<NAudio.Wave.WaveInCapabilities>();

            for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
            {
                sources.Add(NAudio.Wave.WaveIn.GetCapabilities(i));
            }

            sourceList.Items.Clear();

            foreach (var source in sources)
            {
                ListViewItem item = new ListViewItem(source.ProductName);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, source.Channels.ToString()));
                sourceList.Items.Add(item);
            }
        }

        private void Recordbtn_Click(object sender, EventArgs e)
        {
            if (sourceList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a device.");
                return;
            }

            savefile = new SaveFileDialog();
            savefile.Filter = "Wave File (*.wav) | *.wav;";
            if (savefile.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            Recordbtn.Enabled = false;
            Playbtn.Enabled = false;
            Stopbtn.Enabled = true;

            RecordAudio();
        }

        private void RecordAudio()
        {
            int iDeviceNumber = sourceList.SelectedItems[0].Index;

            sourceStream = new NAudio.Wave.WaveIn();
            sourceStream.DeviceNumber = iDeviceNumber;
            sourceStream.WaveFormat = new NAudio.Wave.WaveFormat(44100, NAudio.Wave.WaveIn.GetCapabilities(iDeviceNumber).Channels);

            sourceStream.DataAvailable += new EventHandler<NAudio.Wave.WaveInEventArgs>(sourceStream_DataAvailable);
            waveWriter = new NAudio.Wave.WaveFileWriter(savefile.FileName, sourceStream.WaveFormat);

            sourceStream.StartRecording();
        }

        private void sourceStream_DataAvailable(object sender, NAudio.Wave.WaveInEventArgs e)
        {
            if (waveWriter == null) return;

            waveWriter.WriteData(e.Buffer, 0, e.BytesRecorded);
            waveWriter.Flush();
        }

        private void Playbtn_Click(object sender, EventArgs e)
        {
            if (sourceList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a device.");
                return;
            }

            openfile = new OpenFileDialog();
            openfile.Filter = "Wave File (*.wav) | *.wav;";
            if (openfile.ShowDialog() != System.Windows.Forms.DialogResult.OK) return;

            Recordbtn.Enabled = false;
            Playbtn.Enabled = false;
            Stopbtn.Enabled = true;

            PlayAudio();
        }

        private void PlayAudio()
        {
            wave = new NAudio.Wave.WaveFileReader(openfile.FileName);
            output = new NAudio.Wave.DirectSoundOut();
            output.Init(new NAudio.Wave.WaveChannel32(wave));
            output.Play();
        }

        private void Stopbtn_Click(object sender, EventArgs e)
        {
            Recordbtn.Enabled = true;
            Playbtn.Enabled = true;
            Stopbtn.Enabled = false;

            if (sourceStream != null)
            {
                sourceStream.StopRecording();
                sourceStream.Dispose();
                sourceStream = null;
            }

            if (waveWriter != null)
            {
                waveWriter.Dispose();
                waveWriter = null;
            }

            if (wave != null)
            {
                wave.Dispose();
                wave = null;
            }

            if (output != null)
            {
                output.Stop();
                output.Dispose();
                output = null;
            }
        }
    }
}
