﻿namespace StyleCop.CSharp
{
    internal class MethodViolationData
    {
        public MethodViolationData(params object[] parameters)
        {
            this.Parameters = parameters;
        }

        public object[] Parameters { get; private set; }
    }
}