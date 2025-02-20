using System.Drawing.Imaging;

namespace MakeTransparent {
    public partial class Form1 : Form {

        readonly Color Transparant = Color.FromArgb(0, 255, 255, 255);

        public Form1() {
            InitializeComponent();
        }

        private void InputPng_TextChanged(object sender, EventArgs e) {
            TrimTextBoxQuotes((TextBox)sender);
        }

        private void InputPng_MouseLeave(object sender, EventArgs e) {
            ValidateInputPng();
        }

        private void OutputPngPath_MouseLeave(object sender, EventArgs e) {
            ValidateOutputPng();
        }

        private void Execute_Click(object sender, EventArgs e) {
            Success.Visible = false;
            Execute.Enabled = false;
            var valid = ValidateForExecute();
            if (valid) ReplacePixels();
            Execute.Enabled = true;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e) {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (filePaths.Length != 0) {
                InputPng.Text = filePaths[0];
                ValidateInputPng();
            }
        }

        static void TrimTextBoxQuotes(TextBox textBox) {
            if (textBox.Text.StartsWith('"') || textBox.Text.EndsWith('"'))
                textBox.Text = textBox.Text.Trim('"');
        }

        bool ValidateInputPng() {
            var validation = ValidatePng(InputPng.Text);
            if (!validation.Error) {
                InputPngError.Visible = false;
                if (string.IsNullOrEmpty(OutputPngPath.Text))
                    OutputPngPath.Text = Path.Combine(
                        Path.GetDirectoryName(InputPng.Text),
                        $"{Path.GetFileNameWithoutExtension(InputPng.Text)}-transparant{Path.GetExtension(InputPng.Text)}"
                    );
                return true;
            } else {
                InputPngError.Visible = true;
                InputPngError.Text = validation.ErrorMessage;
                return false;
            }
        }

        bool ValidateOutputPng() {
            var validation = ValidateNewFile(OutputPngPath.Text);
            if (!validation.Error) {
                OutputPngError.Visible = false;
                return true;
            } else {
                OutputPngError.Visible = true;
                OutputPngError.Text = validation.ErrorMessage;
                return false;
            }
        }

        bool ValidateForExecute() {
            var hasErrors = new bool[] {
                ValidateInputPng(),
                ValidateOutputPng()
            }.Any(result => !result);

            if (hasErrors) {
                ExecuteError.Visible = true;
                ExecuteError.Text = "Error: Please fix errors in input fields";
                return false;
            } else {
                ExecuteError.Visible = false;
                return true;
            }
        }

        void ReplacePixels() {
            try {
                using var bitmap = new Bitmap(InputPng.Text);
                for (var y = 0; y < bitmap.Height; y++) for (var x = 0; x < bitmap.Width; x++) {
                    var pixel = bitmap.GetPixel(x, y);
                    if (IsWhite(pixel))
                        bitmap.SetPixel(x, y, Transparant);
                }
                bitmap.Save(OutputPngPath.Text, ImageFormat.Png);
                Success.Visible = true;
                InputPng.Text = string.Empty;
                OutputPngPath.Text = string.Empty;
            } catch (Exception ex) {
                ExecuteError.Text = $"An error occurred: ${ex.Message}";
                ExecuteError.Visible = true;
            }
        }

        ValidationResult ValidateNewFile(string path) {
            if (string.IsNullOrEmpty(path))
                return new ValidationResult("Path must be set");

            if (!Directory.Exists(Path.GetDirectoryName(path)))
                return new ValidationResult("Must be in a existing directory");

            if (File.Exists(path))
                return new ValidationResult("File already exists, change its name");

            return new ValidationResult();
        }

        ValidationResult ValidatePng(string path) {
            if (string.IsNullOrEmpty(path))
                return new ValidationResult("Path must be set");

            if (!File.Exists(path))
                return new ValidationResult("Path does not exist");

            if (!Path.HasExtension(path) || Path.GetExtension(path) != ".png")
                return new ValidationResult("File must be a PNG");

            return new ValidationResult();
        }

        bool IsWhite(Color pixel) =>
            pixel.R == 255 && pixel.G == 255 && pixel.B == 255;

        class ValidationResult {
            public bool Error;
            public string ErrorMessage = string.Empty;
            public ValidationResult() { }
            public ValidationResult(string errorMessage) {
                Error = true;
                ErrorMessage = errorMessage;
            }
        }
    }
}
