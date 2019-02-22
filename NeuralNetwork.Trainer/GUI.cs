using NeuralNetwork.Trainer.BackProp;
using NeuralNetwork.Trainer.Patterns;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
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
            this.iterationsTextBox.Text = "50";
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
            this.numbersOrAlphabetButton.Text = "PLAYERS";
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
            this.Load += new System.EventHandler(this.GUI_Load);
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
        public static double highest = 0;
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
                trainingSet = new string[owner.GetInputs(owner.numbersOrAlphabetButton.Text)];

                for (int i = 0; i < trainingSet.Length; i++)
                {
                    string randomFile;
                    string[] listOfFiles = { };
                    if (trainingSet.Length == 26)
                    {
                        listOfFiles = Directory.GetFiles(workingPath, Convert.ToChar('A' + i) + "*.png");
                    }
                    else if (trainingSet.Length == 35)
                    {
                        if (i < 9)
                        {
                            listOfFiles = Directory.GetFiles(workingPath, (i + 1) + "*.png");
                        }
                        else
                        {
                            listOfFiles = Directory.GetFiles(workingPath, Convert.ToChar('A' + (i - 9)) + "*.png");
                        }
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
                        randomFile = listOfFiles[(int)Random(0, listOfFiles.Length - 1)];
                        //randomFile = listOfFiles[index];
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
                    int good = 0;

                    while (good < patterns.Count)
                    {
                        if (IsTerminated) return;

                        for (int i = 0; i < patterns.Count; i++)
                        {
                            for (int k = 0; k < NodesInLayer(0); k++)
                            {
                                nodes[k].Value = patterns[i].Input[k];
                            }

                            //AddNoiseToInputPattern((int)Random(0, 3));
                            Run();
                            for (int k = 0; k < OutputNodesCount; k++)
                            {
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
                        owner.progressBar.Value = inputSets + 1;
                    }
                }
            }
        }
        public Bitmap GenerateNoise(Bitmap original, int percent)
        {
            Random r = new Random();

            for (int x = 1; x < original.Width - 1; x++)
            {
                for (int y = 1; y < original.Height - 1; y++)
                {
                    int random = r.Next(0, 101);
                    if (random <= percent)
                    {
                        if (original.GetPixel(x + 1, y).R == 255 || // right side
                            original.GetPixel(x, y + 1).R == 255 || // bottom
                            original.GetPixel(x - 1, y).R == 255 || // left
                            original.GetPixel(x, y - 1).R == 255 // top
                            )
                        {
                            original.SetPixel(x, y, Color.FromArgb(255, 255, 255, 255));
                        }
                    }
                }
            }
            return original;
        }
        public PatternsCollection CreateTrainingPatterns()
        {
            int matrixWidth = Convert.ToInt32(matrixWidthTextBox.Text);
            int matrixHeight = Convert.ToInt32(matrixHeightTextBox.Text);
            PatternsCollection result = new PatternsCollection(trainingSet.Length, matrixWidth * matrixHeight, trainingSet.Length);

            for (int i = 0; i < trainingSet.Length; i++)
            {
                Bitmap original;
                original = new Bitmap(trainingSet[i]);
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
            int inputs = GetInputs(numbersOrAlphabetButton.Text);
            backpropNetwork = new OCRNetwork(this, new int[3] { Convert.ToInt32(matrixWidthTextBox.Text) * Convert.ToInt32(matrixHeightTextBox.Text), (Convert.ToInt32(matrixWidthTextBox.Text) * Convert.ToInt32(matrixHeightTextBox.Text) + inputs) / 2, inputs });
            nodesLabel.Text = "Nodes: " + inputs;
        }
        public int GetInputs(string text)
        {
            switch (text)
            {
                case "MAPS":
                    return 26;
                case "STATS":
                    return 10;
                case "PLAYERS":
                    return 35;
                default:
                    return 0;
            }
        }

        private void trainNetwork_Click(object sender, EventArgs e)
        {
            IsTerminated = false;
            if (backpropNetwork == null)
            {
                MessageBox.Show("Create network first");
                return;
            }
            if (IsTerminated) return;
            RunTraining();
        }
        private void TestButton_Click(object sender, EventArgs e)
        {
            IsTerminated = false;
            if (backpropNetwork == null)
            {
                MessageBox.Show("Create network first");
                return;
            }
            RunTests();
        }
        private void RunTraining()
        {
            int inputs = GetInputs(numbersOrAlphabetButton.Text);
            progressBar.Maximum = Convert.ToInt32(iterationsTextBox.Text);
            backpropNetwork = new OCRNetwork(this, new int[3] { Convert.ToInt32(matrixWidthTextBox.Text) * Convert.ToInt32(matrixHeightTextBox.Text), (Convert.ToInt32(matrixWidthTextBox.Text) * Convert.ToInt32(matrixHeightTextBox.Text) + inputs) / 2, inputs });
            backpropNetwork.Train(trainingPatterns);
            //RunTests(); // uncomment this to run tests right after training is done
        }
        private void RunTests()
        {
            testTimer.Restart();
            textBox1.Text = "Tests finished!" + Environment.NewLine + Environment.NewLine;
            double test1, test2;
            if (numbersOrAlphabetButton.Text == "MAPS")
            {
                test1 = Test("\\..\\..\\TrainData\\maps\\test_data\\");
                test2 = Test("\\..\\..\\TrainData\\maps\\train_data\\");
                textBox1.Text += "Maps Test: " + test1.ToString() + "%" + Environment.NewLine;
                textBox1.Text += "Maps Test: " + test2.ToString() + "%" + Environment.NewLine;
            }
            else if (numbersOrAlphabetButton.Text == "PLAYERS")
            {
                //test1 = Test("\\..\\..\\TrainData\\players\\train_data\\");
                test2 = Test("\\..\\..\\TrainData\\players\\real_train_data\\");
                //textBox1.Text += "Players Test: " + test1.ToString() + "%" + Environment.NewLine;
                textBox1.Text += "Real Players Test: " + test2.ToString() + "%" + Environment.NewLine;
            }
            else if (numbersOrAlphabetButton.Text == "STATS")
            {
                test1 = Test("\\..\\..\\TrainData\\ratings\\test_data\\");
                test2 = Test("\\..\\..\\TrainData\\numbers\\test_data\\");
                textBox1.Text += "Ratings Test: " + test1.ToString() + "%" + Environment.NewLine;
                textBox1.Text += "Numbers Test: " + test2.ToString() + "%" + Environment.NewLine;
            }
            testTimer.Stop();
            // uncomment this to keep running forever until 100% accuracy is reached
            /*
            double result = test2;
            if(result > highest)
            {
                highest = result;
                backpropNetwork.SaveToFile();
            }
            if (result < 100)
            {
                Console.WriteLine(result + "% running again");
                RunTraining();
            }
            */
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
                    string[] listOfFiles = { };
                    if (numbersOrAlphabetButton.Text == "MAPS")
                    {
                        listOfFiles = Directory.GetFiles(Directory.GetCurrentDirectory() + path, Convert.ToChar('A' + j) + "*.png"); // for the alphabet
                    }
                    else if (numbersOrAlphabetButton.Text == "PLAYERS")
                    {
                        if (j < 9)
                        {
                            listOfFiles = Directory.GetFiles(Directory.GetCurrentDirectory() + path, (j + 1) + "*.png");
                        }
                        else
                        {
                            listOfFiles = Directory.GetFiles(Directory.GetCurrentDirectory() + path, Convert.ToChar('A' + (j - 9)) + "*.png");
                        }
                    }
                    else
                    {
                        listOfFiles = Directory.GetFiles(Directory.GetCurrentDirectory() + path, j + "*.png"); // for numbers
                    }
                    if (listOfFiles.Length == 0)
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
            return Math.Round(((double)correct / (double)trainingSet.Length) * 100 / iterations, 2);
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
                if (numbersOrAlphabetButton.Text == "MAPS")
                {
                    recognizedResultLabel.Text = Convert.ToChar('A' + backpropNetwork.BestNodeIndex).ToString();
                }
                else if (numbersOrAlphabetButton.Text == "PLAYERS")
                {
                    int bestIndex = backpropNetwork.BestNodeIndex;
                    if (bestIndex < 9)
                    {
                        recognizedResultLabel.Text = (bestIndex + 1).ToString();
                    }
                    else
                    {
                        recognizedResultLabel.Text = Convert.ToChar('A' + (bestIndex - 9)).ToString();
                    }
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
            if (numbersOrAlphabetButton.Text.Equals("MAPS"))
            {
                numbersOrAlphabetButton.Text = "STATS";
            }
            else if (numbersOrAlphabetButton.Text.Equals("STATS"))
            {
                numbersOrAlphabetButton.Text = "PLAYERS";
            }
            else
            {
                numbersOrAlphabetButton.Text = "MAPS";
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
        }

        private void GUI_Load(object sender, EventArgs e)
        {
        }
    }
}