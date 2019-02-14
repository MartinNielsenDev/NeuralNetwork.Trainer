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
        private OpenFileDialog openFileDialog1;
        private OpenFileDialog openFileDialog2;
        private Label matrixYLabel;
        private TextBox matrixHeightTextBox;
        private TextBox matrixWidthTextBox;
        private TextBox iterationsTextBox;
        private Label matrixXLabel;
        private Label iterationsLabel;
        private Button trainNetworkButton;
        private Label recognizedLabel;
        private Label recognizedResultLabel;
        private Button createNetworkButton;
        private ProgressBar progressBar;
        private Label nodesLabel;
        private Button saveNetworkButton;
        private Button testNetworkButton;
        private Label headerLabel;
        private Button abortButton;
        private TextBox textBox1;
        private Button numbersOrAlphabetButton;
        private Button button1;
        private Button button2;

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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.matrixYLabel = new System.Windows.Forms.Label();
            this.matrixHeightTextBox = new System.Windows.Forms.TextBox();
            this.matrixWidthTextBox = new System.Windows.Forms.TextBox();
            this.iterationsTextBox = new System.Windows.Forms.TextBox();
            this.matrixXLabel = new System.Windows.Forms.Label();
            this.iterationsLabel = new System.Windows.Forms.Label();
            this.trainNetworkButton = new System.Windows.Forms.Button();
            this.recognizedLabel = new System.Windows.Forms.Label();
            this.recognizedResultLabel = new System.Windows.Forms.Label();
            this.createNetworkButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.nodesLabel = new System.Windows.Forms.Label();
            this.saveNetworkButton = new System.Windows.Forms.Button();
            this.testNetworkButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.abortButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numbersOrAlphabetButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "png";
            this.openFileDialog1.Filter = "Image (*.png)|*.png";
            this.openFileDialog1.Title = "Load a letter";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.CheckFileExists = false;
            this.openFileDialog2.CheckPathExists = false;
            this.openFileDialog2.Filter = "Image (*.png)|*.png";
            this.openFileDialog2.Multiselect = true;
            this.openFileDialog2.Title = "Open training images";
            // 
            // matrixYLabel
            // 
            this.matrixYLabel.AutoSize = true;
            this.matrixYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrixYLabel.Location = new System.Drawing.Point(224, 130);
            this.matrixYLabel.Name = "matrixYLabel";
            this.matrixYLabel.Size = new System.Drawing.Size(66, 20);
            this.matrixYLabel.TabIndex = 47;
            this.matrixYLabel.Text = "Matrix Y";
            this.matrixYLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matrixHeightTextBox
            // 
            this.matrixHeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrixHeightTextBox.Location = new System.Drawing.Point(142, 127);
            this.matrixHeightTextBox.Name = "matrixHeightTextBox";
            this.matrixHeightTextBox.Size = new System.Drawing.Size(70, 26);
            this.matrixHeightTextBox.TabIndex = 46;
            this.matrixHeightTextBox.Text = "8";
            this.matrixHeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.matrixHeightTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this._KeyDown);
            // 
            // matrixWidthTextBox
            // 
            this.matrixWidthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrixWidthTextBox.Location = new System.Drawing.Point(142, 101);
            this.matrixWidthTextBox.Name = "matrixWidthTextBox";
            this.matrixWidthTextBox.Size = new System.Drawing.Size(70, 26);
            this.matrixWidthTextBox.TabIndex = 44;
            this.matrixWidthTextBox.Text = "5";
            this.matrixWidthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.matrixWidthTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this._KeyDown);
            // 
            // iterationsTextBox
            // 
            this.iterationsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iterationsTextBox.Location = new System.Drawing.Point(142, 75);
            this.iterationsTextBox.Name = "iterationsTextBox";
            this.iterationsTextBox.Size = new System.Drawing.Size(70, 26);
            this.iterationsTextBox.TabIndex = 42;
            this.iterationsTextBox.Text = "1";
            this.iterationsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // matrixXLabel
            // 
            this.matrixXLabel.AutoSize = true;
            this.matrixXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrixXLabel.Location = new System.Drawing.Point(224, 104);
            this.matrixXLabel.Name = "matrixXLabel";
            this.matrixXLabel.Size = new System.Drawing.Size(66, 20);
            this.matrixXLabel.TabIndex = 45;
            this.matrixXLabel.Text = "Matrix X";
            this.matrixXLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iterationsLabel
            // 
            this.iterationsLabel.AutoSize = true;
            this.iterationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iterationsLabel.Location = new System.Drawing.Point(214, 78);
            this.iterationsLabel.Name = "iterationsLabel";
            this.iterationsLabel.Size = new System.Drawing.Size(76, 20);
            this.iterationsLabel.TabIndex = 43;
            this.iterationsLabel.Text = "Iterations";
            this.iterationsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trainNetworkButton
            // 
            this.trainNetworkButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.trainNetworkButton.FlatAppearance.BorderSize = 0;
            this.trainNetworkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trainNetworkButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.trainNetworkButton.Location = new System.Drawing.Point(16, 105);
            this.trainNetworkButton.Name = "trainNetworkButton";
            this.trainNetworkButton.Size = new System.Drawing.Size(120, 24);
            this.trainNetworkButton.TabIndex = 37;
            this.trainNetworkButton.Text = "2. Train Network";
            this.trainNetworkButton.UseVisualStyleBackColor = false;
            this.trainNetworkButton.Click += new System.EventHandler(this.trainNetwork_Click);
            // 
            // recognizedLabel
            // 
            this.recognizedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recognizedLabel.Location = new System.Drawing.Point(434, 39);
            this.recognizedLabel.Name = "recognizedLabel";
            this.recognizedLabel.Size = new System.Drawing.Size(223, 30);
            this.recognizedLabel.TabIndex = 36;
            this.recognizedLabel.Text = "RECOGNIZED";
            this.recognizedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recognizedResultLabel
            // 
            this.recognizedResultLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.recognizedResultLabel.Font = new System.Drawing.Font("Century Gothic", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recognizedResultLabel.Location = new System.Drawing.Point(434, 32);
            this.recognizedResultLabel.Name = "recognizedResultLabel";
            this.recognizedResultLabel.Size = new System.Drawing.Size(235, 341);
            this.recognizedResultLabel.TabIndex = 35;
            this.recognizedResultLabel.Text = "A";
            this.recognizedResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createNetworkButton
            // 
            this.createNetworkButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.createNetworkButton.FlatAppearance.BorderSize = 0;
            this.createNetworkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNetworkButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.createNetworkButton.Location = new System.Drawing.Point(16, 75);
            this.createNetworkButton.Name = "createNetworkButton";
            this.createNetworkButton.Size = new System.Drawing.Size(120, 24);
            this.createNetworkButton.TabIndex = 29;
            this.createNetworkButton.Text = "1. Create Network";
            this.createNetworkButton.UseVisualStyleBackColor = false;
            this.createNetworkButton.Click += new System.EventHandler(this.createNetwork_Click);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 373);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(669, 24);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 33;
            // 
            // nodesLabel
            // 
            this.nodesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodesLabel.Location = new System.Drawing.Point(16, 41);
            this.nodesLabel.Name = "nodesLabel";
            this.nodesLabel.Size = new System.Drawing.Size(123, 30);
            this.nodesLabel.TabIndex = 32;
            this.nodesLabel.Text = "Nodes: 0";
            this.nodesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveNetworkButton
            // 
            this.saveNetworkButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.saveNetworkButton.FlatAppearance.BorderSize = 0;
            this.saveNetworkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveNetworkButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveNetworkButton.Location = new System.Drawing.Point(16, 165);
            this.saveNetworkButton.Name = "saveNetworkButton";
            this.saveNetworkButton.Size = new System.Drawing.Size(120, 24);
            this.saveNetworkButton.TabIndex = 31;
            this.saveNetworkButton.Text = "Save Network";
            this.saveNetworkButton.UseVisualStyleBackColor = false;
            this.saveNetworkButton.Click += new System.EventHandler(this.SaveNetwork_Click);
            // 
            // testNetworkButton
            // 
            this.testNetworkButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.testNetworkButton.FlatAppearance.BorderSize = 0;
            this.testNetworkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testNetworkButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.testNetworkButton.Location = new System.Drawing.Point(16, 135);
            this.testNetworkButton.Name = "testNetworkButton";
            this.testNetworkButton.Size = new System.Drawing.Size(120, 24);
            this.testNetworkButton.TabIndex = 30;
            this.testNetworkButton.Text = "3. Test Network";
            this.testNetworkButton.UseVisualStyleBackColor = false;
            this.testNetworkButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.headerLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(669, 32);
            this.headerLabel.TabIndex = 28;
            this.headerLabel.Text = "NeuralNetwork.Trainer for Better Overwatch";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // abortButton
            // 
            this.abortButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.abortButton.FlatAppearance.BorderSize = 0;
            this.abortButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abortButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.abortButton.Location = new System.Drawing.Point(218, 165);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(72, 54);
            this.abortButton.TabIndex = 49;
            this.abortButton.Text = "Abort";
            this.abortButton.UseVisualStyleBackColor = false;
            this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 241);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(434, 132);
            this.textBox1.TabIndex = 0;
            // 
            // numbersOrAlphabetButton
            // 
            this.numbersOrAlphabetButton.BackColor = System.Drawing.Color.DarkOrange;
            this.numbersOrAlphabetButton.FlatAppearance.BorderSize = 0;
            this.numbersOrAlphabetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numbersOrAlphabetButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.numbersOrAlphabetButton.Location = new System.Drawing.Point(142, 195);
            this.numbersOrAlphabetButton.Name = "numbersOrAlphabetButton";
            this.numbersOrAlphabetButton.Size = new System.Drawing.Size(70, 24);
            this.numbersOrAlphabetButton.TabIndex = 51;
            this.numbersOrAlphabetButton.Text = "ABC";
            this.numbersOrAlphabetButton.UseVisualStyleBackColor = false;
            this.numbersOrAlphabetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(142, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 24);
            this.button1.TabIndex = 52;
            this.button1.Text = "Test single";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.testerPictureBox_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(16, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 24);
            this.button2.TabIndex = 53;
            this.button2.Text = "Load Network";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GUI
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(669, 397);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numbersOrAlphabetButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.matrixYLabel);
            this.Controls.Add(this.matrixHeightTextBox);
            this.Controls.Add(this.matrixWidthTextBox);
            this.Controls.Add(this.iterationsTextBox);
            this.Controls.Add(this.matrixXLabel);
            this.Controls.Add(this.iterationsLabel);
            this.Controls.Add(this.trainNetworkButton);
            this.Controls.Add(this.recognizedLabel);
            this.Controls.Add(this.recognizedResultLabel);
            this.Controls.Add(this.createNetworkButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.nodesLabel);
            this.Controls.Add(this.saveNetworkButton);
            this.Controls.Add(this.testNetworkButton);
            this.Controls.Add(this.headerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neural Network Trainer";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

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
                bool isAlphabet = owner.numbersOrAlphabetButton.Text == "ABC";
                trainingSet = new string[isAlphabet ? 26 : 10];

                for (int i = 0; i < trainingSet.Length; i++)
                {
                    string randomFile;
                    string[] listOfFiles;
                    if (isAlphabet)
                    {
                        listOfFiles = Directory.GetFiles(workingPath, Convert.ToChar('A' + i) + "*.png");
                    }
                    else
                    {
                        listOfFiles = Directory.GetFiles(workingPath, i + "*.png");
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
                timer.Restart();

                for (int inputSets = 0; inputSets < Convert.ToInt32(owner.iterationsTextBox.Text); inputSets++)
                {
                    if (!GetRandomInput(inputSets)) break;
                    patterns = owner.CreateTrainingPatterns();
                    double error = 0;
                    int good = 0;

                    while (good < patterns.Count)
                    {
                        if (IsTerminated) return;
                        error = 0;
                        good = 0;

                        for (int i = 0; i < patterns.Count; i++)
                        {
                            for (int k = 0; k < NodesInLayer(0); k++)
                            {
                                nodes[k].Value = patterns[i].Input[k];
                            }

                            AddNoiseToInputPattern((int)Random(1, 2));
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

                        owner.textBox1.Text = $"Running Time: {(double)timer.ElapsedMilliseconds}ms{Environment.NewLine}Iterations: {iteration}{Environment.NewLine}";
                        owner.progressBar.Value = good;
                    }
                    owner.textBox1.Text = $"Running Time: {(double)timer.ElapsedMilliseconds}ms{Environment.NewLine}Iterations: {iteration}{Environment.NewLine}";
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

        private void createNetwork_Click(object sender, EventArgs e)
        {
            IsTerminated = false;
            if (openFileDialog2.ShowDialog(this) == DialogResult.OK)
            {
                workingPath = Path.GetDirectoryName(openFileDialog2.FileName);
            }
            int inputs = numbersOrAlphabetButton.Text == "ABC" ? 26 : 10;
            progressBar.Maximum = inputs;
            backpropNetwork = new OCRNetwork(this, new int[3] { Convert.ToInt32(matrixWidthTextBox.Text) * Convert.ToInt32(matrixHeightTextBox.Text), (Convert.ToInt32(matrixWidthTextBox.Text) * Convert.ToInt32(matrixHeightTextBox.Text) + inputs) / 2, inputs });
            nodesLabel.Text = "Nodes: " + inputs;
        }

        private void trainNetwork_Click(object sender, System.EventArgs e)
        {
            IsTerminated = false;
            if (backpropNetwork == null)
            {
                MessageBox.Show("Create network first");
                return;
            }
                if (IsTerminated) return;
                int inputs = numbersOrAlphabetButton.Text == "ABC" ? 26 : 10;
                backpropNetwork = new OCRNetwork(this, new int[3] { Convert.ToInt32(matrixWidthTextBox.Text) * Convert.ToInt32(matrixHeightTextBox.Text), (Convert.ToInt32(matrixWidthTextBox.Text) * Convert.ToInt32(matrixHeightTextBox.Text) + inputs) / 2, inputs });
                backpropNetwork.Train(trainingPatterns);
        }
        private void TestButton_Click(object sender, EventArgs e)
        {
            IsTerminated = false;
            if (backpropNetwork == null)
            {
                MessageBox.Show("Create network first");
                return;
            }
            testTimer.Restart();
            textBox1.Text = "Tests finished!" + Environment.NewLine + Environment.NewLine;
            if (numbersOrAlphabetButton.Text == "ABC")
            {
                textBox1.Text += "Maps Test: " + Test("\\..\\..\\TrainData\\maps\\test_data\\").ToString() + "%" + Environment.NewLine;
                textBox1.Text += "Maps Test: " + Test("\\..\\..\\TrainData\\maps\\train_data\\").ToString() + "%" + Environment.NewLine;
            }
            else
            {
                textBox1.Text += "Ratings Test: " + Test("\\..\\..\\TrainData\\ratings\\test_data\\").ToString() + "%" + Environment.NewLine;
                textBox1.Text += "Numbers Test: " + Test("\\..\\..\\TrainData\\numbers\\test_data\\").ToString() + "%" + Environment.NewLine;
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
                    if (numbersOrAlphabetButton.Text == "ABC")
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
                textBox1.Text = "Running Time: " + (double)testTimer.ElapsedMilliseconds + "ms" + Environment.NewLine;
                Application.DoEvents();
            }
            return Math.Floor(((double)correct / (double)trainingSet.Length) * 100 / iterations);
        }
        private void SaveNetwork_Click(object sender, System.EventArgs e)
        {
            if (backpropNetwork == null)
            {
                MessageBox.Show("Create network first");
                return;
            }
            backpropNetwork.SaveToFile();
        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            IsTerminated = true;
        }

        private void testerPictureBox_Click(object sender, EventArgs e)
        {
            if (backpropNetwork == null)
            {
                MessageBox.Show("Create network first");
                return;
            }
            int matrixWidth = Convert.ToInt32(matrixWidthTextBox.Text);
            int matrixHeight = Convert.ToInt32(matrixHeightTextBox.Text);
            string path = String.Empty;

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                path = openFileDialog1.FileName;

                double[] aInput = CharToDoubleArray(new Bitmap(path), matrixWidth, matrixHeight);

                for (int i = 0; i < backpropNetwork.InputNodesCount; i++)
                {
                    backpropNetwork.InputNode(i).Value = aInput[i];
                }
                backpropNetwork.Run();
                if (numbersOrAlphabetButton.Text == "ABC")
                {
                    recognizedResultLabel.Text = Convert.ToChar('A' + backpropNetwork.BestNodeIndex).ToString();
                }
                else
                {
                    recognizedResultLabel.Text = backpropNetwork.BestNodeIndex.ToString();
                }
            }
        }

        private void abortButton_Click(object sender, EventArgs e)
        {
            IsTerminated = true;
        }

        private void _KeyDown(object sender, KeyEventArgs e)
        {
            backpropNetwork = null;
            nodesLabel.Text = "Nodes: 0";
        }

        private void alphabetCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            backpropNetwork = null;
            nodesLabel.Text = "Nodes: 0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(numbersOrAlphabetButton.Text.Equals("ABC"))
            {
                numbersOrAlphabetButton.Text = "123";
            }
            else
            {
                numbersOrAlphabetButton.Text = "ABC";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (backpropNetwork == null)
            {
                MessageBox.Show("Create network first");
                return;
            }
            Program.loadForm.Show();
            double[] a = { 3, 40, 33, 26, 5, 99, 2178, 1, 0, 0, 0, 0, 0, 0, 0, 0.22972972972973, 0, 0.211711711711712, 0, 0.351351351351352, 0, 0.360360360360361, 0, 0.454954954954956, 0, 0.310810810810811, 0, 0.355855855855857, 0, 0, 0, 0.558558558558561, 0, 0, 0, 0.297297297297298, 0, 0.0720720720720723, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.310810810810811, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.00450450450450452, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.896672058018419, 0.00159613409525735, 0.6, 0.01, 0.428615978806461, 0.00158890519774394, 0.6, 0.01, 0.555262118552158, -0.00322043259726024, 0.6, 0.01, 0.576888424986282, -0.0049772749447855, 0.6, 0.01, 0.739292998148287, -0.0056802950871562, 0.6, 0.01, 0.94917492090543, -0.000206702829320901, 0.6, 0.01, 0.902571566559472, -0.0036939282082875, 0.6, 0.01, 0.662957232285799, 0.00960392857354902, 0.6, 0.01, 0.628098848825672, 0.00121491545239702, 0.6, 0.01, 0.290509764596203, 0.0131424864034017, 0.6, 0.01, 0.0934231809838031, 0.000986509762641381, 0.6, 0.01, 0.189739899602855, -0.0249116403363977, 0.6, 0.01, 0.317647679380216, 0.00330144019622893, 0.6, 0.01, 0.5008712853755, 0.00161965622854007, 0.6, 0.01, 0.714437377349832, 0.00887290624953404, 0.6, 0.01, 0.752729412090384, 0.0232716144314482, 0.6, 0.01, 0.580023928652401, -0.000485645449818513, 0.6, 0.01, 0.699134321416424, 0.00846627587362987, 0.6, 0.01, 0.961340614349489, 0.00128105489400998, 0.6, 0.01, 0.403858484458175, -0.0111307261507106, 0.6, 0.01, 0.181956454100115, -0.00900855052875365, 0.6, 0.01, 0.115244155876996, -0.00467287269377429, 0.6, 0.01, 0.802977487134229, 0.00579982178789207, 0.6, 0.01, 0.691841828314218, 0.0250344671130807, 0.6, 0.01, 0.897033868101787, 0.00065977253970882, 0.6, 0.01, 0.719034846956551, 0.000744867531807676, 0.6, 0.01, 0.457282618927579, 0.00145118023942624, 0.6, 0.01, 0.0571769394763324, 0.00204232703874991, 0.6, 0.01, 0.217132762856179, -0.00080247202326745, 0.6, 0.01, 0.310131794076528, 0.00544226752368628, 0.6, 0.01, 0.0464877192703912, -0.000940055685209868, 0.6, 0.01, 0.809304661319053, -0.00625684077724414, 0.6, 0.01, 0.506552854447101, -0.00650168885627945, 0.6, 0.01, 0.00280732757854147, -7.76752635817669E-07, 0.6, 0.01, 0.0884894476672683, -0.00569674826945442, 0.6, 0.01, 0.000963490187166231, -4.06350884413418E-05, 0.6, 0.01, 0.0655578801874006, -0.00198556631416521, 0.6, 0.01, 0.0698852858225729, -0.0200939492210863, 0.6, 0.01, 0.058259094139691, -0.00298180181762482, 0.6, 0.01, 3.97242314766875E-05, -3.75478510380581E-08, 0.6, 0.01, 0.0103445822828666, -2.9316309133088E-05, 0.6, 0.01, 0.0844878971806267, -0.00554005966476955, 0.6, 0.01, 0.00676842865019959, -1.46501337893348E-05, 0.6, 0.01, 0.000662343169385522, -1.54614953724339E-05, 0.6, 0.01, 0.137306751081268, -0.000637449572460679, 0.6, 0.01, 3.51988406988608E-05, -1.2245910633339E-10, 0.6, 0.01, 0.000357111067283411, -6.60619552644432E-07, 0.6, 0.01, 0.00502275861511501, -3.77783063198101E-05, 0.6, 0.01, 0.0480290849099796, -0.00281160764795883, 0.6, 0.01, 0.00015403270038837, -2.05015577720698E-09, 0.6, 0.01, 0.0418689164210458, -0.000720934168491532, 0.6, 0.01, 0.00374028668425634, -9.70542522002179E-05, 0.6, 0.01, 0.0231856455650418, -0.00176129086804694, 0.6, 0.01, 0.00072418651405982, -9.48885773567856E-08, 0.6, 0.01, 0.00131114689287794, -6.39255838894792E-06, 0.6, 0.01, 1.60208071765247E-07, -3.32406112529703E-12, 0.6, 0.01, 0.0176666592736543, -6.89316928984575E-05, 0.6, 0.01, 0.0129627639059874, -0.00242262268390123, 0.6, 0.01, 0.753684723042657, 0.0375330326106711, 0.6, 0.01, -0.349311248393707, 1.87887988516365E-05, 0, -0.927628130807653, 1.2261059650573E-07, 0, 0.634345422211381, 0, 0, -0.833563700430656, 4.53650921246791E-06, 0, 0.289853521174801, 0, 0, 0.377852840662893, 0, 0, -0.683172802590678, 1.17847891531314E-05, 0, -0.234537732471132, 0, 0, 0.756532750752283, -4.33023009991653E-07, 0, 6.12865695248379, -8.52030170964668E-07, 0, -0.532157583475564, 0, 0, -0.15226523445559, 0, 0, 0.974538402088791, 0, 0, -0.0170616856855628, 0, 0, -0.756346446088142, 0, 0, 0.74506944017742, -6.09052324677816E-07, 0, 0.347005173561333, 4.29854380734673E-06, 0, -0.147916104247754, 0, 0, -0.740793321093549, 0, 0, -0.0278052049818472, 0, 0, -0.265445719428401, 1.64882293661589E-06, 0, 0.833855656157966, 2.8284556142364E-06, 0, -0.808129333801628, 0, 0, -0.578579809320429, 0, 0, -0.160173127334013, 1.66416944788628E-06, 0, 0.53595052079109, 0, 0, -0.81653388487945, 0, 0, 0.838091780356174, 0, 0, -0.87807024051841, 2.72090703608015E-06, 0, 0.732844347009828, 0, 0, -0.27416571568426, 0, 0, -0.0341521599489042, 0, 0, -0.583563759729063, 0, 0, -0.948588540753624, 0, 0, -0.479654090236711, 0, 0, -0.406798735916055, 0, 0, -0.500767024932786, 0, 0, -0.588136481860716, 0, 0, 0.758971337116776, 0, 0, -0.293642349212264, 0, 0, -0.0917084951495096, 7.12473643609386E-06, 0, 8.42341677780884, -3.5228917420389E-07, 0, 0.724997006436254, -1.3387765524357E-06, 0, 1.63540005653817, -4.75118277741353E-07, 0, 0.738155318174948, -2.07642340746918E-06, 0, 0.265104455081468, -3.8438787723797E-06, 0, -0.0105076784431275, 4.56628470210893E-06, 0, 0.551220710954506, -1.0828259742538E-07, 0, -0.979334975237777, 6.25687214366953E-06, 0, -0.349199313639534, 0, 0, -0.168119979336406, 3.65737817891077E-06, 0, -0.0542149334467086, 0, 0, -1.26457105715312, 2.48729289623341E-06, 0, -0.300285810278862, 0, 0, 2.46779574904929, -6.85480719712162E-06, 0, 0.485225437206359, -1.42147611088778E-06, 0, -0.751404124323568, -1.39884154726094E-06, 0, 0.338284039561769, 0, 0, 0.542478816607762, -1.76434995417946E-06, 0, 0.879261808413669, 0, 0, 0.572102903061959, -1.27387467440039E-06, 0, -0.126595930946522, -1.22701098720701E-06, 0, -0.629538846029685, 0, 0, 0.530091925305357, 0, 0, -1.53273188319361, 1.81271185654811E-06, 0, 0.048520572971795, 0, 0, -0.568701474726527, 0, 0, 0.469652939340869, 0, 0, -5.6567710737681, 1.92209160377868E-06, 0, 0.842480461039804, 0, 0, -0.247760013326891, 0, 0, -0.0603322196101455, 0, 0, 0.0931125586354697, 0, 0, 0.53907569755757, 0, 0, -0.625035268079972, 0, 0, -0.887016721948523, 0, 0, 0.23146782500272, 0, 0, -0.50398069690167, 0, 0, -0.153079125635828, 0, 0, 0.981082442207766, 0, 0, -0.189309060432283, 1.06862853106756E-05, 0, -0.0634967221026859, 2.02931571527468E-07, 0, 0.780686874386557, 0, 0, -0.988517764642823, 5.77291602231736E-06, 0, 0.0920396390589981, 0, 0, 0.743768508878489, -1.80736021472828E-06, 0, -0.0638295288279912, 0, 0, 0.669893349130932, 3.58931181853173E-06, 0, 0.0035397649588168, 0, 0, 0.361329555796872, 5.4800453221348E-06, 0, -0.532856614691147, 0, 0, 0.160948935505445, 0, 0, 0.143306179969525, 0, 0, 0.879709528703107, 0, 0, 0.157073366948699, 4.40068031498887E-06, 0, -1.03728726044498, 3.4069795607243E-06, 0, -0.761530023597015, 0, 0, -0.247900906600012, 0, 0, -0.461680861412757, 2.6426830392757E-06, 0, -0.474021256656396, 0, 0, -1.22564425615083, 3.52430715818402E-06, 0, 0.139872737725453, 2.3679338242265E-06, 0, -0.225567179371401, 0, 0, -0.711183389514304, 0, 0, 0.537849714436027, 1.68674041375778E-06, 0, 0.660018922602767, 0, 0, 0.852672507917822, 0, 0, -0.461006165231115, 0, 0, -1.34825252753239, 6.42753130146948E-07, 0, -0.0683470019457615, 0, 0, 0.971288215355616, 0, 0, 0.588920570718553, 0, 0, -0.508636834802403, 0, 0, 0.278926977551974, 0, 0, 0.0217421674270846, 0, 0, -0.537993988738392, 0, 0, -0.162333159317418, 0, 0, -0.707355730099304, 0, 0, -0.60306571871185, 0, 0, 0.234129933283725, 0, 0, -0.934755419282995, 0, 0, 5.10321999184555, -3.50502979192506E-07, 0, -0.298250348970778, -2.97338095052461E-06, 0, 0.38387442997521, -3.17679744362266E-06, 0, 0.479962264309619, -5.40690663709545E-06, 0, 0.397776565361301, 0, 0, 0.671368813336335, -5.85642783730884E-06, 0, 0.117905345402214, 0, 0, -0.891584458364116, 2.58226505146202E-07, 0, -0.683591566172081, -4.05898447973234E-06, 0, 0.790359512534317, -1.67947973281891E-06, 0, -0.520631268397268, 0, 0, 0.826392804245285, -5.05836632247762E-06, 0, -0.679057868979433, 0, 0, 2.50437036422419, -3.5409783115067E-06, 0, 2.0835496213595, -2.66197816806368E-06, 0, -1.26246548646632, 0, 0, 0.417978098344979, 0, 0, -0.67270344166504, 1.78403487133229E-06, 0, 0.473138721414441, 0, 0, 0.563726988761498, -3.35482499629183E-06, 0, -0.764607298803988, 1.28709593800916E-07, 0, 0.391972592748689, 0, 0, -0.924877814913577, 0, 0, -0.612528167322453, 0, 0, -0.0806591804514915, 0, 0, -0.330414229692153, 0, 0, 0.87292712082757, 0, 0, -2.19478371639767, 1.13269074104532E-06, 0, -0.164095261676281, 0, 0, 0.215101672902285, 0, 0, -0.975808288890779, 0, 0, -0.644835187888162, 0, 0, 0.447542278770144, 0, 0, -0.63476352190355, 0, 0, 0.778595562921183, 0, 0, -0.254099815736571, 0, 0, 0.629430285482402, 0, 0, -0.0454024602870469, 0, 0, -0.973520131769367, 0, 0, 0.636173144572551, 7.11244725942385E-06, 0, 5.31491300868229, -1.5991468406066E-07, 0, -0.597471789113402, 0, 0, 0.228189312464649, 0, 0, -0.127612032338935, 4.09791212155722E-06, 0, -0.199538630721497, 4.45370083552378E-06, 0, 0.538248323147114, 5.02505634785137E-06, 0, -0.913325828943271, 2.17349485896769E-06, 0, 0.443221510585452, 4.69879576489216E-06, 0, -0.337214410870051, 0, 0, -0.902263205681223, 2.3215401645012E-06, 0, 0.419688742337603, 0, 0, 1.45586227634069, 3.7254377031808E-06, 0, -0.0762044401262908, 0, 0, 0.11126760681802, 0, 0, 0.918063310924835, 2.31152501718077E-06, 0, -0.368854232499395, 3.06261372025886E-06, 0, -0.612244428886215, 0, 0, 0.609093922265301, 1.31441763156039E-06, 0, -0.585121748775766, 0, 0, -0.647435017308422, 1.86436562730288E-06, 0, -0.224509263436729, 2.82303112371966E-06, 0, -0.64456433134366, 0, 0, 0.405260209648525, 0, 0, -1.80473491178159, 0, 0, 0.771955585932338, 0, 0, -0.875796080509106, 0, 0, -0.633195187725683, 0, 0, -0.158489001359908, -1.99935061861694E-07, 0, 0.709314841641725, 0, 0, -0.0971584837404817, 0, 0, -0.457422216170198, 0, 0, -0.536619441367974, 0, 0, -0.566433903559313, 0, 0, 0.600933480821985, 0, 0, 0.288107231859168, 0, 0, -0.949044413840885, 0, 0, 0.38941935328274, 0, 0, -0.0603835159262566, 0, 0, 0.854382170296452, 0, 0, 0.32555393655557, 2.46854321586901E-05, 0, -0.87041194335106, -3.78372488413766E-07, 0, -0.564671812170429, 2.60103047223481E-06, 0, -2.82178986732622, 6.34305004290756E-06, 0, -0.0566115547382671, 7.40003581899402E-06, 0, 1.11685176170018, 6.61859746688053E-06, 0, -0.497026021736395, 1.77420541972271E-05, 0, 0.680578508558408, 5.59183620811899E-06, 0, -0.610001688348675, 9.67003556717598E-06, 0, -0.197512057874669, 1.74907482123575E-06, 0, -0.757067841655172, 4.54022363147039E-06, 0, -0.641855386850357, 0, 0, 0.814727157205558, 7.95454778954329E-06, 0, -0.460280711511281, 0, 0, 0.382951631198243, 1.39838718682681E-07, 0, 1.90177091958844, 0, 0, -0.616240174181777, 1.33551990284566E-06, 0, -0.107431322851885, 0, 0, 5.75898225321199, -3.64484501028662E-07, 0, 0.363550115080341, 0, 0, 2.14742604921371, 2.06467734545279E-07, 0, 6.86907064561647, -2.20654521603874E-07, 0, -0.785284618747087, 0, 0, -0.91829826865266, 0, 0, 1.32709996736024, 2.95604481370507E-07, 0, 0.747420158119602, 0, 0, -0.0436918162944223, 0, 0, 0.399032208788689, 0, 0, 16.6347167369438, -1.00767381215367E-08, 0, -0.98135400842007, 0, 0, 0.761002206132283, 0, 0, 0.933184528692246, 0, 0, 0.448139087040042, 0, 0, 0.944318710800409, 0, 0, 0.270110911349818, 0, 0, -0.577459455271, 0, 0, 0.832976013344236, 0, 0, -0.129531225715546, 0, 0, -0.140646586725789, 0, 0, 0.311681614868195, 0, 0, 0.522527533731689, 1.18400527187879E-05, 0, 0.249411358819485, 1.82751725384882E-07, 0, -0.831818889377535, 3.43105641618512E-06, 0, 0.825436443181344, 0, 0, 0.195488514374723, 6.45413486168309E-06, 0, -0.505948983793951, 3.62565418735695E-06, 0, -0.220469617598452, 0, 0, 0.874974935947224, 2.1274543784118E-06, 0, 0.261776861260439, 7.70138744697862E-06, 0, 6.21925833061899, -5.56164321293622E-07, 0, -0.0627412252793832, 3.3231577496219E-06, 0, 0.158386909011, 0, 0, -0.544368039777563, 5.78327862610587E-06, 0, 0.576066368993403, 0, 0, -0.593115094527726, 2.46298086413828E-06, 0, 0.688312338278558, 1.38264025194394E-06, 0, -0.782565292931527, 3.87165808056653E-06, 0, -0.999791183508835, 0, 0, 0.477939894725096, -1.24011490819791E-06, 0, -0.201513361745287, 0, 0, -1.24929107354334, 2.93703296897084E-06, 0, -0.235219509401168, -7.42686883794425E-07, 0, -0.891492826813596, 0, 0, -0.877856936248884, 0, 0, -0.42374474595148, 0, 0, -0.477192847746049, 0, 0, -0.0899944738903988, 0, 0, 0.886410693585133, 0, 0, 0.460697898124483, -2.5861757195705E-06, 0, -0.317765957358184, 0, 0, -0.87565733393452, 0, 0, 0.413365035044665, 0, 0, -0.966784736126095, 0, 0, 0.583777079164878, 0, 0, 0.783187935027847, 0, 0, -0.325119102990776, 0, 0, 0.181752910456505, 0, 0, -0.187711585866153, 0, 0, -0.171621429348188, 0, 0, 0.925462047534744, 0, 0, 0.0749265833618107, -3.09002708247154E-06, 0, -0.0903727496792069, -2.09992249381067E-09, 0, -1.03991721219375, -1.30564458407649E-06, 0, 0.729877284660734, 0, 0, -0.0443480194206135, -2.83170052826715E-06, 0, -0.456105291349213, -1.35393129139742E-06, 0, 0.437632268598797, 3.68324917413008E-07, 0, 0.78527267164369, 1.92255177639908E-06, 0, 0.465619802326832, -1.90473599248281E-06, 0, 0.515748467902631, 2.7071128448048E-06, 0, -0.905606162268659, -7.63961658559398E-07, 0, 0.832767196853071, 0, 0, 0.922192607772248, -4.8046495319083E-06, 0, -0.939133224980502, 0, 0, -0.778076344761387, 3.98042662650945E-06, 0, -0.196348614725751, 9.31669301292863E-07, 0, -0.159137696070629, -2.85612400545889E-06, 0, -0.896127306807845, 0, 0, -0.234025929262907, -6.28519437488898E-07, 0, -0.269483991558423, 0, 0, 0.648273778764405, 9.37536330302629E-08, 0, -0.155508199266989, 1.1026801054458E-06, 0, -0.345947106995595, 0, 0, -0.353442533571945, 0, 0, -0.181154521582893, -3.02979961234499E-07, 0, 0.590908387485383, 0, 0, 0.125171645137096, 0, 0, -0.0898164199152106, 0, 0, 0.0924517770358735, -4.920921768244E-07, 0, 0.811785709025239, 0, 0, -0.444754237981864, 0, 0, 0.472160940744058, 0, 0, 0.171830245839353, 0, 0, 0.0893458961925218, 0, 0, 0.762914859579371, 0, 0, 0.806457833296833, 0, 0, -0.277679502627663, 0, 0, -0.570740104453052, 0, 0, 0.107770494701234, 0, 0, -0.810338817448513, 0, 0, 1.29124963506008, 0, 0, -0.60653239964326, -8.44006650869529E-07, 0, -0.666443944559963, 0, 0, 1.29402982192313, 3.79194379390858E-06, 0, -0.563096932316245, 1.61862417242467E-05, 0, -1.16571971875747, 1.79443476006699E-05, 0, 1.47782615967441, 2.02362569108586E-05, 0, 2.18001484110311, 0, 0, 1.31886656340449, 0, 0, 1.20305330431521, 0, 0, -1.3162404097677, 9.53744937667492E-06, 0, 0.0778802172643507, 0, 0, -2.67514878653724, 2.65772642820236E-05, 0, -0.902137437789765, 0, 0, -1.1081609019894, 9.77950842124908E-06, 0, -2.75424384494242, 7.0163488266488E-06, 0, -4.82499998789237, 9.69174024722934E-06, 0, 0.423683233290763, 0, 0, -0.596121749415451, 8.20854675108602E-06, 0, 0.423464181564499, 0, 0, -0.16200814198684, 4.63984174168823E-06, 0, -0.537135312809913, 5.89346994311401E-06, 0, -0.920805715918916, 0, 0, 0.645866395740708, 0, 0, -1.0363171436372, 6.13531883668167E-06, 0, -0.334069750892962, 0, 0, -0.339063048986282, 0, 0, -0.233685065635333, 0, 0, -2.7247575621949, 0, 0, -0.333880965287742, 0, 0, -0.934519514410998, 0, 0, -0.844932401480587, 0, 0, -0.00389780150907948, 0, 0, -0.579510695105191, 0, 0, 0.646932725630204, 0, 0, -0.403241431062688, 0, 0, -0.603320902960059, 0, 0, -0.08244324525932, 0, 0, -0.897585386362665, 0, 0, 0.22769666613438, 0, 0, -0.772284182386591, -9.16888352249881E-06, 0, -0.641655204629683, 7.13246036860522E-08, 0, -0.204408140554784, 1.24004773054938E-06, 0, 0.264031367823427, -2.20692817449375E-07, 0, 0.224283651035398, -1.5837912911178E-06, 0, 0.259606478313356, -1.38058268211359E-06, 0, 0.0522639476160781, -2.74998145182556E-06, 0, 0.268479318244619, -2.20765393273772E-06, 0, -0.00691313972644723, -5.3720031311058E-06, 0, -0.993164526861679, 7.63213956886056E-07, 0, -0.0176610157240846, -1.40758959476756E-06, 0, 0.298637264081574, 0, 0, -1.11210621282353, 4.46278211198483E-07, 0, 0.684306313136735, 0, 0, 1.4060085886251, -1.21687292773441E-07, 0, -0.279254400029037, -2.02774686556632E-06, 0, -5.84430502296616, 1.46750086302384E-06, 0, -0.217107806921521, 0, 0, 1.45242071946449, -1.61459813601157E-06, 0, 0.878212603683682, 0, 0, 0.146412183171201, -5.73946651640822E-07, 0, 0.658177682186402, -2.07105894022883E-06, 0, 0.674396573414279, 0, 0, -0.554918823556471, 0, 0, -3.13456770856726, 0, 0, 0.93548580442345, 0, 0, -0.91822198122657, 0, 0, 0.781648621792741, 0, 0, -1.19352099351516, -1.18685486772047E-07, 0, 0.694012101597158, 0, 0, 0.813454995776273, 0, 0, 0.461037265817186, 0, 0, 0.321268619653428, 0, 0, -0.0677215238417134, 0, 0, 0.390259998566592, 0, 0, -0.675379504298502, 0, 0, -0.269943079571213, 0, 0, 0.281702802182037, 0, 0, 0.924634089658332, 0, 0, 0.500500932103256, 0, 0, -0.0278054555358195, 0, 0, 0.83414593188187, 5.33690193603034E-07, 0, 3.10895412117927, -9.72220702919543E-07, 0, -1.26169416187396, 3.82414256144624E-06, 0, 2.23258961062793, -6.3508567335263E-06, 0, 0.800967060221916, 6.67749136567823E-08, 0, 0.190957673692329, 1.15320091690159E-06, 0, -0.113596421791129, 6.0425880595147E-08, 0, 1.26583642150905, -1.01647185614755E-05, 0, -5.9308010690971, 1.97734853945073E-06, 0, -0.279034079646422, 0, 0, 0.613786903961462, 0, 0, -1.01278091567646, -2.25819169942456E-06, 0, -0.775797990046347, 0, 0, -0.673375810592682, 5.20367768861295E-06, 0, 0.886633128289086, -1.37629545105383E-06, 0, 0.894893447138709, 4.86306915616695E-06, 0, 0.353902192485473, 0, 0, 0.776456226798793, 3.94578824544742E-07, 0, 0.785746501658925, 0, 0, 0.261718960114176, 2.53475202796969E-06, 0, -2.71711484948305, 1.81196750687965E-06, 0, -0.376962152950914, 0, 0, 0.104563124060893, 0, 0, 0.535638060906042, 5.98378215281743E-07, 0, 0.96682654692178, 0, 0, 0.977368644428146, 0, 0, 0.337006277095995, 0, 0, -8.90282720696372, 6.63873933121368E-07, 0, -0.612402965134197, 0, 0, 0.824486073024797, 0, 0, 0.677035721799841, 0, 0, -0.141741896579853, 0, 0, 0.258128729303427, 0, 0, -0.517694631366848, 0, 0, -0.95633074918591, 0, 0, -0.176350438583805, 0, 0, -0.0707745752626912, 0, 0, 0.206825954470237, 0, 0, -0.836936755029921, 0, 0, -0.687910462392403, 0, 0, 0.0784872503748162, 1.27104801497639E-07, 0, -0.805845711980511, 2.14631292689203E-06, 0, 2.45780318368571, -9.08665980605491E-06, 0, -0.681621364908998, 0, 0, -1.04982657165468, 1.39715981975548E-06, 0, 0.66168638821807, -1.06225733531436E-05, 0, 0.307049153197953, 0, 0, 0.597606906671875, 0, 0, -0.641572370810327, 0, 0, 0.139657130074332, -2.7310767611511E-06, 0, 0.376154727943314, 0, 0, 0.752990373729099, -2.71304041617477E-06, 0, -0.861112412000593, 0, 0, -5.05600929810264, 0, 0, 3.00679592206907, -2.7743815016301E-06, 0, 0.278450805393416, 3.69585288554327E-06, 0, -0.136823415354278, 0, 0, 2.10510845697239, -3.16464984715722E-06, 0, 0.271428675051512, 0, 0, 0.150270760907923, 0, 0, 0.0242153923709974, -5.18077787583519E-06, 0, 0.0177495707840425, 0, 0, 0.320674739461706, 0, 0, -1.40438097749881, 1.93267277106353E-06, 0, 0.960984323155593, 0, 0, -0.244471199458684, 0, 0, -0.099201635969431, 0, 0, 1.79103455307829, -2.52431648691018E-06, 0, 0.553388897121599, 0, 0, -0.581834648541098, 0, 0, -0.450798841868899, 0, 0, -0.852923761984764, 0, 0, 0.704521770451461, 0, 0, 0.736043542500606, 0, 0, -0.37439460743889, 0, 0, 0.414997544798533, 0, 0, 0.264497742645674, 0, 0, 0.0485710674191691, 0, 0, 0.539657679172073, 0, 0, -0.356791165044055, -5.49532070887627E-06, 0, -5.99399198003221, -1.5055653113602E-08, 0, -1.1924819007185, 1.01884351022332E-06, 0, -1.9002945896984, 2.80132512110777E-06, 0, 0.46259248639091, 7.7589752080202E-07, 0, -0.553407384468443, -2.93540567486635E-07, 0, -0.829923096699999, 1.32398932221846E-06, 0, -0.311824650604095, -1.07795518293235E-06, 0, 0.140022311440153, -1.85628482148513E-06, 0, -1.76443720632331, 7.19984139881777E-07, 0, -0.0911497549146305, -4.72746682958391E-07, 0, 0.960472976770472, 0, 0, 1.01840069111987, -2.2499500314524E-06, 0, 0.935397279418724, 0, 0, 0.43539891724851, 1.60519169026415E-07, 0, 0.561077358701096, -1.58193302753499E-06, 0, 0.87697259560698, 0, 0, -0.247297891996474, 0, 0, -0.829965371580865, 1.40936281213815E-06, 0, -0.904992266513869, 0, 0, 0.424130615427019, -3.28509067199982E-07, 0, -0.67860939650965, 2.76057097749013E-06, 0, 0.355169968379275, 0, 0, 0.781831431100998, 0, 0, 0.669205850542676, -4.65940610333406E-07, 0, -0.703007245298013, 0, 0, 0.229078489928077, 0, 0, 0.709596016309036, 0, 0, -0.802845197014413, 4.92493979800458E-07, 0, 0.479308013561791, 0, 0, -0.507464702011768, 0, 0, 0.69943367768984, 0, 0, 0.814605517226553, 0, 0, 0.466187698518013, 0, 0, -0.393287699387077, 0, 0, 0.909172542350913, 0, 0, -0.453009380704262, 0, 0, -0.127851658094605, 0, 0, 0.779271617428992, 0, 0, -0.180427685929662, 0, 0, 1.03896984584567, -1.94013671861929E-06, 0, -4.14015192058112, -6.80963180140605E-08, 0, 1.11050813670304, -2.89265144090511E-06, 0, 0.199002807181855, -5.74404989602476E-07, 0, -0.113707630624486, -8.49517444381941E-06, 0, -0.179382529458571, -4.9895499470316E-06, 0, -0.0112537930631224, -4.30155096972099E-06, 0, -0.450776816791991, 3.7840866908133E-07, 0, -0.287821541843999, 2.6161358912449E-07, 0, -0.384150708544931, -3.88188046306692E-07, 0, 0.219035201183446, -1.45450711098457E-06, 0, -0.337704563204993, 0, 0, 0.545962075040001, -1.50540617995916E-06, 0, -0.0464366660669616, 0, 0, -2.81172971374935, 3.81978480137867E-06, 0, -0.535257317519381, -1.32858004220082E-06, 0, 1.26761075251264, -1.69141727255728E-06, 0, -0.7800454822276, 0, 0, -2.63880663081989, 1.14063023849578E-06, 0, 0.244410367330727, 0, 0, 0.961731541316956, -1.935555200721E-06, 0, -0.212307507116925, -6.20518402898762E-07, 0, -0.683473530078062, 0, 0, 0.673907309618735, 0, 0, -0.543706175963488, 8.60180304415568E-07, 0, 0.380304152788736, 0, 0, -0.854132540456081, 0, 0, -0.542807651470791, 0, 0, 0.653198263745589, -1.15485358192654E-06, 0, 0.464416125539884, 0, 0, -0.0460642283065543, 0, 0, -0.119915779270192, 0, 0, -0.0265695094254658, 0, 0, 0.271064131181251, 0, 0, -0.603058654630118, 0, 0, 0.407981006152919, 0, 0, -0.346271232397422, 0, 0, -0.811954147094839, 0, 0, 0.308180364457974, 0, 0, 0.272587359544163, 0, 0, 0.912542689107416, 1.35185546089924E-05, 0, 0.0663398756211334, -2.05489487265414E-07, 0, 0.314840422405174, 3.14418038040549E-06, 0, -0.896095597355818, 4.19279424168924E-06, 0, -0.0874975888220856, 4.71352573300939E-06, 0, 1.29045108730818, 0, 0, -0.538250111047442, 1.46008416315547E-05, 0, 0.167609410835547, 4.16032182869237E-06, 0, 0.677236538161467, 5.59985519591259E-06, 0, -0.453735918694264, 3.6379466411382E-06, 0, -0.307409415898229, 0, 0, -0.672963898476662, 0, 0, -0.277108010179869, 0, 0, -0.465138749901736, 0, 0, 1.07969981707959, 0, 0, 0.0341124226226636, 9.31693365393677E-07, 0, 1.41654173449231, 6.1239608438992E-07, 0, -0.926324268768693, 0, 0, -0.19746936488116, 3.32335496526497E-06, 0, 0.0933469138542875, 0, 0, 3.09333049262967, -8.55614193876372E-07, 0, -1.11372748994245, 2.47643815830932E-06, 0, -0.117006020209289, 0, 0, -0.13348302297922, 0, 0, 0.795676314390312, 4.91890468912272E-07, 0, 0.993288609196101, 0, 0, 0.688864946220473, 0, 0, 0.902797166212833, 0, 0, -0.0221621485892962, 0, 0, -0.312462618254341, 0, 0, 0.60967579838339, 0, 0, 0.337086213443934, 0, 0, -0.0882258466855743, 0, 0, 0.142734135101891, 0, 0, 0.573238723712619, 0, 0, -0.798146676178159, 0, 0, 0.174659004981936, 0, 0, -0.851200424065441, 0, 0, 0.0679721259828527, 0, 0, -0.74800263333507, 0, 0, -0.308193762881167, 0, 0, 0.730880731810343, -9.79807342942952E-07, 0, -0.328566778568267, -2.40778665921895E-06, 0, -0.0962236503444126, 6.95611236224627E-06, 0, -0.462836737612575, -2.85162571468875E-06, 0, -0.828312621243484, 0, 0, -0.800898645634908, 1.75484964828845E-05, 0, -0.707648278126973, 0, 0, 0.916479477549693, -1.70139893214342E-05, 0, 0.310686769252559, 5.16746202544433E-06, 0, 2.64760026258555, -1.03885357249454E-05, 0, -0.419946963628729, 0, 0, 0.320843767647241, -1.45624675364647E-05, 0, -0.785166549396313, 0, 0, 1.58722160702964, 0, 0, 0.512106802444735, 2.44800880762072E-06, 0, -1.63209643983507, 5.43447184330246E-06, 0, -0.487854063272408, 0, 0, -0.289247531077454, -2.04316649344249E-07, 0, -0.387353425560218, 0, 0, -1.62512707640317, 2.69425583982998E-06, 0, 0.226120127643457, 6.58018860649675E-06, 0, -0.695579805269642, 0, 0, -0.316868071126225, 0, 0, -0.153660357634833, -4.49122891273827E-06, 0, 0.0469542625578838, 0, 0, 0.415261948208912, 0, 0, 0.314092712157449, 0, 0, 5.67226605998821, -3.60396796799497E-06, 0, 0.398466135095091, 0, 0, 0.970085464404004, 0, 0, 0.570832239264079, 0, 0, 0.0057036052484547, 0, 0, -0.16711047904897, 0, 0, -0.761384858638693, 0, 0, 0.0269996388941069, 0, 0, 0.0821057246448964, 0, 0, 0.897616735611864, 0, 0, 0.786141327482714, 0, 0, -0.345718290352131, 0, 0, 1.25119756180842, 0, 0, 0.272484173185473, -6.34929206710946E-07, 0, -0.850863723034921, 5.30886303082966E-06, 0, 3.64967001251273, 0, 0, 0.0488699950767843, 1.39901357799769E-05, 0, 0.0853931763515792, 4.32985677584035E-06, 0, -0.661896724409438, 0, 0, -0.389338900585893, 7.23967810158719E-06, 0, -0.904307912594393, 1.16795055488219E-05, 0, -1.01558376064745, 6.47035434096451E-06, 0, -0.327825914424404, 0, 0, -0.337486931745655, 0, 0, 0.11461871544217, 0, 0, -0.544674448456929, 0, 0, -1.29515662631927, 6.14056605652944E-06, 0, -0.891328700134098, 4.14946427908273E-06, 0, -0.11804853090036, 1.96281327024393E-07, 0, -0.596608890964002, 0, 0, -0.576589187141747, 0, 0, -0.966578613019818, 0, 0, -0.123934900045836, 3.31966264150563E-06, 0, 2.03717660820264, 0, 0, 0.476946714090624, 0, 0, -0.727721462830771, 0, 0, -0.371444864949777, 3.68091219743307E-06, 0, -0.882483048309797, 0, 0, 0.574349431122816, 0, 0, -0.729730555661829, 0, 0, 2.45316470029371, 0, 0, 0.933762805505545, 0, 0, -0.579562843581458, 0, 0, -0.76321118407101, 0, 0, -0.273995390755122, 0, 0, -0.767736195478466, 0, 0, 0.0426153387141486, 0, 0, -0.108920790771451, 0, 0, -0.609277279865591, 0, 0, -4.9178488575885E-06, 0, 0, 0.683943738082398, 0, 0, 0.704009174231444, 0, 0, 0.163035768184805, -1.5450996081857E-05, 0, -3.0101136885065, -1.07501707810041E-06, 0, -3.75049318751061, 4.56819323633487E-06, 0, -0.109044898593687, -2.30327913614104E-06, 0, -0.432821303621449, 1.47837701523507E-05, 0, 0.393197096553204, -2.41444309611555E-06, 0, -0.831652592144111, 4.4856476785291E-06, 0, -0.0996131925129623, -1.17594619275582E-06, 0, -0.0772272462594659, -6.86932751776596E-06, 0, -0.921018397723583, 5.50696456012928E-06, 0, 0.865759217842715, -1.09125120439132E-05, 0, -0.321285384391102, 0, 0, 0.988400133186624, -7.06623619440892E-06, 0, 0.752719940502532, 0, 0, 0.645537002695179, 3.45150882655305E-06, 0, -0.576190944166423, 1.56687126799537E-06, 0, 1.12335774543523, -7.47322195067271E-06, 0, 0.959773956779285, 0, 0, -1.53993843877887, 9.75625736092175E-06, 0, -0.118328760898825, 0, 0, 0.805282084670958, -4.96381241074996E-06, 0, 1.0524989806235, 4.05500670822966E-06, 0, -0.279277606531641, 0, 0, -0.751791114803306, 0, 0, 1.00026744001229, -3.34886136001773E-06, 0, 0.830658956351997, 0, 0, 0.936508459009467, 0, 0, 0.0299902572436213, 0, 0, 1.80818151195879, 5.90522600452901E-07, 0, 0.219543242463629, 0, 0, 0.841233838275649, 0, 0, 0.980409999368903, 0, 0, -0.280552629046399, 0, 0, -0.452263866296161, 0, 0, 0.220394372577031, 0, 0, -0.506683523536978, 0, 0, 0.977043639857808, 0, 0, -0.413979969645841, 0, 0, -0.0587398256448749, 0, 0, 0.974539015430277, 0, 0, 0.874080557271094, 4.30531082195931E-06, 0, 0.125682984325986, -1.06254924399829E-08, 0, -0.105633924654483, 8.03720601225517E-07, 0, 0.805186512021596, 1.38846567447465E-06, 0, 1.07191665951582, 1.37332418537493E-06, 0, 1.56413594357418, 2.30221058829717E-07, 0, -0.210840012784155, 3.36137351735482E-06, 0, 0.508339433397624, 1.15537449914571E-06, 0, 0.32467458149014, 1.58338818814585E-06, 0, 0.433511011593991, 7.48406557011316E-07, 0, 0.652784982230248, 7.83067010503528E-07, 0, -0.569051236644877, 0, 0, 0.800094783916401, 3.2184353328006E-07, 0, -0.197727501018777, 0, 0, 1.30148692101583, -1.17475096303484E-07, 0, -0.133654627613014, 4.84687364556948E-08, 0, 1.14749195805927, -2.68580572525353E-07, 0, -0.116087863741484, 0, 0, -0.502791642307397, 0, 0, 0.500359406462107, 0, 0, 0.392609893722507, -2.19220107520004E-08, 0, 0.987320978697713, 1.44795772067488E-07, 0, 0.137667840876462, 0, 0, 0.502723826795222, 0, 0, 1.21817582234929, -2.31256576399274E-07, 0, -0.933815441994842, 0, 0, 0.959267244655298, 0, 0, 0.0981352939727416, 0, 0, 1.58507664559919, -1.03755920634555E-07, 0, -0.0506724887763488, 0, 0, -0.516177065445193, 0, 0, 0.18732896129942, 0, 0, 0.0185137824241601, 0, 0, -0.952225314430997, 0, 0, 0.0727324649098946, 0, 0, -0.568698046528128, 0, 0, -0.584344571262759, 0, 0, -0.248837332822772, 0, 0, -0.63895936293479, 0, 0, 0.908536145420995, 0, 0, 0.276165939328504, -7.59091808432943E-06, 0, -0.148257249649439, -2.59786356972881E-07, 0, -0.788222521048497, 0, 0, 0.0116882515434946, -7.05621926237784E-06, 0, -1.01054232715041, 0, 0, 0.446709446149444, -2.23766571491954E-07, 0, 0.0391529894459574, -9.88415057409419E-06, 0, 0.809656816007556, -3.17246150277965E-07, 0, -0.813355061677373, 0, 0, -0.710145752961297, -1.65373361995793E-06, 0, -0.546135312321134, 0, 0, 0.0931315035992915, 0, 0, 0.123493635961031, -4.88554342540959E-07, 0, 0.440900767893019, 0, 0, -0.504042977674738, -2.33993177471335E-06, 0, -1.13133868439181, 5.60889235190486E-06, 0, 1.49395231417938, -6.24169148562745E-06, 0, -0.954721451715902, 0, 0, 0.463239475848028, -2.64772469320465E-07, 0, 0.820983690126326, 0, 0, 1.34998159885721, 0, 0, 0.347066313842169, -1.63547679287175E-07, 0, -0.559040899183155, 0, 0, 0.84029230561121, 0, 0, -0.233225385122556, -4.77385567794595E-09, 0, 0.93040125627555, 0, 0, 0.412434980930963, 0, 0, -0.0700933044171396, 0, 0, 1.35826634426649, 0, 0, 0.817433889870268, 0, 0, -0.566286218150652, 0, 0, 0.246436184852587, 0, 0, -0.477128500806693, 0, 0, 0.332131852084832, 0, 0, -0.739382161637481, 0, 0, -0.592159853126928, 0, 0, 0.0382174798465416, 0, 0, -0.693293607650927, 0, 0, 0.400910801906563, 0, 0, -0.244860330244927, 0, 0, 0.306991085593537, 0, 0, 0.47436907126321, 8.82671398516855E-08, 0, 1.23141170219133, 9.52493586583562E-08, 0, 1.0641335041814, 0, 0, -0.608702160337334, 6.20151075066069E-06, 0, 0.777704124302296, 7.21964351307891E-07, 0, 1.08551207425651, 0, 0, 0.243493686601432, 8.40713745732033E-07, 0, -0.112497045062116, 3.97929647423901E-06, 0, -4.07503172739781, 5.29055369368478E-07, 0, -0.76276917998092, 9.1093176549061E-07, 0, -0.629623119546856, 0, 0, -1.28140009512034, 2.39849943904775E-07, 0, -0.459943053061116, 0, 0, 1.88426102854194, -3.90135436467945E-06, 0, -0.26132105253644, 3.22127487004798E-06, 0, -0.470411480447317, 1.38231179521379E-06, 0, -0.59992186520245, 0, 0, -0.439479688087089, 3.14967689385389E-06, 0, -0.828588231386891, 0, 0, 1.00517392409197, 2.14605353771357E-06, 0, -1.73949437720393, 5.16269437663264E-06, 0, -0.81236516209895, 0, 0, -0.518433599508569, 0, 0, 6.32595489726297, -2.00865139955316E-06, 0, 0.24928143958062, 0, 0, -0.429739995594015, 0, 0, -0.9867798192365, 0, 0, 0.0281526087703229, -1.09261692109898E-06, 0, -0.804365068582988, 0, 0, 0.492133374089437, 0, 0, 0.579597144191897, 0, 0, -0.355632253622465, 0, 0, 0.0489953118604587, 0, 0, -0.242472249661792, 0, 0, 0.740362923471426, 0, 0, -0.306352909331374, 0, 0, -0.720341305118213, 0, 0, 0.386682418820766, 0, 0, -0.29276560120879, 0, 0, -0.427259390576449, -4.24320879952423E-06, 0, 6.32546549195575, -1.22439230839128E-07, 0, 0.494285362875629, 1.44597699046044E-06, 0, 0.284211627666291, -1.52620924860699E-06, 0, 0.756751754538456, -3.71115537555323E-06, 0, -0.452346817004707, -2.329431337181E-06, 0, -0.851602676873528, -2.57447869542092E-07, 0, 1.46713083385351, -2.09399682295096E-06, 0, 0.659767280671121, -8.27112699577806E-06, 0, -0.641886603987255, 2.29427255153877E-06, 0, 1.33929173527573, -3.64499572359316E-06, 0, -0.361860654951008, 0, 0, 1.0579870551675, -6.27788503586383E-06, 0, 0.229499033293453, 0, 0, -0.0103632982403459, 2.72813095756098E-07, 0, 1.75138507998607, -4.47886728900055E-07, 0, 1.34430008907798, 3.66265146850573E-06, 0, -0.682431396880388, 0, 0, 0.0754688403357802, 1.74273379604818E-06, 0, 0.204328447209824, 0, 0, 0.236833968936636, 1.24931175352532E-06, 0, -10.2627901514628, 1.91247590117886E-06, 0, -0.602669914999357, 0, 0, 0.248664675861907, 0, 0, -11.0412986622659, 1.07986242259897E-06, 0, -0.0345987272609951, 0, 0, 0.726009134075609, 0, 0, 0.898032373701237, 0, 0, -4.46778002735239, 0, 0, -0.614282074204777, 0, 0, 0.0533123831512929, 0, 0, -0.757394005431511, 0, 0, 0.0133957159767839, 0, 0, -0.974198780010547, 0, 0, -0.917012559211353, 0, 0, -0.836971872410258, 0, 0, -0.412785165669762, 0, 0, 0.000476414803637359, 0, 0, 0.209130927552064, 0, 0, 0.87397447874489, 0, 0, 0.274726729475139, 0, 0, 15.8993001100436, -9.11068653407319E-07, 0, 1.01833971997053, -6.65624977583798E-07, 0, -0.246140653621351, 0, 0, -0.157147496956765, 0, 0, 0.386787058089465, 0, 0, -0.69711267404291, 5.97083113547944E-06, 0, 0.802315768989427, -5.38005199306222E-07, 0, -0.320847207999706, -4.0630930852296E-06, 0, 0.656261686420992, 7.41165999791937E-07, 0, 1.2733524445949, -2.06484006413362E-06, 0, -0.623921512450986, 0, 0, -0.657941828982379, 0, 0, -0.817646028389058, 0, 0, 3.37266813183303, -1.8120993761467E-06, 0, -0.465981169661143, 1.96074400930672E-06, 0, 0.755907140497513, 1.35792157256458E-06, 0, -0.763057587557965, 0, 0, -5.98245329210631, 4.05160429128984E-06, 0, -0.692965799799639, 0, 0, -0.120750228024152, -1.12527226658642E-06, 0, -0.306244739871111, 0, 0, -0.799714644346253, 0, 0, -0.179666922977039, 0, 0, 3.50616798104332, -5.35327982701554E-07, 0, 0.642969462854308, 0, 0, 0.624743629072208, 0, 0, 0.547869553578957, 0, 0, 5.05159437759001, 0, 0, -0.405738551824232, 0, 0, -0.5965808171763, 0, 0, -0.146018880021767, 0, 0, 0.108437675567548, 0, 0, -0.649985452950925, 0, 0, -0.745544493079905, 0, 0, -0.767014025602031, 0, 0, 0.0215875697422714, 0, 0, 0.730705520012745, 0, 0, -0.0613947981323091, 0, 0, -0.803745792155967, 0, 0, 1.16714125436422, 0, 0, -4.04667179515485, -2.97458882841778E-07, 0, 0.0726284691887773, 5.03503576202135E-06, 0, -2.11387041713662, 8.80859274236742E-06, 0, -0.9069812756049, 1.54051694292995E-05, 0, -0.175241644664541, 1.01845687483993E-05, 0, -0.884829967589246, 2.25477531769766E-05, 0, 1.38777364401879, 0, 0, -1.26779556496279, 1.21439073295636E-05, 0, 0.673959196213019, -6.34808182307939E-06, 0, -0.984417957812355, 7.64792652091436E-06, 0, -0.649727578111797, 0, 0, 0.236330233821004, 0, 0, -0.0979032726482969, 0, 0, 2.50551672121536, 0, 0, -0.590362591997033, 1.04139796345735E-05, 0, -0.465315443769005, 6.58708985739718E-06, 0, 0.986836100922355, 0, 0, 0.863654063856618, 0, 0, -0.332909988860092, 0, 0, 0.136780478132047, 7.92857986610408E-06, 0, -1.27260101572467, 1.18961448098585E-05, 0, -0.731642879420725, 0, 0, 0.697444287919181, 0, 0, -0.346479653642349, 1.79978973030956E-06, 0, 0.031924268711323, 0, 0, 0.267640811981466, 0, 0, 0.705655122038748, 0, 0, -5.17750102406512, 2.00269311482719E-06, 0, 0.653816997843709, 0, 0, 0.238080010394603, 0, 0, 0.706786361386434, 0, 0, 0.298337210574344, 0, 0, 0.940655978368901, 0, 0, 0.347559298084844, 0, 0, -0.973812653670932, 0, 0, -0.204950512016635, 0, 0, -0.81535010776266, 0, 0, -0.679479460082706, 0, 0, -0.216887914210971, 0, 0, 0.518989351512185, 3.42177603108164E-06, 0, -5.69694164084957, 5.86644211003511E-08, 0, 0.344856786286668, 4.73940589797439E-07, 0, -0.346328747380999, 7.73617845437437E-07, 0, 1.05456477658132, 6.49222034024538E-07, 0, -0.761013664468387, 4.38399897177601E-07, 0, 1.65606248087392, 9.26362598703711E-07, 0, -0.629851481636216, 4.28276764062517E-07, 0, -0.123675950236676, 1.53452296233022E-06, 0, 2.20294401058339, -3.44351282084387E-07, 0, 0.893163702614485, 1.35781398405892E-06, 0, 0.034751468819916, 0, 0, -0.385205505344915, 1.57513726631487E-06, 0, -0.728484809272217, 0, 0, 2.01975488554949, -8.95659035153379E-07, 0, -0.581578155116538, 5.02125522718768E-07, 0, -1.15033001971841, 1.35087896622361E-08, 0, 0.908882349687108, 0, 0, -0.467512395165812, 1.83838362511242E-07, 0, 0.467888268394344, 0, 0, 0.564632609239268, 0, 0, -0.269899128724065, 2.89174242699191E-07, 0, -0.0968567203250047, 0, 0, -0.514818750095935, 0, 0, 1.00861364578915, -3.08882790104852E-07, 0, 0.0187498848041285, 0, 0, 0.0519352113138583, 0, 0, -0.077089749778197, 0, 0, 0.864557104593179, 1.30357813177721E-07, 0, 0.510459365095226, 0, 0, 0.75344732671671, 0, 0, -0.797489795739525, 0, 0, 0.666315561005061, 0, 0, -0.576833502192438, 0, 0, 0.211056873766266, 0, 0, -0.564451484738128, 0, 0, 0.0491855112133479, 0, 0, -0.0548346112737593, 0, 0, 0.828719085933975, 0, 0, 0.310327789425071, 0, 0, 0.074188575506007, 5.81361205690458E-06, 0, -0.410276824150314, -3.33161861863113E-07, 0, -0.805884161480203, 2.80700312660239E-06, 0, -1.29536658243875, 1.11929497974164E-06, 0, 0.597111344626269, 4.41649575907315E-06, 0, -1.0075512337426, 5.13895571638478E-06, 0, 0.245638626898645, 5.53324743745342E-06, 0, 0.0901012217749267, 1.58708238766171E-06, 0, 0.0547271846429635, -4.91869277920291E-07, 0, -0.0800807858545795, 0, 0, 1.07166781948365, -6.29035388654644E-07, 0, -0.113832861703743, 0, 0, 0.610204760213433, 2.8949598104495E-06, 0, -0.147367728477049, 0, 0, 0.16263922685093, 1.2746928846657E-06, 0, 0.0380311358600885, 8.34653747117297E-07, 0, 1.47032215861817, 0, 0, -0.0763099440728826, 0, 0, -0.559461741978781, 1.54850119534021E-06, 0, -0.150024682818923, 0, 0, 0.696527840206129, -1.15255268577178E-06, 0, 0.155768414732564, -8.59173906267154E-07, 0, -0.348196481051015, 0, 0, 0.302908470529555, 0, 0, 1.6478276560878, -3.8909272689524E-07, 0, 0.643315673639679, 0, 0, 0.368435907814855, 0, 0, -0.898739561391407, 0, 0, 0.253503840537503, 1.23428177796894E-07, 0, -0.468544707386077, 0, 0, 0.452232573857639, 0, 0, 0.0976179116860116, 0, 0, -0.919836736246867, 0, 0, 0.341833123630766, 0, 0, -0.57362110892945, 0, 0, -0.651706780144808, 0, 0, 0.588993917027951, 0, 0, -0.318796492795831, 0, 0, -0.32280987003949, 0, 0, -0.618088691317518, 0, 0, 0.897528862407796, -2.79988670223122E-07, 0, 4.54350477186699, -3.22751907673282E-08, 0, 7.41056005794539, -2.75206330097706E-07, 0, 0.0352789371436833, 0, 0, 0.48284796236166, 0, 0, -0.163123172675255, 0, 0, -0.289186128086992, 0, 0, -0.165720067396568, 0, 0, -0.0147558648901169, 0, 0, -0.543123856208531, 0, 0, -0.458888988975456, 0, 0, -0.874504544713769, 0, 0, -0.841681393733425, 0, 0, -0.0212562312471011, 0, 0, -0.928118565623503, 3.66766829585234E-06, 0, 0.994997198500816, -2.46704523944167E-06, 0, -0.569511192840615, -2.75957925333966E-06, 0, 0.589378815884413, 0, 0, -0.658579126472708, -3.86141831840787E-06, 0, -0.835324553696124, 0, 0, -0.14411490389742, -1.38637550554892E-06, 0, 0.102091448704436, -1.45722835947768E-06, 0, 0.966363702885045, 0, 0, -0.557803122120818, 0, 0, 0.414901101498965, -8.55859066899503E-07, 0, -0.114213865769195, 0, 0, -0.193996125456875, 0, 0, -0.809344144449264, 0, 0, -0.543302479180592, -1.0692018185143E-06, 0, 0.0252257823130235, 0, 0, 0.385758016903772, 0, 0, 0.209355097827201, 0, 0, -0.753500074033393, 0, 0, -0.643959427086618, 0, 0, 0.0135848573472281, 0, 0, -0.0239016418456574, 0, 0, 0.118246561437029, 0, 0, 0.943407302695982, 0, 0, 0.775853151351145, 0, 0, 0.0852311770828587, 0, 0, -0.00393636100112547, -1.11914414113883E-05, 0, -4.24761664076197, -3.34785070443847E-07, 0, 0.0743821334074142, -6.55958004933458E-06, 0, 0.488494565671467, -3.35311376609017E-06, 0, 1.26304328423548, -1.57805259931269E-05, 0, 0.991078307115901, -6.50483345171678E-06, 0, 0.378489557514722, -1.21308624941457E-05, 0, 0.124188685438402, -4.80701711247486E-06, 0, -0.717528159602522, -4.81376447958419E-06, 0, -4.93899305307219, -1.8631598677083E-06, 0, 0.674441239330294, -3.19337482731285E-06, 0, 0.999615101143539, 0, 0, -4.39059415885807, -3.71454796821571E-06, 0, -0.487485316343366, 0, 0, 1.8209019964009, -5.05429887695223E-06, 0, -0.221939336089671, -3.18572792810123E-06, 0, -1.03459053844382, 2.63413381313546E-07, 0, 0.507061201849515, 0, 0, 0.978828765641279, -1.4184054001687E-06, 0, -0.358730815052395, 0, 0, -0.27438249757818, -2.22915105434004E-06, 0, 0.143706558072729, -2.08276530461589E-06, 0, -0.61257009097029, 0, 0, -0.975578286673677, 0, 0, 0.427398828287682, 3.05233295484189E-07, 0, 0.3356348124033, 0, 0, 0.878995529319623, 0, 0, 0.851172934216993, 0, 0, 6.08452238972492, -1.49171478168481E-06, 0, 0.333017881649089, 0, 0, -0.144241825278961, 0, 0, -0.533910957879345, 0, 0, 0.813525664533268, 0, 0, 0.184197229884657, 0, 0, 0.191380997743169, 0, 0, -0.719859984572912, 0, 0, -0.970513956607559, 0, 0, 0.142210325758071, 0, 0, -0.544268504504239, 0, 0, -0.932828479415192, 0, 0, 1.10512002856758, -2.7017838299307E-05, 0, 2.91588406896313, -1.64171882194371E-07, 0, -0.837718223771816, 0, 0, 1.54242174047549, -1.00559784446228E-05, 0, -0.226273585743881, -1.17040597301313E-06, 0, 0.219284626717324, -4.79127794088284E-06, 0, -0.0926817035170411, -1.89606073075548E-05, 0, 0.517323223580998, -4.8871815097992E-06, 0, -0.503680595027617, -7.62464190726196E-06, 0, -4.64518450670031, -6.10381831563959E-07, 0, 0.0270871684645018, -5.58044845446155E-06, 0, 0.611185359587514, 0, 0, -2.46622176358589, -8.10684094470564E-06, 0, 0.13458396640354, 0, 0, 1.00426053478161, -5.79679973691227E-06, 0, -1.48779670266174, -1.0051191077037E-06, 0, -0.648969855682551, -6.65871482934326E-06, 0, 0.0271912296429235, 0, 0, 1.08334475308861, -3.13170468793965E-06, 0, -0.349169430019879, 0, 0, 1.02617239499666, -2.49040652747392E-06, 0, 1.01953714191472, -4.91280171198239E-06, 0, 0.136260583594563, 0, 0, 0.699699002178246, 0, 0, 0.780323415205859, -6.10786084122578E-07, 0, 0.472707832917901, 0, 0, -0.813910563389729, 0, 0, 0.227577870351997, 0, 0, -0.728004225844321, 2.41922028042613E-06, 0, 0.266878659495562, 0, 0, -0.27419456992028, 0, 0, -0.0834608371758185, 0, 0, 0.0513297063537546, 0, 0, 0.247316056511978, 0, 0, -0.354112544727564, 0, 0, -0.643308065665564, 0, 0, 0.321426397804835, 0, 0, -0.586449316510208, 0, 0, -0.0620071939481456, 0, 0, 0.464404007170538, 0, 0, -0.512590784890404, 2.07056889094108E-05, 0, -0.836245479104699, 2.24965467127241E-07, 0, -0.0296127346509172, 5.98254054819695E-06, 0, 0.610009754019318, 4.38474472237233E-06, 0, -0.74578459904447, 1.62270897976839E-05, 0, 0.158498314271859, 1.08594774621622E-05, 0, 0.75592371307215, 1.5501037161893E-05, 0, -0.402303905319582, 6.14756277780494E-06, 0, -0.925832134182541, 1.65510019554358E-05, 0, -0.255744298097775, 2.76449848022296E-06, 0, -0.995054469611319, 9.86697268916709E-06, 0, 0.00229481374951779, 0, 0, 0.176709375839613, 1.9067238612998E-05, 0, 0.804900925515639, 0, 0, -0.458979494948194, 9.02452417031755E-08, 0, 3.44186049210767, 1.52119698159693E-06, 0, -0.361050734109204, 4.24676042072716E-06, 0, 0.458239969545156, 0, 0, 4.95290677455519, -2.2130764847151E-06, 0, 0.613721074356568, 0, 0, 0.27067894909243, 2.29021927887835E-06, 0, 1.24131842092248, -8.2774584927085E-07, 0, -0.587148443603492, 0, 0, 0.542143238495171, 0, 0, -0.190428339656126, 2.94657255488253E-06, 0, -0.999190293252091, 0, 0, -0.440144346766241, 0, 0, 0.381603669087218, 0, 0, -2.46205455810853, 2.47593944556736E-06, 0, -0.332737071128905, 0, 0, 0.172502681227635, 0, 0, 0.753772025813243, 0, 0, -0.910801576408931, 0, 0, -0.490797552974335, 0, 0, -0.887224244832631, 0, 0, 0.302731302242135, 0, 0, 0.997080434112381, 0, 0, 0.429395056063959, 0, 0, 0.284029990101247, 0, 0, -0.647956834942082, 0, 0, 0.142500573764743, 2.92809251256213E-06, 0, -0.775379242381131, 1.15637796609442E-07, 0, 6.80596406170399, 7.6809540364736E-09, 0, -1.62387134502636, -2.34106643039399E-07, 0, 0.332081128667709, 7.24438715885099E-07, 0, 1.0017496950015, 4.64552802830516E-06, 0, 0.844103291482092, -7.57704328418612E-07, 0, -0.246373446838453, -4.88903956811034E-07, 0, -0.905038577433166, 0, 0, -1.24005821480348, -2.53622204688539E-06, 0, -4.47787536375116, 6.4482786010261E-07, 0, 0.863186428259679, 0, 0, -2.65750361991649, 3.41463129910941E-06, 0, 0.324271731695287, 0, 0, 0.248212888747195, -1.67293577076227E-06, 0, -0.27756333293128, 3.63713785850541E-07, 0, 8.80195492464938, 5.89353734763723E-07, 0, 0.50000779773109, 0, 0, 2.01758218950408, -1.08324563695131E-06, 0, -0.58514069467091, 0, 0, 13.2362621710323, 0, 0, 0.504703559192027, -1.37914045096288E-06, 0, -0.809754813001377, 0, 0, 0.492979437808031, 0, 0, 1.11987879346849, -1.39005629665996E-07, 0, -0.640954719689188, 0, 0, -0.0869036098415514, 0, 0, -0.340598575463797, 0, 0, 1.05221469516345, -2.77648844855087E-07, 0, 0.316698629090888, 0, 0, -0.0409301747758548, 0, 0, 0.138928739884369, 0, 0, -0.825790020556091, 0, 0, -0.974779919709442, 0, 0, 0.978182557960126, 0, 0, 0.692905740669419, 0, 0, -0.497333376434321, 0, 0, 0.789169789193743, 0, 0, -0.611918114876336, 0, 0, 0.808977337465145, 0, 0, -0.649219276577226, 1.09688829424885E-05, 0, 0.683003551877521, 2.45738808009957E-07, 0, -0.206823822959831, 1.77730842240071E-07, 0, 0.414161557856372, 2.34621430919481E-06, 0, -0.0449265704286034, 2.71930622411647E-06, 0, -3.35757289172547, 7.00205870516784E-06, 0, 1.44636717465523, 2.42774039067067E-06, 0, 0.493809278879085, 1.40064962991063E-06, 0, -0.0262654940116072, 3.48387085719009E-06, 0, 2.63302336999503, -2.28540438102067E-06, 0, 1.2994551586123, 2.25287458844338E-06, 0, -0.502927363618709, 0, 0, 0.983900069312005, 5.80796892409804E-06, 0, -0.130829315227843, 0, 0, 1.2475696833575, -3.99480525665338E-07, 0, -0.394496613709069, 3.11327701741676E-06, 0, -0.404948091448192, 2.84348090472168E-06, 0, 0.574356065864841, 0, 0, -5.54445601104549, 1.11352480237928E-06, 0, -0.204983926939305, 0, 0, -1.6061495919069, 1.60624863208865E-06, 0, -0.181496141413838, 1.73625174356164E-06, 0, 0.554303610489845, 0, 0, 0.311187496088067, 0, 0, 0.0367836294852536, -8.32312159149765E-07, 0, -0.350560601498261, 0, 0, 0.688976448815771, 0, 0, -0.988932642149242, 0, 0, 5.61233267587243, -1.61945718048549E-06, 0, -0.428555212648844, 0, 0, -0.534613935991476, 0, 0, 0.942988941419399, 0, 0, 0.111925912607427, 0, 0, -0.634599763729889, 0, 0, -0.838015110156506, 0, 0, 0.371290289504123, 0, 0, 0.701848103525978, 0, 0, 0.391285871803428, 0, 0, -0.385915352676956, 0, 0, -0.784367015484891, 0, 0, -0.468186115539105, -1.71682498211992E-05, 0, -17.1636849596294, 2.28058760062039E-07, 0, -0.987964504591474, -5.66571040643415E-06, 0, -1.2023601361033, -2.70320523676155E-06, 0, 0.928172865189747, -1.59579140262705E-05, 0, -0.474553592149516, -1.0014749360119E-05, 0, 0.721767004098114, -1.83549699142424E-05, 0, 0.64153837896553, -8.11103870607479E-06, 0, -0.570176195082874, -1.00936457238622E-05, 0, -0.552717245792786, -2.56834711493463E-06, 0, -0.376921928597326, -3.90037970554223E-06, 0, -0.0716894422991617, 0, 0, 0.437731365442337, -7.03090744838721E-06, 0, 0.593065812062968, 0, 0, -0.225086397455355, 8.58719000591394E-07, 0, 0.232910265195405, -4.09474053779432E-06, 0, 1.31602138018296, -4.75115539045824E-06, 0, 0.442530047820197, 0, 0, -0.908101362636307, 6.71525506385039E-08, 0, -0.770544608016752, 0, 0, 0.801304973672977, -3.93742243185059E-06, 0, 0.806985195788867, -2.35489529692E-06, 0, 0.418837518160621, 0, 0, 0.673407131653934, 0, 0, 1.79779697167998, -6.57566712074099E-07, 0, 0.627583630209595, 0, 0, 0.385146723773864, 0, 0, -0.110382753941409, 0, 0, 3.77347984205158, -4.64204330570909E-07, 0, -0.703964286345972, 0, 0, 0.478124765436223, 0, 0, 0.925616679678493, 0, 0, -0.0397285814582038, 0, 0, -0.116900454795407, 0, 0, -0.84654461957819, 0, 0, -0.337755472090913, 0, 0, -0.326015638805002, 0, 0, 0.00690150773474096, 0, 0, 0.565061438626173, 0, 0, -0.73132981813109, 0, 0, -0.46270097117164, 5.14593893534753E-07, 0, -0.900862959457415, 0, 0, 0.368373167116917, 0, 0, -0.666418213579468, 0, 0, -0.821936356103109, -9.54084705486634E-06, 0, 0.519697552040919, -1.40605874189451E-05, 0, -0.0461798454570851, 5.22083837886304E-06, 0, 0.501482146277691, -8.50287531589534E-06, 0, -5.49668643420219, 8.53513019292961E-07, 0, -1.21137823668679, 5.67300198784261E-07, 0, 0.634841886394835, -1.457309028491E-05, 0, -0.718007085497709, -1.49231624162841E-05, 0, 0.494688481181183, -8.43815186133995E-06, 0, -0.592695885863694, -1.56095819466498E-05, 0, -0.422084773903843, -1.44708103189817E-05, 0, -0.496536674601735, 0, 0, -0.247992961101445, -1.54108019782579E-05, 0, 2.87123147375983, -1.73902798040932E-05, 0, 0.850687144903695, -1.39081062265941E-05, 0, 0.106901274476578, -1.68414239428592E-05, 0, 0.0995253238654995, -1.96120814422964E-05, 0, -0.233935100620636, 4.97755538031927E-07, 0, -0.419524454523679, -9.66062602075591E-06, 0, -3.65117172717235, 0, 0, 0.165063321019577, -7.9306683742444E-06, 0, -0.566991444757761, -1.21916077453907E-05, 0, 0.854937965149456, -8.85969982606581E-06, 0, -1.90569237638128, 0, 0, 0.418221281541317, -1.34303836559586E-05, 0, -0.681059370882462, -9.53718123330001E-06, 0, -0.52702176670228, -1.56550123309529E-05, 0, -0.66446506400549, 3.69497648568034E-06, 0, 0.860090654927257, -1.12166247728754E-05, 0, 0.541081303930464, -7.20978778865293E-06, 0, 0.387760532365209, -4.82164845758041E-06, 0, -0.0221378086758911, -2.33575428642887E-06, 0, -1.20529650958124, -3.83848206977585E-06, 0, -0.387582425260671, -5.81599622813238E-06, 0, 0.325919042670247, -6.05200485536209E-06, 0, -0.00978499354307296, -7.9053800377071E-06, 0, -0.883508510419819, -5.54628259619049E-06, 0, -0.777270663403223, -1.60028813138282E-06, 0, -1.66461097599313, 1.4701221405329E-07, 0, 0.451000995160597, -4.99109124283351E-06, 0, -0.67810629316714, -2.98523172075994E-06, 0, -0.274257716979392, 1.64202726833732E-07, 0, -0.655917706325561, -8.00286794878666E-07, 0, -0.57640432761803, -5.49144275268228E-06, 0, -2.56679282323205, 0, 0, -0.0842925499763159, -4.86461408832631E-06, 0, 0.569614003792751, -2.34522826962047E-06, 0, 0.674301528633763, -5.9606624575036E-06, 0, -0.0132100822557508, -1.1211056912268E-06, 0, 0.250408511657492, -2.86305711098542E-06, 0, -1.99557138027508, 1.11732739433874E-07, 0, 0.56810578894791, 2.06995566711382E-07, 0, 2.7812133787114, -4.02287248652893E-07, 0, 0.332774458555916, -5.90899741035742E-06, 0, -0.0307458975085228, -3.85999331769647E-06, 0, 0.410724532147508, -2.85124729890813E-06, 0, -4.20750663465472, 2.32056703327123E-06, 0, 0.198021618278471, 5.32773957843512E-07, 0, -1.07279682191673, -5.75536105866147E-06, 0, -0.121527949227615, -8.12543177545027E-06, 0, -1.05627868847504, 5.95232040314188E-07, 0, -0.292101217392763, -2.29534544104631E-06, 0, -1.80405837971632, 1.10328515223661E-06, 0, 0.27106328499818, 7.06881511797745E-07, 0, -0.331606875404676, 3.11910673122416E-07, 0, 0.0380557862662848, 1.04027898767496E-06, 0, -0.438935230373573, 1.27072162962222E-06, 0, 0.537539402590186, 1.50576371348058E-06, 0, -0.0155704457087735, 3.52065088915891E-07, 0, -0.755401729069431, 1.03333283115461E-06, 0, 1.06993074038153, -1.17814168653205E-06, 0, 5.32992732015883, -8.17284238852611E-07, 0, 0.203178670292163, 1.05942906967436E-06, 0, -1.29759578032965, 7.51259669137924E-07, 0, -0.807918148805404, 5.049326359733E-07, 0, -1.50804968780428, 1.12390280343191E-06, 0, 0.526929013062037, 1.5641586406378E-06, 0, -0.0681047262396158, 2.38012556842063E-07, 0, 0.248700032483326, 1.04153951273767E-06, 0, -2.87796456524523, 1.09823489490792E-06, 0, -0.917428508511211, 1.51245252516416E-06, 0, -0.807807544012061, 1.13797835721517E-06, 0, 0.361076465899482, 1.09040578562829E-06, 0, -1.01371009690748, -1.45907558183342E-07, 0, -1.00152585582094, 9.79333040222447E-07, 0, 0.440384241880884, 2.35256011435216E-07, 0, 0.129484251518761, 1.28558799068292E-06, 0, -2.63733404741946, 1.60836933439127E-06, 0, 0.390854592540556, 9.87551165090098E-07, 0, 1.82145968465584, -5.43683680135356E-08, 0, 0.892376857528321, 5.10898783189298E-07, 0, -0.341013336356125, 1.23877717644043E-06, 0, 0.466202210237633, 1.47808331626603E-06, 0, -1.4342035375861, 3.55031398996936E-07, 0, -0.163068443933596, 1.5024079969187E-06, 0, -0.087724997241688, 1.38267049062871E-05, 0, -0.495298873791104, 7.28143263465999E-06, 0, -0.253005549356769, 6.6193099043423E-06, 0, 0.322684021889591, 9.02672944605443E-06, 0, -0.403340302522878, 1.39214751859599E-05, 0, -0.995843733120596, 1.51535042864704E-05, 0, -1.41778793792863, 1.21353958348828E-05, 0, -0.66259099007887, 1.10958721161492E-05, 0, -1.49861560319935, 1.9576448766287E-06, 0, 0.407216249470502, 2.50250444350675E-06, 0, 0.667466739820145, 6.46729729328982E-06, 0, -1.032535897976, 1.3833394531633E-05, 0, 0.721562059059293, 3.84951486050814E-07, 0, -1.11893089719249, 6.53452278558681E-06, 0, -0.205739789665515, 1.24181003028896E-05, 0, 0.404965192447129, 5.64199419714573E-06, 0, -1.00873672200017, 1.26468538668213E-05, 0, 1.74947306880492, 2.20071279223441E-06, 0, 0.525695017856444, 1.57273860251236E-05, 0, -0.434780897169005, 6.43581645858417E-06, 0, 1.9298439098938, 5.47731585129343E-06, 0, -0.245766211236524, 5.17850028705931E-06, 0, 0.806746503122428, 1.95313814697245E-06, 0, -0.202906868070773, -2.71170780419091E-06, 0, -0.104247254295349, 1.39107760452949E-05, 0, 0.576315397737735, 1.03129825677789E-05, 0, -0.912285655157733, 1.37013472772324E-05, 0, -1.04092399890193, 1.07828640774235E-05, 0, 1.62401669649435, 2.75822543731418E-06, 0, -0.179677665244597, 1.51270684769645E-05, 0, -0.518563638610056, 1.10771186666957E-05, 0, -0.0687992515435361, 3.23332356477538E-06, 0, -0.353003826084043, 1.32962783245931E-05, 0, -0.441097074629463, 4.72800631493769E-06, 0, 0.378885223561934, -6.87615701246572E-06, 0, 0.072013418989798, 0, 0, -0.38683906694353, -4.27091286501984E-06, 0, 0.568282891024716, 0, 0, -0.564736721500152, -1.06655866387542E-05, 0, 0.685766800554819, 4.89619525982606E-06, 0, -0.713502617322776, 0, 0, 2.38549892847425, 0, 0, -0.846469159102033, -7.46728491789109E-08, 0, -1.39921475476843, 7.50852464036765E-06, 0, -0.635959558482798, 1.60596190480984E-05, 0, -1.6475381907026, 3.6643955476901E-06, 0, -0.709958342232326, 1.04021208312983E-05, 0, -0.94370373957723, 0, 0, -0.76789060888166, 3.91360269955721E-06, 0, 0.1287239346243, 0, 0, -0.0427931484614451, 4.69007769783626E-06, 0, -0.188172169282577, 0, 0, 0.736778267837096, 0, 0, 0.567369602564689, -4.30082743639691E-06, 0, -0.593460957864509, 1.84658821178383E-05, 0, -0.333111503304161, -1.84678393407447E-06, 0, -0.411722256382538, -2.16607505496466E-06, 0, -0.952108091915313, 0, 0, -0.7458779308052, 4.32437837878883E-06, 0, -0.686550878967797, 0, 0, -0.382348931605846, 2.84201820421246E-06, 0, 0.56154785578796, -6.14818670895984E-07, 0, 0.228923763267533, -2.4392469834584E-06, 0, 0.0979408916250616, -6.35061112230684E-06, 0, 1.38696590914458, 0, 0, -0.611444938586086, 0, 0, -0.0968580845047601, -9.10343198138661E-06, 0, -0.164496133533031, -4.02256624993764E-06, 0, -0.758067037589747, -1.41504675886548E-06, 0, 0.52065948194198, -3.55224023888451E-06, 0, -0.171640736632487, -8.30961291370549E-06, 0, -1.09794586147225, 1.1430959236702E-05, 0, 0.0727195128930224, -1.00702202976741E-05, 0, 0.710717454304122, -9.38362599006206E-06, 0, 1.15776712989723, -1.32577449933923E-05, 0, -3.1254661971179, 2.36597745599328E-06, 0, -3.14118370819052, 2.42723312398877E-06, 0, 0.00629676452829289, -1.15324627229856E-05, 0, -1.20404047867322, 5.97179143131463E-07, 0, 0.618373981431077, -1.34490452364321E-05, 0, -0.0613018649700182, -3.83606057487233E-06, 0, -1.16441105656411, -1.68698880372476E-06, 0, 0.481901530798255, -1.26996140221536E-05, 0, 0.394228383580655, -5.23966947921429E-06, 0, 0.455573834189341, -9.23503895779759E-06, 0, 0.509138237420394, -5.81945140007518E-06, 0, 0.0917936852029983, -1.09625220292693E-06, 0, 0.396459289948562, -1.5195279394558E-05, 0, -0.866839500118112, -5.50815178772141E-06, 0, -0.323716118652847, -1.52746553118093E-06, 0, -0.922155362553641, -9.38302813740305E-06, 0, -0.695586197903793, -6.674034515344E-06, 0, -0.883176180983334, -1.58547751631932E-06, 0, -1.61711988187352, 2.71708971489965E-06, 0, 0.426909350564348, 2.75765001308338E-06, 0, -0.902373627953193, 1.262631549084E-06, 0, -0.655189922695126, 2.23142793407024E-06, 0, 1.35492022406206, -1.2393662598108E-05, 0, 0.388985879029657, -1.29761711494246E-06, 0, -1.4977055596413, 0, 0, -0.15213595811387, -1.0789506296669E-05, 0, 0.00265784892284401, 0, 0, 0.312567453327154, -8.77768561140041E-06, 0, -0.622325635523454, -1.29266812454166E-05, 0, -0.569936412370501, -1.50248260595395E-05, 0, -0.609119578245935, 0, 0, 0.310484865078687, -8.96254986235342E-06, 0, -2.41168834460343, 3.95929170136232E-06, 0, 0.871099291947004, 3.09269957253307E-06, 0, 0.672239322128644, -1.16108850533968E-05, 0, -0.82742729803079, -9.51608589922969E-06, 0, 0.214174429648467, 0, 0, 0.580616432434739, -9.21104608702067E-06, 0, -0.702144812265906, -1.30617239400414E-05, 0, -5.27177942464327, 3.26400313911498E-07, 0, 0.819939537178312, -1.56740988142211E-05, 0, -1.17138101039553, -8.09921803194206E-06, 0, 0.167974105464515, -1.43631953402292E-05, 0, 0.986146477110579, -1.24447204854432E-05, 0, -0.161612147562762, -1.14811916019471E-05, 0, -2.12410319768175, 3.12631803689534E-06, 0, -1.19849530206839, 0, 0, -0.520201045855128, 0, 0, 0.405778831341434, -1.21399231953685E-05, 0, 0.125348466691948, -1.03403979478356E-05, 0, -0.516059894195864, 0, 0, 0.0179962981702499, -8.37851260510036E-06, 0, 2.62431874643673, -1.34485458217622E-05, 0, 0.864143714938577, -1.62904170598006E-05, 0, 0.551926400119637, -1.48779674571784E-05, 0, -1.873916499054, 5.59162242626749E-07, 0, -0.555189905755533, -1.14428117906095E-05, 0, 0.354378828210512, 0, 0, -1.0154013302304, 0, 0, 0.732576122115214, 0, 0, -1.22612916785302, 7.32222038431743E-06, 0, -0.447933050814474, 0, 0, 0.0141568977568548, 0, 0, -0.0282171789025261, -1.09296003686982E-06, 0, -0.21743394177178, -9.54612625328251E-07, 0, -1.78656035322679, 0, 0, -0.150721263005458, 1.69103807703476E-06, 0, 0.531174525745924, -3.63789095505168E-07, 0, 0.227001441628371, -3.91980663567205E-06, 0, -0.701363306535472, 3.69412415776212E-06, 0, -0.3008586049818, -2.13759182150961E-06, 0, -0.299778743588683, 0, 0, -0.575159749568485, 7.72460778741736E-06, 0, 0.67749441083501, -1.57688829019168E-06, 0, -1.2661205992858, 0, 0, -0.721178393017539, 0, 0, 0.28767532297877, -3.54000452893816E-06, 0, -0.784913400553991, 6.80003923810762E-06, 0, -0.517520872218466, 6.83728804924516E-06, 0, -0.288260730402171, 1.62729925556931E-05, 0, -0.407076938132276, 0, 0, -0.453322450030116, -6.87548087715229E-07, 0, 0.890765112188234, -2.83842329172873E-07, 0, -0.0650882273339271, 0, 0, -17.1289591678385, 1.60507418875508E-06, 0, 0.139604535224008, 5.40084423965548E-07, 0, 0.741368837311658, -5.91381669932427E-06, 0, 0.935376388336405, -4.85526678444837E-06, 0, 0.328249230382061, 1.02233843368093E-05, 0, 0.847124925475671, 0, 0, -0.764423647627807, 5.8468249997398E-06, 0, -1.16893935406678, 3.81455325298363E-06, 0, 0.631195206325287, -1.74310652817312E-07, 0, -0.359906328386028, 2.56063131666914E-06, 0, 0.380861558215254, 7.78605667962025E-06, 0, -0.285947058366876, 1.14716502859997E-05, 0, -0.151616814599102, 6.05045990464191E-06, 0, -0.81132383214921, 5.99157717050509E-06, 0, -0.472996544873153, 1.66402233165445E-06, 0, -0.380253381771649, 5.50474780637852E-08, 0, 0.117702527224888, 8.44378141757198E-07, 0, -0.668683271694951, 6.74383949656164E-06, 0, 1.03099906994347, 7.01802764253652E-07, 0, -0.0312594594401596, 2.35216978167762E-06, 0, -0.590809259904366, 5.57594017344695E-06, 0, 0.476347567368243, 6.86388201196923E-06, 0, -1.06541205578848, 1.41000775453455E-05, 0, 0.441570496114149, 7.55403073763528E-06, 0, 0.453401773919368, 9.34903142437569E-06, 0, 0.0709268154205312, 8.14774941269175E-06, 0, -1.46566305895712, 5.04462003808691E-06, 0, 2.25407162592101, -1.38948209316138E-05, 0, -0.791806710599454, 6.25622777139899E-06, 0, 0.0454834938390101, -2.22061714414569E-07, 0, 0.568540855115827, 6.17002570736204E-06, 0, 0.124638436891731, 7.42902051434598E-06, 0, -1.7704376266627, 4.14129936169851E-06, 0, -1.22567112545263, 9.99351799868016E-07, 0, -2.38248025623357, 3.28349750066388E-06, 0, -0.479156981329331, 1.11380699334975E-05, 0, -1.21278391171405, 1.13367887597979E-05, 0, 1.08291099213935, 8.15681904990307E-07, 0, 0.359996379636868, 8.93201695412702E-06, 0, 0.0644771787960557, 0, 0, -1.18940054636661, 0, 0, -0.813822768940703, 8.74927774649605E-08, 0, -0.13437389544655, 0, 0, 0.679165715176617, 0, 0, -0.953279784884506, 0, 0, -0.263347209771093, 2.30707941081878E-07, 0, -0.0580984195296266, 1.33699130811231E-09, 0, -2.26719739065463, 6.04014630104374E-07, 0, 0.547502072179719, 5.71431663272616E-08, 0, 0.493335714425936, -4.75500997089156E-07, 0, 0.270561398572943, 0, 0, 5.59561672579842, -5.6907677680474E-07, 0, -0.222630247510527, 1.94835942331543E-07, 0, -0.540321208348254, 0, 0, -0.848469882600423, 6.4011317809391E-08, 0, -0.820974110568002, 0, 0, 1.17355411935952, -3.64292369197371E-07, 0, -1.16467277343377, 0, 0, -0.614472530673334, -4.31151374022762E-07, 0, -1.05398079388472, 3.28429628879635E-08, 0, 1.84450276388272, 0, 0, -0.496248466126931, 4.00762622900285E-07, 0, 3.00678603325169, -5.41532849559184E-07, 0, -2.67417880968473, 4.14600778269078E-07, 0, -0.277127070972827, 0, 0, -1.72273835189632, 8.90186964139836E-08, 0, -0.784434690095457, 3.03524360432362E-08, 0, 0.0109278781771121, 0, 0, 0.371593842063669, -7.51691169048137E-07, 0, 0.500075142377714, -1.17415370015413E-06, 0, -0.569201283943238, 8.75572678946513E-07, 0, 0.531906784649319, 0, 0, 0.0848240321538306, 7.78782920513842E-06, 0, -0.760188453419547, 1.39443044828651E-05, 0, 0.115864137129964, 4.37137404434296E-06, 0, -0.772907567787274, 9.80927545537684E-06, 0, -0.0473031681610038, 6.77725171132374E-06, 0, -0.422098916460535, -4.72638099838821E-06, 0, 1.22265094879317, 5.53505530613181E-06, 0, -0.0444097212150025, 6.87199251625468E-06, 0, -0.712976805316021, -4.15268974739687E-06, 0, 0.220162420396109, -3.43939208393315E-06, 0, 0.871414324848851, 1.43611501117527E-05, 0, 1.09725682077449, -1.92029016435994E-06, 0, 0.167638243552572, 2.09921428480087E-06, 0, -0.501601740676737, 1.5280739492766E-05, 0, -0.680378481348088, 1.53053500493674E-05, 0, -0.526989592828729, -2.83452449802741E-06, 0, -0.837360934345504, 8.51944574348358E-06, 0, -5.03335895208687, 5.97878052710187E-06, 0, 0.473625454176841, 1.05170020330861E-05, 0, -1.06710049949927, 8.22257961614065E-06, 0, 0.107897633073549, 1.12910792046195E-05, 0, 0.245027981938533, 1.84486065891798E-05, 0, -2.1618213105055, 2.21533391939747E-05, 0, -1.41536836489879, 5.32333277508252E-06, 0, 0.0177567386723636, 7.4168126834035E-06, 0, -0.441544470746923, 8.54551514358409E-06, 0, 0.0718982154506575, 8.7440682100317E-06, 0, -1.03697659987923, -1.62432127690227E-06, 0, -0.624193964394926, 3.82223942628534E-06, 0, 1.00620452244337, -6.06705839205727E-06, 0, 0.124825706937945, 1.54923937144794E-05, 0, 0.684561165636412, 7.82739909075909E-06, 0, 0.173682947483969, -3.88651396259898E-06, 0, 0.495920924598347, 0, 0, -0.871425961104008, 4.02389872271496E-08, 0, -0.160311917575509, 0, 0, 0.517876063471878, 0, 0, -0.977507681212127, 0, 0, 0.788893794327177, -1.0961746401717E-05, 0, -0.193939054080657, 0, 0, -0.575337798329049, 0, 0, -2.20333838530748, 0, 0, -0.890688029773722, 0, 0, -2.28726905708534, 1.39739397560509E-06, 0, -0.247505281235525, 0, 0, -0.244471927824119, 0, 0, -0.508541185517517, 0, 0, -0.848342208192312, 0, 0, 0.889556390897813, -1.00877327829515E-05, 0, -0.791424031613985, 0, 0, 1.15113324541672, -8.16585147401786E-06, 0, 0.144351982041957, 0, 0, -0.906993159120834, 0, 0, -0.904882007851025, 0, 0, -0.729248101164432, 5.04597106965699E-06, 0, 0.436884163540253, -1.20891638869815E-05, 0, -1.12645790973284, 7.09717673025963E-07, 0, 1.01399098359634, 0, 0, 0.613670856734861, 0, 0, -2.69907046724893, 0, 0, -0.701411896640694, -3.1116547184923E-07, 0, -1.2393134551854, 0, 0, -0.943456866823284, 0, 0, -0.713158997644679, 0, 0, 1.34821475921136, -1.06445928754278E-05, 0, 1.12520894313286, -1.02633361170518E-05, 0, 1.06969355761669, -1.42167390307825E-05, 0, -1.16506144316594, 0, 0, -0.706799903465109, -6.99131869200398E-06, 0, 0.527052355061542, -7.47497898517105E-06, 0, -0.0676505834723574, -1.19572148190864E-05, 0, 0.363038535216143, -1.54671735106179E-05, 0, -0.596948673502255, 0, 0, 0.0335300938769403, -1.15548834970198E-05, 0, -5.30408919113918, 0, 0, 0.16417442679614, 0, 0, 0.61677311160513, -1.3405760380909E-05, 0, -0.145795589873916, 0, 0, -0.585355394043892, -4.06240030593616E-06, 0, 1.3160416584458, -1.40196614064152E-05, 0, 1.31056228540543, -1.47634761033444E-05, 0, -0.654635655449945, -5.6106656853168E-06, 0, -0.94192593688181, -7.57359946949191E-06, 0, -1.34069562538967, -4.80884597026385E-06, 0, -0.441792337297783, -1.54871623436123E-05, 0, -1.34242224879874, 0, 0, 0.745856540294513, -1.30272736359718E-05, 0, -1.19920827466943, 0, 0, -0.143751026851718, -1.52710467352104E-05, 0, -6.28691091897055, 1.15974792103853E-07, 0, -0.43172860618151, -1.55173878660378E-05, 0, 0.884249729647931, -1.41704189209183E-05, 0, -0.0995135353023231, -1.58797216474065E-05, 0, -4.45717139696423, 0, 0, -5.71798421438729, 0, 0, -0.709640518468721, 0, 0, 0.681135526375957, -1.56037067603328E-05, 0, 0.3386249203585, -1.38898838043125E-05, 0, 0.116343989222985, -1.45779072451121E-05, 0, 0.335557369857506, -8.7685107387398E-06, 0, 0.283890158093681, -1.22230812685691E-05, 0, -0.581853363232998, -1.95525735789004E-06, 0, 0.895567015694387, -8.01141454615306E-06, 0, -0.810094769957386, -6.86861992178509E-06, 0, 0.915007364894867, -9.06971019293734E-06, 0, -0.505438590634155, -1.01824529215128E-05, 0, -0.523825452442997, -6.99155800910132E-06, 0, 0.824924136743166, -9.14472817232184E-06, 0, -0.00732783128083842, -1.11829294850212E-06, 0, -0.125042645241151, -1.06241283771534E-05, 0, 0.595564727222624, -1.04684410971241E-05, 0, 0.778075069743048, 0, 0, 0.480151324289124, -5.84908890020382E-06, 0, 0.598213320409181, -8.24504558793141E-06, 0, -7.23237573162996, 3.07468225218447E-06, 0, -0.233435227788124, -6.48458613634529E-06, 0, -0.520619205759099, 0, 0, -0.957062539626274, -8.91176828583488E-06, 0, -0.895513027622517, -3.05715826232674E-06, 0, -1.00554089528008, -1.1490577363159E-06, 0, -1.0259142118967, -5.91629787873941E-08, 0, -0.486123500104447, 4.99305710533527E-06, 0, -4.56866413339815, -6.30901850952601E-07, 0, 0.21988489907988, -8.98057848677555E-06, 0, 0.363186299502604, -5.3689753476782E-06, 0, 0.369743093166849, -8.78752962459097E-06, 0, -1.3711738588294, -1.28370428754414E-06, 0, -0.163522824811578, -3.29495061018433E-06, 0, 0.445468073010395, -1.42029283916781E-05, 0, -0.169545666861003, -1.0329349511751E-05, 0, -0.501994623426603, 0, 0, 2.54300830879805, -7.0023662710788E-06, 0, -0.998732663444337, -4.03341618023638E-06, 0, 0.562171863302415, 0, 0, -0.136382630809002, -5.81782584577198E-06, 0, 0.388649298639085, 0, 0, -0.294562468207094, 0, 0, -0.943839445569732, 0, 0, -1.60502006923524, 9.59908633926948E-07, 0, 0.670414536831539, 0, 0, -1.5735897263118, 2.55370302859092E-06, 0, -0.872303564090632, 1.48878449802703E-06, 0, 1.31269947855026, -9.83505822348007E-06, 0, -1.64851777958298, 5.24226596176689E-06, 0, 1.13386056726704, -5.81409391412652E-06, 0, -0.602219434454753, -5.59729401162663E-06, 0, -0.965229329029552, -6.18139393156332E-06, 0, -1.2105090677057, 5.36558382303892E-07, 0, 0.320044302397169, 2.1380304848697E-06, 0, -0.512899207057177, 1.33659300853169E-06, 0, 0.621151435126833, 0, 0, 0.215466579171327, 0, 0, 0.283843788099149, 0, 0, -0.357404338289357, -6.82911089659197E-06, 0, -0.188209121853755, -5.91081594946501E-06, 0, -0.453653731775259, -9.31270850580423E-06, 0, 0.248835129083201, 0, 0, -0.238280675204215, -5.72256112877697E-06, 0, 0.300019215751499, -8.5899751652994E-06, 0, -0.211519711197767, 3.2750753595835E-06, 0, 0.594087638230568, 1.363400799359E-06, 0, 0.0892327419749337, 1.21255151961292E-06, 0, -0.814928682320506, 0, 0, -0.700540466958573, 0, 0, 1.0341973406358, 0, 0, 0.17909611059606, 5.23821237357048E-06, 0, 0.501808129102155, 5.00474712604841E-06, 0, 1.33559657466669, -2.64981308647943E-06, 0, -0.348384566750312, 8.1716039261671E-07, 0, -0.501513114467365, 0, 0, -1.36675263956252, 3.89870093548215E-06, 0, -0.145716046433511, 1.07133647794399E-05, 0, 0.636480242705374, 3.17783677204796E-06, 0, -0.294495701918939, 0, 0, -0.279821284303399, 1.49096526848784E-06, 0, 0.601266422550596, -1.50312348943897E-05, 0, -0.0496202915263999, 1.36852447372334E-06, 0, -0.479303709462415, -2.19285604120524E-06, 0, 0.752135352704721, -4.08916503647689E-06, 0, -0.218780591339246, -8.04328652193153E-07, 0, -0.306444634386842, 6.97481030176891E-06, 0, 1.14637662891093, 0, 0, 0.372418665939841, 2.72926343936855E-06, 0, -0.416979260872312, 2.17362761733499E-06, 0, -0.0918534498389472, 2.13126215362906E-06, 0, 0.853666565352863, -3.37365116183854E-06, 0, 0.306918673865893, -8.18802227988739E-06, 0, -0.0571823350567005, 5.45915972978315E-06, 0, -0.452564398420054, 4.18296464809345E-06, 0, -0.557548560066692, 5.32628616370584E-06, 0, -1.24552734851231, 4.80698178367229E-06, 0, -0.44464938219577, -5.1887884557141E-06, 0, -0.0897497791547263, 2.49634890230176E-06, 0, -0.0687176013017789, 2.67529113785768E-06, 0, -1.02354634184399, 5.78793981576447E-06, 0, -1.07549785192323, -5.64338120776145E-06, 0, -0.966318791625622, 9.53880399790812E-06, 0, 0.604372922230007, 1.40717822997904E-06, 0, -5.75962244373136, 3.8081545083824E-07, 0, 0.298650998245429, 0, 0, -0.778598387387005, 0, 0, -0.899194129563216, 0, 0, -0.930666088893112, 0, 0, -0.218571992811695, -2.36994683519693E-06, 0, -0.674077886938143, -1.49655096631527E-06, 0, -0.628558863408265, 0, 0, -4.66503580149177, 0, 0, -0.0943877213778272, -2.15513185667478E-07, 0, -0.782006890443422, 2.2677412486651E-06, 0, -0.139668762535299, 4.21056962382648E-07, 0, -0.268279890845092, 1.98257901097799E-07, 0, -0.343447528879643, 0, 0, 0.267701673709315, 0, 0, -0.166366715468426, -3.2759454475499E-06, 0, 1.37704397636628, -2.854379421993E-06, 0, 2.39477325879143, -2.28811765921325E-06, 0, 0.629432429912425, 0, 0, 1.6577560930586, -1.99534003532095E-06, 0, -0.260057852495582, -2.17757595455944E-06, 0, -0.952842484436358, 4.80814965907445E-07, 0, 0.77660052912988, -4.37156184422872E-06, 0, -3.49731560197004, 7.95117121386284E-07, 0, 0.0556828573002803, -2.54077728390242E-06, 0, -0.346924407618543, 0, 0, -0.335393217881582, 0, 0, 1.46302487967942, -6.80284462503003E-06, 0, 1.29372295718937, -3.74273703045535E-06, 0, -0.485347574032612, 0, 0, -0.64169927596879, 0, 0, -0.372770792335287, -1.65969298683108E-06, 0, 2.0810266773398, -3.05951887752859E-06, 0, -0.120759663711889, 1.20326101052018E-07, 0, -1.185239447153, 9.20385424208564E-07, 0, 0.239996840186869, 0, 0, -0.895237682944549, 1.42545494980942E-08, 0, -0.324134945946666, -1.66102844617919E-06, 0, 0.657301059216358, -3.4583255940861E-06, 0, -0.0273015093132705, -2.42456679490178E-06, 0, -0.893046770812148, 0, 0, -0.423678943593904, -2.30903521224855E-06, 0, -1.12052106582561, -8.76225165975816E-07, 0, 0.686243281405027, 2.69769172007729E-07, 0, -0.0679193351530219, -3.76964238196501E-06, 0, 0.806342244764276, -1.78550921165484E-06, 0, 0.660222065217791, -3.24071701709948E-06, 0, 0.158503733135092, 0, 0, 0.237590684162776, -6.29508778772813E-06, 0, 0.586592462614968, -3.3822004095546E-06, 0, 0.389875271171894, -2.40718887943536E-06, 0, -0.44987729764151, -2.00468070072008E-06, 0, -0.753744868495354, 0, 0, -0.122207008432717, 7.51212593290779E-07, 0, -0.301028985283127, 0, 0, -1.09680972744386, -2.16444219490669E-06, 0, 0.1110270650292, 0, 0, -1.25346591002082, -8.84433192859183E-07, 0, -0.208535276033205, 0, 0, 1.02911483214619, -3.05294835146086E-06, 0, -0.317448077995678, -1.28274829959484E-06, 0, -0.363862672639959, -2.03977248513041E-06, 0, -0.86391238233272, 0, 0, -0.494117382005948, -2.62954438397218E-06, 0, -0.367084469610504, -1.7152774770073E-06, 0, 0.467429889332054, 3.70872686371381E-07, 0, -0.150333066788987, -1.24057998815167E-05, 0, 0.614190215099394, -1.12121187126011E-05, 0, -0.529454948705975, -6.91554888349112E-06, 0, 0.241322022017769, -6.96510791010641E-06, 0, -0.0206019813550954, -6.19680135491675E-06, 0, -0.0589791130328868, -1.14020240168126E-05, 0, 0.371662921808969, -1.58383014505663E-05, 0, -0.599595207961612, -7.03660162165945E-06, 0, -0.81998685629991, -5.54803045994964E-06, 0, -1.37105471072694, 7.08455203865718E-07, 0, -0.773612381925567, 1.38472956108664E-06, 0, -0.882359150721206, 2.58578418883661E-06, 0, -0.0801348318507579, 1.19124005985129E-06, 0, -0.0383839880481778, -5.5800077532479E-06, 0, -0.709447758953151, -1.08948346693094E-05, 0, -5.6238125514983, 2.40257179224886E-06, 0, -0.526469985570851, -4.04653901744217E-06, 0, -0.972955962901828, 4.02478595367091E-07, 0, 0.0311495217681869, -1.1245615010775E-05, 0, 0.686421177243978, -1.26551846163201E-05, 0, 1.32722734865414, -1.27107387772176E-05, 0, -5.75678182388318, 3.16702883319597E-07, 0, -0.444442135914467, -1.04709586762879E-05, 0, 1.42786167399669, -1.86441539148275E-05, 0, 0.662501084150219, -1.2213006539122E-05, 0, -0.643199031566766, -6.42089812178612E-06, 0, 0.679604022187404, -9.73385168961031E-06, 0, -1.14773699925263, 3.27437892536419E-06, 0, -0.335705836286686, 0, 0, 1.32731909882894, -1.28527582008487E-05, 0, -0.633558607633728, -1.22487509505144E-05, 0, 0.0285357367280047, -3.79811175118991E-06, 0, 0.538069313216955, -8.30997146842554E-06, 0, -1.40356351804048, 0, 0, -0.295682238744022, -8.19487578461302E-06, 0, -0.854454029009487, -5.65401895977831E-06, 0, -0.486284828731995, 0, 0, 0.469058941145391, -1.07154940183311E-05, 0, -2.73102360920646, 2.66245805116478E-06, 0, -0.67734728000378, -1.42034193790171E-05, 0, -0.0228762805620273, -1.19465144774611E-05, 0, 1.43312522118902, -2.07186476938116E-05, 0, 1.58940611263042, -5.37219872309381E-06, 0, -0.0320892699264115, -4.18646394734294E-06, 0, 0.532286615238012, -1.34444558846355E-05, 0, -0.236932990252737, -3.08688954123807E-06, 0, -0.539035390659936, -1.45365002662358E-05, 0, -1.2134955756481, -8.58726952709211E-06, 0, 0.500392536401792, -7.7177537579257E-06, 0, -0.201792224319047, -1.57192440559472E-05, 0, 0.639828637867471, -7.4147310317256E-06, 0, -1.08273522159731, -1.2000614397154E-05, 0, 0.352299941403791, -9.53161979165201E-06, 0, 1.2409030814474, -1.35861767312126E-05, 0, 0.689082382103792, -8.93029632631296E-06, 0, 0.729840777031473, -9.472088785251E-06, 0, 0.552853500938304, -8.39761055917459E-06, 0, -0.702502891008575, -1.29534596669034E-05, 0, -0.0768293299348742, -6.73073336297725E-06, 0, -0.584873686420229, -1.02103088062381E-05, 0, 0.422486651901693, -4.48517159331396E-06, 0, 1.50594566241913, -1.60158018744625E-05, 0, 0.403614958745112, 0, 0, -0.214559808127953, 3.6721460527114E-06, 0, 0.661499867991172, -1.6091083389287E-05, 0, -0.211486608667703, 0, 0, 0.400142633951537, 0, 0, 1.65081042395957, -1.20408541883232E-05, 0, -0.731725909163881, -2.27625699192238E-06, 0, 1.03833548399745, -1.10109568904862E-05, 0, -0.501702024842307, -3.84149862058796E-06, 0, 0.236778704552509, -4.50386555335824E-06, 0, -1.02122663675919, 1.41208799961671E-06, 0, -0.369304328919794, 0, 0, -6.74053761822108, 2.48423659991912E-06, 0, 1.09169179295332, -1.14358650287261E-06, 0, 0.543175278477154, -1.3252793227232E-05, 0, -0.244240990217028, 6.12376821920294E-06, 0, -0.580971331613424, -8.06162592859199E-07, 0, -0.312068905926887, 4.47686562490374E-06, 0, 1.05164200395159, -5.77030553640713E-06, 0, 0.295570223565321, 2.04463969099219E-06, 0, -1.47546434707174, 2.61160248375355E-06, 0, -0.951118351524377, 1.72233927325796E-06, 0, -0.674582819775782, -4.01756550796754E-06, 0, -1.06217774067741, 3.16973901615434E-06, 0, 0.929155216487364, -6.15500691504121E-06, 0, 0.422966270943879, 2.60454190624099E-06, 0, 0.551560565829101, 2.17083084110504E-06, 0, -2.11600002158219, -2.46259465782953E-06, 0, 0.158330389364943, -5.47247072829398E-06, 0, -0.467484330052103, -3.93188342090075E-06, 0, -0.736231248244584, -6.0580210857611E-06, 0, 0.778621647886438, -5.63551614766212E-06, 0, 0.663062735762178, -4.33684948107358E-06, 0, 0.359975441289455, 0, 0, -0.543394629172532, -4.06079604551667E-06, 0, -0.615535028846973, 7.15866303958142E-06, 0, 0.510635493553706, -4.26462424229814E-06, 0, 0.0660187361430975, 3.21718163997734E-06, 0, 0.556146696435312, 7.70549237456999E-07, 0, 0.397191426242419, 1.99679853303358E-06, 0, 0.907834852213184, 1.39236041313414E-07, 0, 0.646916846081066, 1.8060733702827E-06, 0, -0.72886268616316, 2.0754101426103E-07, 0, -0.520141548256959, 3.77067133499853E-06, 0, -1.13516843884357, 2.82268234373846E-06, 0, -1.53554279703581, 5.79232915658861E-06, 0, 0.297456601351693, 1.15705208641878E-06, 0, 0.657810366701164, 2.50430171318612E-06, 0, -0.679448035123454, 2.3335263860396E-06, 0, -0.753707930041743, 5.64043173133706E-07, 0, -0.907108548057354, 3.49571633447462E-06, 0, -0.279639336444314, 1.79965065446275E-06, 0, 0.414296846370445, 4.38180747007091E-07, 0, -0.0997986227180051, 1.36388292829947E-06, 0, -1.08712589943838, 3.66896301696806E-07, 0, 0.266095934420788, 3.40055929212748E-06, 0, -8.29326153235255, 8.4540418046237E-07, 0, -0.069797215584677, 1.61026302487617E-06, 0, 2.33741766533875, 7.5793528173904E-07, 0, 1.01214532473535, 3.74843745586732E-07, 0, -1.10971865558264, 9.5324564370373E-07, 0, -0.0393851106271453, 3.93744104609554E-06, 0, -0.294125878858011, 2.48362210263355E-06, 0, 1.0686176057557, 3.17310293624877E-06, 0, -2.06750112045989, 1.11362663758912E-06, 0, -1.71466799486482, 6.0460763170261E-07, 0, -1.29275477797111, 9.49052001978084E-07, 0, -0.680260470592619, 3.96022419562949E-06, 0, 0.549000327326674, 3.51620738244379E-06, 0, -1.71330669382, 3.91892856377933E-06, 0, 0.414400448326239, -1.30138706311023E-06, 0, 3.03395642094081, -2.88527180312092E-06, 0, -0.303028041143573, 1.46695071868078E-07, 0, 0.0374701006043131, -2.19523246971772E-06, 0, 0.81367836013105, -2.10443367873211E-06, 0, -0.290429864801192, -2.73381979777747E-06, 0, 0.589034443203472, -1.92561913705349E-06, 0, 0.370156721523667, -1.49638436034048E-06, 0, -2.04203688630747, 8.88543335462146E-08, 0, -0.872894760623511, 0, 0, 0.811171197752113, -8.53979798802337E-07, 0, 1.28425653059075, -3.16524429566817E-06, 0, -2.78813359623314, 3.66005804844517E-07, 0, -0.620180314853979, 3.99736891515184E-08, 0, -1.03577778895226, -1.41025574045639E-06, 0, -0.116432606466585, 0, 0, -0.185335665888213, -2.73894928916924E-06, 0, -2.21743181933964, 1.3774124641797E-07, 0, -0.93241563375723, -1.92504614840613E-06, 0, -0.27411129790121, -1.22285740052483E-06, 0, 0.465803165440023, -1.18676863525751E-06, 0, 0.17564584045326, 0, 0, 0.370078502534556, -1.60321712954824E-06, 0, -15.5064971822177, 2.96074468183352E-07, 0, -0.904794954142873, -1.10462308573995E-06, 0, -0.517353379232047, 0, 0, -0.216787234841651, -1.97091937128031E-06, 0, -3.28027823867154, 2.90239015282884E-08, 0, 0.48588286994096, -1.01863345877598E-06, 0, 0.627331009603435, -3.50465118680584E-06, 0, 0.58632566169162, -2.77046666576538E-06, 0, -0.320202260783184, 8.63807911695178E-07, 0, -1.26646638596767, 1.21423237373393E-06, 0, 0.659590004410524, -3.30700786887439E-06, 0, -0.341046042515232, -1.54372201434942E-06, 0, -0.72409667622419, 1.40989062412392E-06, 0, 0.664288561297314, 0, 0, 0.366171180532513, -3.92760232313448E-06, 0, 0.040775756911299, -5.28502352521671E-06, 0, -0.285145082103127, -3.6241845436053E-06, 0, 0.500340511136531, -2.97739240684195E-06, 0, -0.628794350925201, 0, 0, -0.194031401134927, -1.21817027812796E-06, 0, -1.65727981478644, 2.14183551917274E-06, 0, 1.07440332868849, -8.8227826976757E-06, 0, -0.532263144366761, 9.53158256208613E-08, 0, -0.488800935569807, -8.0085865483166E-07, 0, -0.92708011965313, 1.762253610012E-06, 0, 1.25183634876681, -1.90710608936068E-06, 0, 0.553979915726584, -4.85361089023513E-06, 0, -0.0260963829191288, 3.20265096098007E-07, 0, -0.386396711128333, -2.45243373937351E-06, 0, -0.951004223304552, -9.11507164113315E-07, 0, -2.29597315064066, 2.92716517837811E-06, 0, -0.245772638026573, 1.14317886343049E-06, 0, -1.85678283619408, 9.45095936586676E-06, 0, -1.17682753512452, -2.49859221923961E-06, 0, -0.0293515658955152, -1.43397069193966E-06, 0, -0.276289465222027, -7.63729337691554E-07, 0, -0.157933624027602, -4.12525933881982E-07, 0, -1.56332909339816, 5.93251509805381E-07, 0, -1.87301107068774, 1.96345078231599E-07, 0, 1.26063331512109, -1.0225733498787E-05, 0, -1.02066194985485, 3.49348915621498E-06, 0, -0.160645910813038, 1.82660771688548E-06, 0, -1.00428646046731, 3.17207075964308E-06, 0, 0.298207411078417, -1.59023410220344E-05, 0, -0.511312724886582, -8.4493476778646E-06, 0, 0.657162126739054, -1.06005048121885E-05, 0, -0.0651632966171277, -5.56510063269516E-06, 0, -0.0383501422771406, -8.99685262952489E-06, 0, -1.05515214711632, -9.40787814005967E-08, 0, 0.0205300751727246, -1.56550430811228E-05, 0, 0.0307217425120966, -1.03548868095204E-05, 0, 3.6235538749942, -1.84105243733683E-05, 0, -0.234997495799191, -3.97755458619716E-06, 0, 1.24606739825912, -1.70688276961088E-05, 0, -0.512426189049366, -4.73386646767627E-06, 0, -0.591577803539487, -8.79353784551247E-07, 0, 0.305248225578272, -1.30130349552389E-05, 0, -1.26092181243415, -9.15361655053034E-06, 0, -0.585059865857009, -3.63029466899242E-06, 0, -1.13165006526266, -2.72073241964827E-06, 0, -1.25358553641268, 2.6874657036498E-06, 0, -1.14345438940981, -1.46603928111957E-05, 0, -1.77573407392122, 6.68269080773362E-08, 0, -0.281119316573285, -6.16443822821137E-06, 0, 0.171991795187296, -1.07851567384971E-05, 0, -0.251241824378322, -8.96400433741783E-06, 0, -0.407691008413706, -2.04803478078524E-06, 0, -0.423312417100279, -1.61942025243735E-05, 0, -0.613823377975147, -1.05356007767397E-05, 0, 0.226945026334486, -1.83270276667927E-05, 0, -0.378138295168451, -2.23379072372775E-06, 0, 0.0620561709899401, 1.14417996606314E-06, 0, -1.01882617094577, -5.02343839658604E-07, 0, 0.560467594131421, -1.88656647152465E-05, 0, 0.448291454930611, -1.66812630011141E-05, 0, -0.100468278503154, -9.82732186058302E-06, 0, 0.0860223757710897, 0, 0, 0.153021069912834, 7.54265938966522E-06, 0, -0.210382183599334, 0, 0, -1.01713130827254, 8.84600797390622E-06, 0, -0.598442442070052, 9.8445791611784E-06, 0, -0.745936197410879, 0, 0, -0.952685755347853, 8.40831795507964E-06, 0, 0.597907880922568, 8.92945971378049E-06, 0, 1.60903782901747, 0, 0, 0.796101230623665, 0, 0, -0.545974238559477, 3.70234480732083E-06, 0, -6.44880342417618, 7.60317290007282E-06, 0, -0.195628909769344, 0, 0, -0.305842924544978, 7.00578763017948E-06, 0, 0.430485735840306, 5.88781789253981E-06, 0, 1.72625600039524, 0, 0, -0.179461759948236, 1.09511973112596E-05, 0, 1.18891249996299, 0, 0, 0.747415469218667, 1.05095628027762E-05, 0, -0.954728762804588, 4.92942853132742E-06, 0, -0.926777170639148, 8.96323807214705E-06, 0, -1.09228462700396, 3.36562626967409E-06, 0, 0.477868527528546, 0, 0, 3.11939358848501, 0, 0, -0.274235998565479, 1.03937645794171E-05, 0, -0.454908309873654, 6.28165536126987E-06, 0, -0.613009356581027, 7.97965329390179E-06, 0, -0.640764561089564, 2.15832252013892E-06, 0, -0.0242425492933606, 4.62063787565821E-06, 0, 0.216388836645986, 7.69845801251171E-06, 0, -0.489022770942953, 7.01038431049601E-06, 0, -0.056736765651096, 0, 0, -0.940317726208129, 5.70652470298802E-06, 0, 0.01 };
            backpropNetwork.LoadFromArray(a);
        }
    }
}