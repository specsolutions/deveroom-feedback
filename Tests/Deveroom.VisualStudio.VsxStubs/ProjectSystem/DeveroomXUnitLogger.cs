﻿using System.Diagnostics;
using Deveroom.VisualStudio.Diagonostics;
using Xunit.Abstractions;

namespace Deveroom.VisualStudio.VsxStubs.ProjectSystem
{
    public class DeveroomXUnitLogger : IDeveroomLogger
    {
        private readonly ITestOutputHelper _testOutputHelper;
        public TraceLevel Level { get; }

        public DeveroomXUnitLogger(ITestOutputHelper testOutputHelper, TraceLevel level = TraceLevel.Verbose)
        {
            Level = level;
            _testOutputHelper = testOutputHelper;
        }

        public void Log(TraceLevel messageLevel, string message)
        {
            if (messageLevel <= Level)
            {
                _testOutputHelper.WriteLine($"{messageLevel}: {message}");
            }
        }
    }
}
