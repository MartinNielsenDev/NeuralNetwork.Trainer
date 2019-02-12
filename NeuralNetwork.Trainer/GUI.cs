using NeuralNetwork.Trainer.BackProp;
using NeuralNetwork.Trainer.Patterns;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace NeuralNetwork.Trainer
{

    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class GUI : Form
    {
        #region Variables
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private Button button1;
        private Label label15;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog2;
        private Label label6;
        private TabPage tabPage1;
        private Label label17;
        private ProgressBar progressBar1;
        private Label label8;
        private Button button5;
        private Button button4;
        private Button button3;
        private Label label3;
        private OpenFileDialog openFileDialog3;
        private Button button2;
        private Label runningTimeLabel;
        private Label label2;
        private Label label5;
        private Label label1;
        private Label label4;
        private Label label9;
        private Label label7;
        private TextBox iterationsTextBox;
        private TextBox matrixHeightTextBox;
        private TextBox matrixWidthTextBox;
        private CheckBox checkBox1;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion
        #region OtherJunk
        public GUI()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.matrixHeightTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.matrixWidthTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iterationsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.runningTimeLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(392, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 384);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(392, 384);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.matrixHeightTextBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.matrixWidthTextBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.iterationsTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.runningTimeLabel);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(384, 358);
            this.tabPage1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Matrix Y:";
            // 
            // matrixHeightTextBox
            // 
            this.matrixHeightTextBox.Location = new System.Drawing.Point(343, 273);
            this.matrixHeightTextBox.Name = "matrixHeightTextBox";
            this.matrixHeightTextBox.Size = new System.Drawing.Size(37, 20);
            this.matrixHeightTextBox.TabIndex = 25;
            this.matrixHeightTextBox.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Matrix X:";
            // 
            // matrixWidthTextBox
            // 
            this.matrixWidthTextBox.Location = new System.Drawing.Point(343, 250);
            this.matrixWidthTextBox.Name = "matrixWidthTextBox";
            this.matrixWidthTextBox.Size = new System.Drawing.Size(37, 20);
            this.matrixWidthTextBox.TabIndex = 23;
            this.matrixWidthTextBox.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Iterations:";
            // 
            // iterationsTextBox
            // 
            this.iterationsTextBox.Location = new System.Drawing.Point(343, 226);
            this.iterationsTextBox.Name = "iterationsTextBox";
            this.iterationsTextBox.Size = new System.Drawing.Size(37, 20);
            this.iterationsTextBox.TabIndex = 21;
            this.iterationsTextBox.Text = "1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "2018 Test: ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(17, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "8px Test: ";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "24px Test: ";
            // 
            // runningTimeLabel
            // 
            this.runningTimeLabel.Location = new System.Drawing.Point(14, 236);
            this.runningTimeLabel.Name = "runningTimeLabel";
            this.runningTimeLabel.Size = new System.Drawing.Size(226, 17);
            this.runningTimeLabel.TabIndex = 17;
            this.runningTimeLabel.Text = "Running Time:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 24);
            this.button2.TabIndex = 16;
            this.button2.Text = "2. Train Network";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "RECOGNIZED";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(145, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(236, 45);
            this.label15.TabIndex = 13;
            this.label15.Text = "A";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "1. Create Network";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label17
            // 
            this.label17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label17.Location = new System.Drawing.Point(0, 318);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(384, 16);
            this.label17.TabIndex = 9;
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 334);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(384, 24);
            this.progressBar1.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 30);
            this.label8.TabIndex = 6;
            this.label8.Text = "outputNodes: 0";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 189);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 24);
            this.button5.TabIndex = 4;
            this.button5.Text = "Load trained network";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 24);
            this.button4.TabIndex = 3;
            this.button4.Text = "Save trained network";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 24);
            this.button3.TabIndex = 2;
            this.button3.Text = "3. Test Network";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 32);
            this.label3.TabIndex = 1;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "neuro";
            this.openFileDialog1.FileName = "OCRNetwork";
            this.openFileDialog1.Filter = "Neural network (*.neuro)|*.neuro";
            this.openFileDialog1.Title = "Load neural network";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "neuro";
            this.saveFileDialog1.FileName = "OCRNetwork";
            this.saveFileDialog1.Filter = "Neural network (*.neuro)|*.neuro";
            this.saveFileDialog1.Title = "Store the network";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.DefaultExt = "png";
            this.openFileDialog2.Filter = "Image (*.png)|*.png";
            this.openFileDialog2.Title = "Load a letter";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.CheckFileExists = false;
            this.openFileDialog3.CheckPathExists = false;
            this.openFileDialog3.Filter = "Image (*.png)|*.png";
            this.openFileDialog3.Multiselect = true;
            this.openFileDialog3.Title = "Open training images";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(302, 299);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Alphabet";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // GUI
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(592, 384);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GUI";
            this.ShowIcon = false;
            this.Text = "Neural Network Trainer";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI());
        }
        #endregion
        private static Stopwatch testTimer = new Stopwatch();
        public static string[] trainingSet = { };
        public PatternsCollection trainingPatterns;
        public OCRNetwork backpropNetwork;

        static public bool IsTerminated;
        public static string workingPath = String.Empty;
        public class OCRNetwork : BackPropagationRPROPNetwork
        {

            private GUI owner;
            public OCRNetwork(GUI owner, int[] nodesInEachLayer) : base(nodesInEachLayer)
            {
                this.owner = owner;
            }
            private int OutputPatternIndex(Pattern pattern)
            {
                for (int i = 0; i < pattern.OutputsCount; i++)
                    if (pattern.Output[i] == 1)
                        return i;
                return -1;
            }

            public void AddNoiseToInputPattern(int levelPercent)
            {
                int i = ((NodesInLayer(0) - 1) * levelPercent) / 100;
                while (i > 0)
                {
                    nodes[(int)(BackPropagationNetwork.Random(0, NodesInLayer(0) - 1))].Value = BackPropagationNetwork.Random(0, 100);
                    i--;
                }
            }

            public int BestNodeIndex
            {
                get
                {
                    int result = -1;
                    double aMaxNodeValue = 0;
                    double aMinError = double.PositiveInfinity;
                    for (int i = 0; i < this.OutputNodesCount; i++)
                    {
                        NeuroNode node = OutputNode(i);
                        if ((node.Value > aMaxNodeValue) || ((node.Value >= aMaxNodeValue) && (node.Error < aMinError)))
                        {
                            aMaxNodeValue = node.Value;
                            aMinError = node.Error;
                            result = i;
                        }

                    }
                    return result;
                }
            }
            private bool GetRandomInput(int index)
            {
                trainingSet = new string[owner.checkBox1.Checked == true ? 26 : 10];

                for (int i = 0; i < trainingSet.Length; i++)
                {
                    string randomFile;
                    string[] listOfFiles;
                    if (owner.checkBox1.Checked)
                    {
                        listOfFiles = Directory.GetFiles(workingPath, Convert.ToChar('A' + i) + "*.png"); // for the alphabet
                    }
                    else
                    {
                        listOfFiles = Directory.GetFiles(workingPath, i + "*.png"); // for numbers
                    }
                    if (listOfFiles.Length == 0)
                    {
                        MessageBox.Show("No files for number " + i + ".png inside " + workingPath + "\r\n\r\nTest will not continue");
                        return false;
                    }
                    else if (index >= listOfFiles.Length)
                    {
                        randomFile = listOfFiles[(int)Random(0, listOfFiles.Length - 1)];
                    }
                    else
                    {
                        randomFile = listOfFiles[index];
                    }

                    trainingSet[i] = randomFile;
                }
                return true;
            }
            public override void Train(PatternsCollection patterns)
            {
                int iteration = 0;
                Stopwatch timer = new Stopwatch();
                timer.Start();

                for (int inputSets = 0; inputSets < Convert.ToInt32(owner.iterationsTextBox.Text); inputSets++)
                {
                    Debug.WriteLine("Running inputset " + (inputSets + 1));
                    timer.Restart();
                    GetRandomInput(inputSets);
                    patterns = owner.CreateTrainingPatterns();
                    double error = 0, currentError = 1;
                    int good = 0;

                    while (good < patterns.Count)
                    {
                        if (IsTerminated || timer.ElapsedMilliseconds > 8000) return;
                        error = 0;
                        good = 0;

                        for (int i = 0; i < patterns.Count; i++)
                        {
                            for (int k = 0; k < NodesInLayer(0); k++)
                            {
                                nodes[k].Value = patterns[i].Input[k];
                            }

                            AddNoiseToInputPattern((int)Random(0, 2));
                            Run();
                            for (int k = 0; k < OutputNodesCount; k++)
                            {
                                error += Math.Abs(OutputNode(k).Error);
                                OutputNode(k).Error = patterns[i].Output[k];
                            }
                            Learn();
                            if (BestNodeIndex == OutputPatternIndex(patterns[i]))
                                good++;

                            iteration++;
                            Application.DoEvents();
                        }

                        foreach (NeuroLink link in links) ((EpochBackPropagationLink)link).Epoch(patterns.Count);

                        if ((iteration % 2) == 0)
                        {
                            currentError = (error / OutputNodesCount);
                            owner.label17.Text = "Error: " + currentError.ToString() + "  Iteration: " + iteration.ToString();
                        }
                        owner.progressBar1.Value = good;
                        owner.runningTimeLabel.Text = "Running Time: " + (double)timer.ElapsedMilliseconds + "ms";
                    }

                    owner.label17.Text = "Error: " + currentError.ToString() + "  Iteration: " + iteration.ToString();
                    owner.progressBar1.Value = good;

                }

            }
        }

        public PatternsCollection CreateTrainingPatterns()
        {
            int matrixWidth = Convert.ToInt32(matrixWidthTextBox.Text);
            int matrixHeight = Convert.ToInt32(matrixHeightTextBox.Text);
            PatternsCollection result = new PatternsCollection(trainingSet.Length, matrixWidth * matrixHeight, trainingSet.Length);

            for (int i = 0; i < trainingSet.Length; i++)
            {
                Bitmap original = new Bitmap(trainingSet[i]);

                double[] aBitMatrix = CharToDoubleArray(original, matrixWidth, matrixHeight);

                for (int j = 0; j < Convert.ToInt32(matrixWidthTextBox.Text) * Convert.ToInt32(matrixHeightTextBox.Text); j++)
                {
                    result[i].Input[j] = aBitMatrix[j];
                }
                result[i].Output[i] = 1;
            }
            return result;
        }
        public static double[] CharToDoubleArray(Bitmap image, int matrixWidth, int matrixHeight)
        {
            BitmapData data = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadWrite, image.PixelFormat);
            double[] result = new double[matrixWidth * matrixHeight];
            double xStep = (double)image.Width / (double)matrixWidth;
            double yStep = (double)image.Height / (double)matrixHeight;

            unsafe
            {
                byte* rgb = (byte*)data.Scan0;

                for (int x = 0; x < image.Width; ++x)
                {
                    for (int y = 0; y < image.Height; ++y)
                    {
                        int i = (int)((x / xStep));
                        int e = (int)(y / yStep);
                        int pos = (y * data.Stride) + (x * Image.GetPixelFormatSize(data.PixelFormat) / 8);

                        result[e * i + e] += Math.Sqrt(rgb[pos] * rgb[pos] + rgb[pos + 2] * rgb[pos + 2] + rgb[pos + 1] * rgb[pos + 1]);
                    }
                }
            }
            image.UnlockBits(data);
            image.Dispose();
            return Scale(result);
        }
        private static double MaxOf(double[] src)
        {
            double res = double.NegativeInfinity;
            foreach (double d in src)
                if (d > res) res = d;
            return res;
        }

        private static double[] Scale(double[] src)
        {
            double max = MaxOf(src);
            if (max != 0)
            {
                for (int i = 0; i < src.Length; i++)
                    src[i] = src[i] / max;
            }
            return src;
        }

        private static Bitmap Downscale(Bitmap original)
        {
            double widthPercent = (double)original.Width / 1920 * 1366;
            double heightPercent = (double)original.Height / 1080 * 768;
            //double widthPercent = (double)original.Width * 0.38;
            //double heightPercent = (double)original.Height * 0.38;
            int width = (int)widthPercent;
            int height = (int)heightPercent;
            Bitmap downScaled = new Bitmap(width, height);

            using (Graphics graphics = Graphics.FromImage(downScaled))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(original, 0, 0, downScaled.Width, downScaled.Height);
            }

            return downScaled;
        }

        private static Bitmap Upscale(Bitmap original)
        {
            double widthPercent = (double)original.Width / 1366 * 1920;
            double heightPercent = (double)original.Height / 768 * 1080;
            int width = (int)widthPercent + 1;
            int height = (int)heightPercent + 1;
            Bitmap upScaled = new Bitmap(width, height);

            using (Graphics graphics = Graphics.FromImage(upScaled))
            {
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(original, 0, 0, upScaled.Width, upScaled.Height);
            }

            return upScaled;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (openFileDialog3.ShowDialog(this) == DialogResult.OK)
            {
                workingPath = Path.GetDirectoryName(openFileDialog3.FileName);
            }
            int inputs = checkBox1.Checked == true ? 26 : 10;
            progressBar1.Maximum = inputs;
            backpropNetwork = new OCRNetwork(this, new int[3] { Convert.ToInt32(matrixWidthTextBox.Text) * Convert.ToInt32(matrixHeightTextBox.Text), (Convert.ToInt32(matrixWidthTextBox.Text) * Convert.ToInt32(matrixHeightTextBox.Text) + inputs) / 2, inputs });
            label8.Text = "outputNodes: " + inputs;
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            if (backpropNetwork == null)
            {
                MessageBox.Show("Create network first");
                return;
            }
            while (true)
            {
                if (IsTerminated) return;
                int inputs = checkBox1.Checked == true ? 26 : 10;
                backpropNetwork = new OCRNetwork(this, new int[3] { Convert.ToInt32(matrixWidthTextBox.Text) * Convert.ToInt32(matrixHeightTextBox.Text), (Convert.ToInt32(matrixWidthTextBox.Text) * Convert.ToInt32(matrixHeightTextBox.Text) + inputs) / 2, inputs });

                backpropNetwork.Train(trainingPatterns);

                break;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (backpropNetwork == null)
            {
                MessageBox.Show("Create network first");
                return;
            }
            testTimer.Restart();
            if (checkBox1.Checked)
            {
                label5.Text = "Big Test: " + Test("\\..\\..\\TrainData\\maps\\").ToString() + "%";
                label2.Text = "2018 Test: " + Test("\\..\\..\\TrainData\\maps\\2018\\").ToString() + "%";
            }
            else
            {
                label1.Text = "24px Test: " + Test("\\..\\..\\TrainData\\stats\\24px\\").ToString() + "%";
                label5.Text = "8px Test: " + Test("\\..\\..\\TrainData\\stats\\8px\\").ToString() + "%";
                label2.Text = "2018 Test: " + Test("\\..\\..\\TrainData\\stats\\2018\\").ToString() + "%";
            }
            testTimer.Stop();
        }
        private double Test(string path)
        {
            int matrixWidth = Convert.ToInt32(matrixWidthTextBox.Text);
            int matrixHeight = Convert.ToInt32(matrixHeightTextBox.Text);
            int correct = 0;
            int iterations = Convert.ToInt32(iterationsTextBox.Text);

            for (int i = 0; i < iterations; i++)
            {
                for (int j = 0; j < trainingSet.Length; j++)
                {
                    string randomFile;
                    string[] listOfFiles;
                    if (checkBox1.Checked)
                    {
                        listOfFiles = Directory.GetFiles(Directory.GetCurrentDirectory() + path, Convert.ToChar('A' + j) + "*.png"); // for the alphabet
                    }
                    else
                    {
                        listOfFiles = Directory.GetFiles(Directory.GetCurrentDirectory() + path, j + "*.png"); // for numbers
                    }
                    if(listOfFiles.Length == 0)
                    {
                        MessageBox.Show("No files for number " + j + ".png inside " + Directory.GetCurrentDirectory() + path + "\r\n\r\nTest will not continue");
                        return 0;
                    }
                    else if (i >= listOfFiles.Length)
                    {
                        randomFile = listOfFiles[(int)BackPropagationNetwork.Random(0, listOfFiles.Length - 1)];
                    }
                    else
                    {
                        randomFile = listOfFiles[i];
                    }
                    double[] aInput = CharToDoubleArray(new Bitmap(randomFile), matrixWidth, matrixHeight);

                    for (int k = 0; k < backpropNetwork.InputNodesCount; k++)
                    {
                        backpropNetwork.InputNode(k).Value = aInput[k];
                    }
                    backpropNetwork.Run();

                    if (backpropNetwork.BestNodeIndex == j)
                    {
                        correct++;
                    }
                }
                runningTimeLabel.Text = "Running Time: " + (double)testTimer.ElapsedMilliseconds + "ms";
                Application.DoEvents();
            }
            return Math.Floor(((double)correct / (double)trainingSet.Length) * 100 / iterations);
        }
        private void button4_Click(object sender, System.EventArgs e)
        {
            if (backpropNetwork == null)
            {
                MessageBox.Show("Create network first");
                return;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                backpropNetwork.SaveToFile(saveFileDialog1.FileName);
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            if (backpropNetwork == null)
            {
                MessageBox.Show("Network is not yet created.");
                return;
            }
        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            IsTerminated = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (backpropNetwork == null)
            {
                MessageBox.Show("Create network first");
                return;
            }
            int matrixWidth = Convert.ToInt32(matrixWidthTextBox.Text);
            int matrixHeight = Convert.ToInt32(matrixHeightTextBox.Text);
            string path = String.Empty;

            if (openFileDialog2.ShowDialog(this) == DialogResult.OK)
            {
                path = openFileDialog2.FileName;

                double[] aInput = CharToDoubleArray(new Bitmap(path), matrixWidth, matrixHeight);

                for (int i = 0; i < backpropNetwork.InputNodesCount; i++)
                {
                    backpropNetwork.InputNode(i).Value = aInput[i];
                }
                backpropNetwork.Run();
                label15.Text = Convert.ToChar('A' + backpropNetwork.BestNodeIndex).ToString() + "(" + backpropNetwork.BestNodeIndex + ")";
                pictureBox1.BackgroundImage = new Bitmap(trainingSet[backpropNetwork.BestNodeIndex]);
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }
}