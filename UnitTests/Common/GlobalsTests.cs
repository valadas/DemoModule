using DnnSummit.Modules.DemoModule.Common;
using System;
using Xunit;

namespace UnitTests.Common
{
    public class GlobalsTests
    {
        [Fact]
        public void ModulePrefixIsValid()
        {
            var modulePrefix = Globals.ModulePrefix;
            Assert.Equal(expected: "Dnn_DemoModule_", modulePrefix);
        }
    }
}
