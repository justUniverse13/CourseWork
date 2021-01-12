using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace TestProjectSelenium.Code.Extensions
{
    class Listener
    {
        readonly int totalTests;

        public Listener(ITestListener listener, int totalTests)
        {
            this.totalTests = totalTests;
            TestListener = listener;
            TestRunState = TestRunState.None;
        }

        public ITestListener TestListener { get; private set; }
        public TestRunState TestRunState { get; set; }

        public void onTestFail(ITestFailed args)
        {
            Console.WriteLine(args.Messages);
        }
    }
}
