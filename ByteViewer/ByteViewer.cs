using System.Numerics;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace ByteViewer
{
    public partial class ByteViewer : Form
    {
        private const int MaxByte = 1 << 16;
        private FileInfo? selectedFile;
        public ByteViewer()
        {
            InitializeComponent();
            RefreshUI();
        }
        private void RefreshUI()
        {
            ViewByteButton_Decimal.Visible = selectedFile != null;
            ViewByteButton_Hex.Visible = selectedFile != null;
            ResultBox.Visible = selectedFile != null;

            if (selectedFile == null || !selectedFile.Exists) return;

            bool validFile = selectedFile.Length <= MaxByte;
            if (!validFile) selectedFile = null;
            ViewByteButton_Decimal.Text = validFile ? "View Byte To Decimal" : $"Invalid File Size,";
            ViewByteButton_Hex.Text = validFile ? "View Byte To Hex" : $"Max File Size : {MaxByte}Byte";
        }

        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog diaglog = new OpenFileDialog();
            diaglog.InitialDirectory = @"C:";
            if (DialogResult.OK == diaglog.ShowDialog())
            {
                FileInfo info = new FileInfo(diaglog.FileName);
                var r = ToFileInfoString(info);
                InfoBox.Text = r.t;
                ResultBox.Clear();
                selectedFile = r.s ? info : null;
            }
            RefreshUI();
        }
        private (string t, bool s) ToFileInfoString(FileInfo info)
        {
            StringBuilder sb = new StringBuilder();

            if (!info.Exists) return ("Not exist file", false); ;

            sb.AppendLine(Environment.NewLine + $"File Information" + Environment.NewLine);
            sb.AppendLine($"File : {info.Name}");
            sb.AppendLine($"Path : {info.FullName}");
            sb.AppendLine($"Size : {info.Length} Byte");

            selectedFile = info;

            return (sb.ToString(), true);
        }

        private string ToFileByteString(FileInfo? info,string format)
        {
            StringBuilder sb = new StringBuilder();

            if (info == null || !info.Exists) return "Not exist file";

            try
            {
                FileStream stream = File.OpenRead(info.FullName);

                byte[] buffer = new byte[info.Length];
                int read = stream.Read(buffer, 0, buffer.Length);

                foreach (var b in buffer) sb.Append(b.ToString(format) + " ");
            }
            catch (IOException)
            {
                return "File is already opened";
            }


            return sb.ToString();
        }

        private void ViewByteButton_Click(object sender, EventArgs e)
        {
            ResultBox.Text = ToFileByteString(selectedFile,"");
        }
        private void ViewByteButton_Hex_Click(object sender, EventArgs e)
        {
            ResultBox.Text = ToFileByteString(selectedFile, "X");
        }
        private void ResultBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
