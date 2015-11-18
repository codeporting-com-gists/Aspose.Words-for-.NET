﻿//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Words. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Words;
using Aspose.Words.Reporting;

namespace CSharp.LINQ
{
    class HelloWorld
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LINQ();

            // Load the template document.
            Document doc = new Document(dataDir + "HelloWorld.doc");

            // Create an instance of sender class to set it's properties.
            Sender sender = new Sender { Name = "LINQ Reporting Engine", Message = "Hello World" };
            
            // Create a Reporting Engine.
            ReportingEngine engine = new ReportingEngine();
            
            // Execute the build report.
            engine.BuildReport(doc, sender, "sender");

            dataDir = dataDir + "HelloWorld Out.doc";

            // Save the finished document to disk.
            doc.Save(dataDir);

            Console.WriteLine("\nTemplate document is populated with the data about the sender.\nFile saved at " + dataDir);

        }
    }
}