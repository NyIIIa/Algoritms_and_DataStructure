using System;
using Algoritms_and_DataStructure.Lesson1;
using Algoritms_and_DataStructure.Lesson2;
using Algoritms_and_DataStructure.Lesson3;
using Algoritms_and_DataStructure.Lesson4.BinaryTree;
using Algoritms_and_DataStructure.Lesson4.HashSet_Task1_;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;

namespace Algoritms_and_DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
        
    }
}