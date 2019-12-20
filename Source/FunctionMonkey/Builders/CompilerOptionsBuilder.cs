using FunctionMonkey.Abstractions.Builders;
using FunctionMonkey.Compiler.Core;
using FunctionMonkey.Model;

namespace FunctionMonkey.Builders
{
    internal class CompilerOptionsBuilder : ICompilerOptionsBuilder
    {
        private readonly CompilerOptions _options;

        public CompilerOptionsBuilder(CompilerOptions options)
        {
            _options = options;
        }

        public ICompilerOptionsBuilder HttpTarget(CompileTargetEnum target)
        {
            _options.HttpTarget = target;
            return this;
        }
    }
}