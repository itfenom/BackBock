﻿namespace Jedzia.BackBock.Tasks.Shared
{
    using System;
    using System.Xml;
    using System.Xml.Schema;

    internal sealed class BuildEventFileInfo
    {
        // Fields
        private int column;
        private int endColumn;
        private int endLine;
        private string file;
        private int line;

        // Methods
        private BuildEventFileInfo()
        {
        }

        internal BuildEventFileInfo(string file) : this(file, 0, 0, 0, 0)
        {
        }

        internal BuildEventFileInfo(XmlSchemaException e)
        {
            ErrorUtilities.VerifyThrow(e != null, "Need exception context.");
            this.file = (e.SourceUri.Length == 0) ? string.Empty : new Uri(e.SourceUri).LocalPath;
            this.line = e.LineNumber;
            this.column = e.LinePosition;
            this.endLine = 0;
            this.endColumn = 0;
        }

        internal BuildEventFileInfo(XmlException e)
        {
            ErrorUtilities.VerifyThrow(e != null, "Need exception context.");
            this.file = (e.SourceUri.Length == 0) ? string.Empty : new Uri(e.SourceUri).LocalPath;
            this.line = e.LineNumber;
            this.column = e.LinePosition;
            this.endLine = 0;
            this.endColumn = 0;
        }

        internal BuildEventFileInfo(string file, int line, int column) : this(file, line, column, 0, 0)
        {
        }

        internal BuildEventFileInfo(string file, int line, int column, int endLine, int endColumn)
        {
            ErrorUtilities.VerifyThrow(file != null, "Need filename/path.");
            this.file = file;
            this.line = line;
            this.column = column;
            this.endLine = endLine;
            this.endColumn = endColumn;
        }

        // Properties
        internal int Column
        {
            get
            {
                return this.column;
            }
        }

        internal int EndColumn
        {
            get
            {
                return this.endColumn;
            }
        }

        internal int EndLine
        {
            get
            {
                return this.endLine;
            }
        }

        internal string File
        {
            get
            {
                return this.file;
            }
        }

        internal int Line
        {
            get
            {
                return this.line;
            }
        }
    }
}