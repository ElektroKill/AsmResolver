﻿using System.Collections.Generic;
using AsmResolver.DotNet;
using AsmResolver.DotNet.Signatures.Types;
using AsmResolver.Workspaces.DotNet.Analyzers;

namespace AsmResolver.Workspaces.DotNet
{
    /// <summary>
    /// Represents a workspace of .NET assemblies.
    /// </summary>
    public class DotNetWorkspace : Workspace
    {
        /// <summary>
        /// Creates a new instance of the <see cref="DotNetWorkspace"/> class.
        /// </summary>
        public DotNetWorkspace()
        {
            Analyzers.Register(typeof(AssemblyDefinition), new AssemblyAnalyzer());
            Analyzers.Register(typeof(ModuleDefinition), new ModuleAnalyzer());
            Analyzers.Register(typeof(TypeDefinition), new TypeAnalyzer());
            Analyzers.Register(typeof(MethodDefinition), new MethodImplementationAnalyzer());
            Analyzers.Register(typeof(IHasSemantics), new SemanticsImplementationAnalyzer());
            Analyzers.Register(typeof(TypeReference), new TypeReferenceAnalyser());
            Analyzers.Register(typeof(MemberReference), new MemberReferenceAnalyser());
            Analyzers.Register(typeof(IHasCustomAttribute), new CustomAttributeAnalyser());
            Analyzers.Register(typeof(TypeSignature), new TypeSpecificationAnalyser());
        }

        /// <summary>
        /// Gets a collection of assemblies added to the workspace.
        /// </summary>
        public IList<AssemblyDefinition> Assemblies
        {
            get;
        } = new AssemblyCollection();

        /// <summary>
        /// Analyzes all the assemblies in the workspace.
        /// </summary>
        public void Analyze()
        {
            var context = new AnalysisContext(this);

            for (int i = 0; i < Assemblies.Count; i++)
                context.SchedulaForAnalysis(Assemblies[i]);

            base.Analyze(context);
        }

    }
}
