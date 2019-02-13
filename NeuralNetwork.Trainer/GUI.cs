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
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog2;
        private OpenFileDialog openFileDialog3;
        private CheckBox alphabetCheckBox;
        private Label matrixYLabel;
        private TextBox matrixHeightTextBox;
        private TextBox matrixWidthTextBox;
        private TextBox iterationsTextBox;
        private Label matrixXLabel;
        private Label iterationsLabel;
        private Label testLabel3;
        private Label testLabel2;
        private Label testLabel1;
        private Label runningTimeLabel;
        private Button trainNetworkButton;
        private Label recognizedLabel;
        private Label recognizedResultLabel;
        private Button createNetworkButton;
        private Label errorLabel;
        private ProgressBar progressBar;
        private Label nodesLabel;
        private Button saveNetworkButton;
        private Button testNetworkButton;
        private Label headerLabel;
        private PictureBox testerPictureBox;

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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.alphabetCheckBox = new System.Windows.Forms.CheckBox();
            this.matrixYLabel = new System.Windows.Forms.Label();
            this.matrixHeightTextBox = new System.Windows.Forms.TextBox();
            this.matrixWidthTextBox = new System.Windows.Forms.TextBox();
            this.iterationsTextBox = new System.Windows.Forms.TextBox();
            this.matrixXLabel = new System.Windows.Forms.Label();
            this.iterationsLabel = new System.Windows.Forms.Label();
            this.testLabel3 = new System.Windows.Forms.Label();
            this.testLabel2 = new System.Windows.Forms.Label();
            this.testLabel1 = new System.Windows.Forms.Label();
            this.runningTimeLabel = new System.Windows.Forms.Label();
            this.trainNetworkButton = new System.Windows.Forms.Button();
            this.recognizedLabel = new System.Windows.Forms.Label();
            this.recognizedResultLabel = new System.Windows.Forms.Label();
            this.createNetworkButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.nodesLabel = new System.Windows.Forms.Label();
            this.saveNetworkButton = new System.Windows.Forms.Button();
            this.testNetworkButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.testerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.testerPictureBox)).BeginInit();
            this.SuspendLayout();
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
            // alphabetCheckBox
            // 
            this.alphabetCheckBox.AutoSize = true;
            this.alphabetCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphabetCheckBox.Location = new System.Drawing.Point(349, 324);
            this.alphabetCheckBox.Name = "alphabetCheckBox";
            this.alphabetCheckBox.Size = new System.Drawing.Size(92, 24);
            this.alphabetCheckBox.TabIndex = 48;
            this.alphabetCheckBox.Text = "Alphabet";
            this.alphabetCheckBox.UseVisualStyleBackColor = true;
            // 
            // matrixYLabel
            // 
            this.matrixYLabel.AutoSize = true;
            this.matrixYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrixYLabel.Location = new System.Drawing.Point(334, 276);
            this.matrixYLabel.Name = "matrixYLabel";
            this.matrixYLabel.Size = new System.Drawing.Size(70, 20);
            this.matrixYLabel.TabIndex = 47;
            this.matrixYLabel.Text = "Matrix Y:";
            // 
            // matrixHeightTextBox
            // 
            this.matrixHeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrixHeightTextBox.Location = new System.Drawing.Point(421, 273);
            this.matrixHeightTextBox.Name = "matrixHeightTextBox";
            this.matrixHeightTextBox.Size = new System.Drawing.Size(37, 26);
            this.matrixHeightTextBox.TabIndex = 46;
            this.matrixHeightTextBox.Text = "8";
            // 
            // matrixWidthTextBox
            // 
            this.matrixWidthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrixWidthTextBox.Location = new System.Drawing.Point(421, 250);
            this.matrixWidthTextBox.Name = "matrixWidthTextBox";
            this.matrixWidthTextBox.Size = new System.Drawing.Size(37, 26);
            this.matrixWidthTextBox.TabIndex = 44;
            this.matrixWidthTextBox.Text = "5";
            // 
            // iterationsTextBox
            // 
            this.iterationsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iterationsTextBox.Location = new System.Drawing.Point(421, 226);
            this.iterationsTextBox.Name = "iterationsTextBox";
            this.iterationsTextBox.Size = new System.Drawing.Size(37, 26);
            this.iterationsTextBox.TabIndex = 42;
            this.iterationsTextBox.Text = "1";
            // 
            // matrixXLabel
            // 
            this.matrixXLabel.AutoSize = true;
            this.matrixXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrixXLabel.Location = new System.Drawing.Point(334, 253);
            this.matrixXLabel.Name = "matrixXLabel";
            this.matrixXLabel.Size = new System.Drawing.Size(70, 20);
            this.matrixXLabel.TabIndex = 45;
            this.matrixXLabel.Text = "Matrix X:";
            // 
            // iterationsLabel
            // 
            this.iterationsLabel.AutoSize = true;
            this.iterationsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iterationsLabel.Location = new System.Drawing.Point(334, 229);
            this.iterationsLabel.Name = "iterationsLabel";
            this.iterationsLabel.Size = new System.Drawing.Size(80, 20);
            this.iterationsLabel.TabIndex = 43;
            this.iterationsLabel.Text = "Iterations:";
            // 
            // testLabel3
            // 
            this.testLabel3.AutoSize = true;
            this.testLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLabel3.Location = new System.Drawing.Point(17, 307);
            this.testLabel3.Name = "testLabel3";
            this.testLabel3.Size = new System.Drawing.Size(139, 20);
            this.testLabel3.TabIndex = 41;
            this.testLabel3.Text = "Numbers Test: 0%";
            // 
            // testLabel2
            // 
            this.testLabel2.AutoSize = true;
            this.testLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLabel2.Location = new System.Drawing.Point(17, 282);
            this.testLabel2.Name = "testLabel2";
            this.testLabel2.Size = new System.Drawing.Size(130, 20);
            this.testLabel2.TabIndex = 40;
            this.testLabel2.Text = "Ratings Test: 0%";
            // 
            // testLabel1
            // 
            this.testLabel1.AutoSize = true;
            this.testLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLabel1.Location = new System.Drawing.Point(17, 257);
            this.testLabel1.Name = "testLabel1";
            this.testLabel1.Size = new System.Drawing.Size(109, 20);
            this.testLabel1.TabIndex = 39;
            this.testLabel1.Text = "24px Test: 0%";
            // 
            // runningTimeLabel
            // 
            this.runningTimeLabel.AutoSize = true;
            this.runningTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runningTimeLabel.Location = new System.Drawing.Point(17, 222);
            this.runningTimeLabel.Name = "runningTimeLabel";
            this.runningTimeLabel.Size = new System.Drawing.Size(145, 20);
            this.runningTimeLabel.TabIndex = 38;
            this.runningTimeLabel.Text = "Running Time: 0ms";
            // 
            // trainNetworkButton
            // 
            this.trainNetworkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trainNetworkButton.Location = new System.Drawing.Point(16, 116);
            this.trainNetworkButton.Name = "trainNetworkButton";
            this.trainNetworkButton.Size = new System.Drawing.Size(120, 24);
            this.trainNetworkButton.TabIndex = 37;
            this.trainNetworkButton.Text = "2. Train Network";
            this.trainNetworkButton.Click += new System.EventHandler(this.trainNetwork_Click);
            // 
            // recognizedLabel
            // 
            this.recognizedLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recognizedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recognizedLabel.Location = new System.Drawing.Point(144, 52);
            this.recognizedLabel.Name = "recognizedLabel";
            this.recognizedLabel.Size = new System.Drawing.Size(325, 30);
            this.recognizedLabel.TabIndex = 36;
            this.recognizedLabel.Text = "RECOGNIZED";
            this.recognizedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recognizedResultLabel
            // 
            this.recognizedResultLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recognizedResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recognizedResultLabel.Location = new System.Drawing.Point(142, 85);
            this.recognizedResultLabel.Name = "recognizedResultLabel";
            this.recognizedResultLabel.Size = new System.Drawing.Size(327, 117);
            this.recognizedResultLabel.TabIndex = 35;
            this.recognizedResultLabel.Text = "A";
            this.recognizedResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createNetworkButton
            // 
            this.createNetworkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNetworkButton.Location = new System.Drawing.Point(16, 86);
            this.createNetworkButton.Name = "createNetworkButton";
            this.createNetworkButton.Size = new System.Drawing.Size(120, 24);
            this.createNetworkButton.TabIndex = 29;
            this.createNetworkButton.Text = "1. Create Network";
            this.createNetworkButton.Click += new System.EventHandler(this.createNetwork_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(17, 350);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(145, 20);
            this.errorLabel.TabIndex = 34;
            this.errorLabel.Text = "Error: 0  Iteration: 0";
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.nodesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.nodesLabel.Location = new System.Drawing.Point(3, 52);
            this.nodesLabel.Name = "nodesLabel";
            this.nodesLabel.Size = new System.Drawing.Size(136, 30);
            this.nodesLabel.TabIndex = 32;
            this.nodesLabel.Text = "Nodes: 0";
            this.nodesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveNetworkButton
            // 
            this.saveNetworkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveNetworkButton.Location = new System.Drawing.Point(16, 178);
            this.saveNetworkButton.Name = "saveNetworkButton";
            this.saveNetworkButton.Size = new System.Drawing.Size(120, 24);
            this.saveNetworkButton.TabIndex = 31;
            this.saveNetworkButton.Text = "Save Network";
            this.saveNetworkButton.Click += new System.EventHandler(this.SaveNetwork_Click);
            // 
            // testNetworkButton
            // 
            this.testNetworkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testNetworkButton.Location = new System.Drawing.Point(16, 146);
            this.testNetworkButton.Name = "testNetworkButton";
            this.testNetworkButton.Size = new System.Drawing.Size(120, 24);
            this.testNetworkButton.TabIndex = 30;
            this.testNetworkButton.Text = "3. Test Network";
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
            // testerPictureBox
            // 
            this.testerPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.testerPictureBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.testerPictureBox.Location = new System.Drawing.Point(469, 32);
            this.testerPictureBox.Name = "testerPictureBox";
            this.testerPictureBox.Size = new System.Drawing.Size(200, 341);
            this.testerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.testerPictureBox.TabIndex = 0;
            this.testerPictureBox.TabStop = false;
            this.testerPictureBox.Click += new System.EventHandler(this.testerPictureBox_Click);
            // 
            // GUI
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(669, 397);
            this.Controls.Add(this.alphabetCheckBox);
            this.Controls.Add(this.matrixYLabel);
            this.Controls.Add(this.matrixHeightTextBox);
            this.Controls.Add(this.matrixWidthTextBox);
            this.Controls.Add(this.iterationsTextBox);
            this.Controls.Add(this.matrixXLabel);
            this.Controls.Add(this.iterationsLabel);
            this.Controls.Add(this.testLabel3);
            this.Controls.Add(this.testLabel2);
            this.Controls.Add(this.testLabel1);
            this.Controls.Add(this.runningTimeLabel);
            this.Controls.Add(this.trainNetworkButton);
            this.Controls.Add(this.recognizedLabel);
            this.Controls.Add(this.recognizedResultLabel);
            this.Controls.Add(this.createNetworkButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.nodesLabel);
            this.Controls.Add(this.saveNetworkButton);
            this.Controls.Add(this.testNetworkButton);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.testerPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neural Network Trainer";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.testerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
                trainingSet = new string[owner.alphabetCheckBox.Checked == true ? 26 : 10];

                for (int i = 0; i < trainingSet.Length; i++)
                {
                    string randomFile;
                    string[] listOfFiles;
                    if (owner.alphabetCheckBox.Checked)
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
                timer.Restart();

                for (int inputSets = 0; inputSets < Convert.ToInt32(owner.iterationsTextBox.Text); inputSets++)
                {
                    Debug.WriteLine("Running inputset " + (inputSets + 1));
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
                            owner.errorLabel.Text = "Error: " + currentError.ToString() + "  Iteration: " + iteration.ToString();
                        }
                        owner.progressBar.Value = good;
                        owner.runningTimeLabel.Text = "Running Time: " + (double)timer.ElapsedMilliseconds + "ms";
                    }

                    owner.errorLabel.Text = "Error: " + currentError.ToString() + "  Iteration: " + iteration.ToString();
                    owner.progressBar.Value = good;

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

            if (openFileDialog3.ShowDialog(this) == DialogResult.OK)
            {
                workingPath = Path.GetDirectoryName(openFileDialog3.FileName);
            }
            int inputs = alphabetCheckBox.Checked == true ? 26 : 10;
            progressBar.Maximum = inputs;
            backpropNetwork = new OCRNetwork(this, new int[3] { Convert.ToInt32(matrixWidthTextBox.Text) * Convert.ToInt32(matrixHeightTextBox.Text), (Convert.ToInt32(matrixWidthTextBox.Text) * Convert.ToInt32(matrixHeightTextBox.Text) + inputs) / 2, inputs });
            nodesLabel.Text = "outputNodes: " + inputs;
        }

        private void trainNetwork_Click(object sender, System.EventArgs e)
        {
            if (backpropNetwork == null)
            {
                MessageBox.Show("Create network first");
                return;
            }
            while (true)
            {
                if (IsTerminated) return;
                int inputs = alphabetCheckBox.Checked == true ? 26 : 10;
                backpropNetwork = new OCRNetwork(this, new int[3] { Convert.ToInt32(matrixWidthTextBox.Text) * Convert.ToInt32(matrixHeightTextBox.Text), (Convert.ToInt32(matrixWidthTextBox.Text) * Convert.ToInt32(matrixHeightTextBox.Text) + inputs) / 2, inputs });

                backpropNetwork.Train(trainingPatterns);

                break;
            }
        }
        private void TestButton_Click(object sender, EventArgs e)
        {
            if (backpropNetwork == null)
            {
                MessageBox.Show("Create network first");
                return;
            }
            testTimer.Restart();
            if (alphabetCheckBox.Checked)
            {
                testLabel2.Text = "Big Test: " + Test("\\..\\..\\TrainData\\maps\\").ToString() + "%";
                testLabel3.Text = "2018 Test: " + Test("\\..\\..\\TrainData\\maps\\2018\\").ToString() + "%";
            }
            else
            {
                testLabel1.Text = "24px Test: " + Test("\\..\\..\\TrainData\\numbers\\24px\\").ToString() + "%";
                testLabel2.Text = "Ratings Test: " + Test("\\..\\..\\TrainData\\skillratings\\2019\\").ToString() + "%";
                testLabel3.Text = "Numbers Test: " + Test("\\..\\..\\TrainData\\numbers\\2018\\").ToString() + "%";
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
                    if (alphabetCheckBox.Checked)
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
        private void SaveNetwork_Click(object sender, System.EventArgs e)
        {
            if (backpropNetwork == null)
            {
                MessageBox.Show("Create network first");
                return;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                backpropNetwork.SaveToFile(saveFileDialog1.FileName);
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

            if (openFileDialog2.ShowDialog(this) == DialogResult.OK)
            {
                path = openFileDialog2.FileName;

                double[] aInput = CharToDoubleArray(new Bitmap(path), matrixWidth, matrixHeight);

                for (int i = 0; i < backpropNetwork.InputNodesCount; i++)
                {
                    backpropNetwork.InputNode(i).Value = aInput[i];
                }
                backpropNetwork.Run();
                recognizedResultLabel.Text = Convert.ToChar('A' + backpropNetwork.BestNodeIndex).ToString() + "(" + backpropNetwork.BestNodeIndex + ")";
                testerPictureBox.BackgroundImage = new Bitmap(trainingSet[backpropNetwork.BestNodeIndex]);
                testerPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }
}