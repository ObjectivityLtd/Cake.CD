﻿using Cake.Core.IO;

namespace Cake.CD.Templating.Steps.Build
{
    public class GulpTask : IScriptTask
    {
        public string Name => "Build " + this.NpmProjectName;

        public ScriptTaskType Type => ScriptTaskType.BuildFrontend;

        public DirectoryPath ProjectDir { get; }

        public string NpmProjectName { get; }

        public GulpTask(DirectoryPath projectDir, string npmProjectName)
        {
            this.ProjectDir = projectDir;
            this.NpmProjectName = npmProjectName ?? this.ProjectDir.GetDirectoryName();
        }
    }
}
