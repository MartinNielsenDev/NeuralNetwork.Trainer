using System;
using System.Collections.Generic;
using System.IO;
using NeuralNetwork.Trainer.adaline;
using NeuralNetwork.Trainer.Patterns;

namespace NeuralNetwork.Trainer.bam
{
    public class BidirectionalAssociativeMemoryLink : AdalineLink
    {
        public BidirectionalAssociativeMemoryLink()
        {
            Weight = 0;
        }
    }

    public class BidirectionalAssociativeMemoryOutputNode : AdalineNode
    {
        protected double nodesLastValue;

        public double NodeLastValue
        {
            get { return GetNodeLastValue(); }
            set { SetNodeLastValue(value); }
        }

        protected virtual double GetNodeLastValue()
        {
            return nodesLastValue;
        }

        protected virtual void SetNodeLastValue(double aLastValue)
        {
            nodesLastValue = aLastValue;
        }

        protected override void SetNodeValue(double value)
        {
            nodeError = value;
            nodeValue = value;
        }

        public override void Run()
        {
            NodeLastValue = Value;
            base.Run();
        }

        public override void Learn()
        {
            foreach (var link in InLinks)
                link.UpdateWeight(link.InNode.Value * link.OutNode.Value);
        }

        public override void Load(double[] loadData)
        {
            base.Load(loadData);
            nodesLastValue = ExtractDataFromArray(loadData);
        }

        public override void Save(List<double> saveData)
        {
            base.Save(saveData);
            saveData.Add(nodesLastValue);
        }
    }

    public class BidirectionalAssociativeMemoryInputNode : BidirectionalAssociativeMemoryOutputNode
    {
        public override void Run()
        {
            NodeLastValue = Value;
            double total = 0;
            foreach (var link in OutLinks)
                total += link.WeightedOutValue();
            nodeValue = Transfer(total);
        }

        public override void Learn()
        {
        }
    }

    /// <remarks>
    ///     <img src="BAM.jpg"></img>
    ///     The  Bidirectional Associative Memory (BAM) network that consists of two layers. An input layer and an output
    ///     layer. The main difference between backpropagation architecture is that BAM does not stop learning when input
    ///     values reach the output layer. The learning phase stops when the network becomes stable ; no change between input
    ///     and output values during two consecutive cycles. The pattern sets for training and running and ouput results can
    ///     only have two values : 1.1 or -1.1. The BAM is a relatively simple neural network architecture with a content
    ///     addressable memory. BAM is usefull for pattern recognition or with noisy and corrupted patterns.  Bam can also
    ///     "forget" if there are two many patterns in it. BAM becomes saturated when the number of patterns stored is greater
    ///     than the minimum of the input layer count and the ouput layer node count. BAM System is created to solve this
    ///     problem.
    /// </remarks>
    public class BidirectionalAssociativeMemoryNetwork : AdalineNetwork
    {
        protected int inputLayerNodesCount;
        protected int outputLayerNodesCount;

        public BidirectionalAssociativeMemoryNetwork(int aInputNodesCount, int aOutputNodesCount)
        {
            inputLayerNodesCount = aInputNodesCount;
            outputLayerNodesCount = aOutputNodesCount;
            nodesCount = InputNodesCount + OutputNodesCount;
            linksCount = InputNodesCount * OutputNodesCount;
            CreateNetwork();
        }

        public BidirectionalAssociativeMemoryNetwork(double[] neuralNetworkData) : base(neuralNetworkData)
        {
        }

        public virtual double value(int index)
        {
            return nodes[InputNodesCount + index].Value;
        }

        protected override double GetNodeError()
        {
            double e1 = 0;
            double e2 = 0;
            for (var i = InputNodesCount; i < InputNodesCount + OutputNodesCount; i++)
                for (var j = 0; j < nodes[i].InLinks.Count; j++)
                {
                    var node = nodes[i];
                    var link = node.InLinks[j];
                    e1 = e1 + link.WeightedInValue() * link.OutNode.Value;
                    e2 = e2 + link.WeightedInError() * link.OutNode.Value;
                }
            if (e1 == e2)
                return Math.Abs(-InputNodesCount * OutputNodesCount + e1);
            return double.PositiveInfinity;
        }

        public virtual void SetValues(int index, double value)
        {
            nodes[index].Value = value;
        }

        protected override void CreateNetwork()
        {
            nodes = new NeuroNode[NodesCount];
            links = new NeuroLink[LinksCount];
            for (var i = 0; i < InputNodesCount; i++)
                nodes[i] = new BidirectionalAssociativeMemoryInputNode();
            for (var i = InputNodesCount; i < InputNodesCount + OutputNodesCount; i++)
                nodes[i] = new BidirectionalAssociativeMemoryOutputNode();
            for (var i = 0; i < linksCount; i++)
                links[i] = new BidirectionalAssociativeMemoryLink();
            var k = 0;

            for (var i = 0; i < InputNodesCount; i++)
                for (var j = InputNodesCount; j < InputNodesCount + OutputNodesCount; j++)
                {
                    nodes[i].LinkTo(nodes[j], links[k]);
                    k++;
                }
        }

        protected override void LoadInputs()
        {
            for (var i = 0; i < InLinks.Count; i++)
                SetValues(i, InLinks[i].InNode.Value);
        }

        protected override NeuralNetworkType GetNetworkType()
        {
            return NeuralNetworkType.nntBAM;
        }

        protected override int GetInputNodesCount()
        {
            return inputLayerNodesCount;
        }

        protected override int GetOutPutNodesCount()
        {
            return outputLayerNodesCount;
        }

        protected override NeuroNode GetOutputNode(int index)
        {
            if ((index >= OutputNodesCount) || (index < 0))
                throw new ENeuroException("OutputNode index out of bounds.");
            return nodes[index + InputNodesCount];
        }

        public override void SetValuesFromPattern(Pattern pattern)
        {
            for (var i = 0; i < pattern.InputsCount; i++)
                nodes[i].Value = pattern.Input[i];
            for (var i = 0; i < pattern.OutputsCount; i++)
                nodes[i + InputNodesCount].Value = pattern.Output[i];
        }

        public override void Run()
        {
            LoadInputs();
            var IsStable = false;
            var iteration = 0;
            while (!IsStable)
            {
                IsStable = true;
                iteration++;
                for (var i = InputNodesCount + OutputNodesCount - 1; i >= 0; i--)
                    nodes[i].Run();
                if (iteration > 1)
                {
                    for (var j = 0; j < InputNodesCount + OutputNodesCount; j++)
                    {
                        var node = (BidirectionalAssociativeMemoryOutputNode)nodes[j];
                        if (!IsStable) break;
                        if (node.Value != node.NodeLastValue)
                            IsStable = false;
                    }
                }
                else
                    IsStable = false;
            }
        }

        public override void Learn()
        {
            for (var i = InputNodesCount; i < InputNodesCount + OutputNodesCount; i++)
                nodes[i].Learn();
        }

        public override void Train(PatternsCollection patterns)
        {
            if (patterns != null)
                for (var i = 0; i < patterns.Count; i++)
                {
                    SetValuesFromPattern(patterns[i]);
                    Learn();
                }
        }

        public void UnLearn()
        {
            for (var i = InputNodesCount; i < InputNodesCount + OutputNodesCount; i++)
                nodes[i].Value = -nodes[i].Value;
            Learn();
        }

        public override void Load(double[] loadData)
        {
            inputLayerNodesCount = Convert.ToInt32(ExtractDataFromArray(loadData));
            outputLayerNodesCount = Convert.ToInt32(ExtractDataFromArray(loadData));
            base.Load(loadData);
        }

        public override void Save(List<double> saveData)
        {
            saveData.Add(inputLayerNodesCount);
            saveData.Add(outputLayerNodesCount);

            base.Save(saveData);
        }
    }

    public class BidirectionalAssociativeMemorySystem : BidirectionalAssociativeMemoryNetwork
    {
        protected BidirectionalAssociativeMemoryNetwork best;
        protected double bestError;
        protected Pattern data;
        protected BidirectionalAssociativeMemoryNetwork[] networks;
        protected int networksCount;
        protected double orthogonalBAMEnergy;

        public BidirectionalAssociativeMemorySystem(int aInputNodesCount, int aOutputNodesCount)
            : base(aInputNodesCount, aOutputNodesCount)
        {
            Create(aInputNodesCount, aOutputNodesCount);
        }

        public override double value(int index)
        {
            return best.value(index);
        }

        protected override double GetNodeError()
        {
            return bestError;
        }

        public override void SetValues(int index, double value)
        {
            data.Input[index] = value;
        }

        protected override void CreateNetwork()
        {
            nodes = new NeuroNode[0];
            links = new NeuroLink[0];
            networksCount = 0;
            orthogonalBAMEnergy = -inputLayerNodesCount * outputLayerNodesCount;
            bestError = double.PositiveInfinity;
        }

        protected override void LoadInputs()
        {
            for (var i = 0; i < InLinks.Count; i++)
                data.Input[i] = InLinks[i].InNode.Value;
        }

        protected override NeuralNetworkType GetNetworkType()
        {
            return NeuralNetworkType.nntBAMSystem;
        }

        private void Create(int aInputNodesCount, int aOutputNodesCount)
        {
            inputLayerNodesCount = aInputNodesCount;
            outputLayerNodesCount = aOutputNodesCount;
            CreateNetwork();
            data = new Pattern(aInputNodesCount, aOutputNodesCount);
        }

        public override void Run()
        {
            LoadInputs();
            bestError = double.PositiveInfinity;
            for (var i = 0; i < networksCount; i++)
            {
                networks[i].SetValuesFromPattern(data);
                networks[i].Run();
                var err = networks[i].Error;
                if (err <= bestError)
                {
                    bestError = err;
                    best = networks[i];
                }
            }
        }

        public override void Learn()
        {
            var isLearned = false;
            for (var i = 0; i < networksCount; i++)
            {
                if (isLearned) break;
                networks[i].SetValuesFromPattern(data);
                networks[i].Learn();
                if (networks[i].Error != 0)
                    networks[i].UnLearn();
                else
                    isLearned = true;
            }
            if (!isLearned)
            {
                var oldNetworks = networks;
                networks = new BidirectionalAssociativeMemoryNetwork[networksCount + 1];
                if (oldNetworks != null)
                    oldNetworks.CopyTo(networks, 0);
                networks[networksCount] = new BidirectionalAssociativeMemoryNetwork(inputLayerNodesCount,
                    outputLayerNodesCount);
                networks[networksCount].SetValuesFromPattern(data);
                networks[networksCount].Learn();
                networksCount++;
            }
        }

        public override void Load(double[] loadData)
        {
            base.Load(loadData);
            Create(inputLayerNodesCount, outputLayerNodesCount);
            networksCount = Convert.ToInt32(ExtractDataFromArray(loadData));
            var networks = new BidirectionalAssociativeMemoryNetwork[networksCount];

            for (var i = 0; i < networksCount; i++)
            {
                networks[i] = new BidirectionalAssociativeMemoryNetwork(inputLayerNodesCount, outputLayerNodesCount);
                networks[i].Load(loadData);
            }
        }

        public override void Save(List<double> saveData)
        {
            base.Save(saveData);
            saveData.Add(networksCount);

            for (var i = 0; i < networksCount; i++)
            {
                networks[i].Save(saveData);
            }
        }

        protected override NeuroNode GetOutputNode(int index)
        {
            if ((index >= OutputNodesCount) || (index < 0))
                throw new ENeuroException("OutputNode index out of bounds.");
            //In case of Adaline an index always will be 0.
            return best.OutputNode(index);
        }

        public override void SetValuesFromPattern(Pattern pattern)
        {
            for (var i = 0; i < pattern.InputsCount; i++)
                data.Input[i] = pattern.Input[i];
            for (var i = 0; i < pattern.OutputsCount; i++)
                data.Output[i] = pattern.Output[i];
        }
    }
}