﻿using Cake.CD.Templating.Steps.Build;
using System.Collections.Generic;

namespace Cake.CD.Templating.ScriptTaskFactories
{
    public class NUnitTestsFactory : IScriptTaskFactory
    {
        public int ParsingOrder => 10;

        public bool IsTerminating => false;

        public bool IsApplicable(ProjectInfo projectInfo)
        {
            return projectInfo.FindReference("nunit") != null;
        }

        public IEnumerable<IScriptTask> Create(ProjectInfo projectInfo)
        {
            return new List<IScriptTask>
            {
                new NUnitTestsTask(projectInfo.SolutionFilePath.GetFilenameWithoutExtension().FullPath)
            };
        }

        
    }
}
