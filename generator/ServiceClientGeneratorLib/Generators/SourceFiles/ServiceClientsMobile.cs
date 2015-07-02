﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.SourceFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class ServiceClientsMobile : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"

    AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("\r\n\r\nusing System;\r\nusing System.Runtime.ExceptionServices;\r\nusing System.Threadin" +
                    "g;\r\nusing System.Threading.Tasks;\r\nusing System.Collections.Generic;\r\n\r\nusing ");
            
            #line 17 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model;\r\nusing ");
            
            #line 18 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model.Internal.MarshallTransformations;\r\nusing Amazon.Runtime;\r\nusing Amazon.Run" +
                    "time.Internal;\r\nusing Amazon.Runtime.Internal.Auth;\r\nusing Amazon.Runtime.Intern" +
                    "al.Transform;\r\n\r\nnamespace ");
            
            #line 24 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n");
            
            #line 26 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
    this.FormatServiceClientDocumentation(this.Config.ServiceModel.Documentation); 
            
            #line default
            #line hidden
            this.Write("    public partial class Amazon");
            
            #line 27 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Client : AmazonServiceClient, IAmazon");
            
            #line 27 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("\r\n    {\r\n        \r\n");
            
            #line 30 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"

    // Generates generic constructors for the service if enabled in the model
    if(this.Config.GenerateConstructors)
    {

            
            #line default
            #line hidden
            this.Write("        #region Constructors\r\n\r\n        /// <summary>\r\n        /// Constructs Ama" +
                    "zon");
            
            #line 38 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Client with AWS Credentials\r\n        /// </summary>\r\n        /// <param name=\"cre" +
                    "dentials\">AWS Credentials</param>\r\n        public Amazon");
            
            #line 41 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Client(AWSCredentials credentials)\r\n            : this(credentials, new Amazon");
            
            #line 42 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Config())\r\n        {\r\n        }\r\n\r\n        /// <summary>\r\n        /// Constructs " +
                    "Amazon");
            
            #line 47 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Client with AWS Credentials\r\n        /// </summary>\r\n        /// <param name=\"cre" +
                    "dentials\">AWS Credentials</param>\r\n        /// <param name=\"region\">The region t" +
                    "o connect.</param>\r\n        public Amazon");
            
            #line 51 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Client(AWSCredentials credentials, RegionEndpoint region)\r\n            : this(cre" +
                    "dentials, new Amazon");
            
            #line 52 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Config{RegionEndpoint = region})\r\n        {\r\n        }\r\n\r\n        /// <summary>\r\n" +
                    "        /// Constructs Amazon");
            
            #line 57 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Client with AWS Credentials and an\r\n        /// Amazon");
            
            #line 58 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Client Configuration object.\r\n        /// </summary>\r\n        /// <param name=\"cr" +
                    "edentials\">AWS Credentials</param>\r\n        /// <param name=\"clientConfig\">The A" +
                    "mazon");
            
            #line 61 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Client Configuration Object</param>\r\n        public Amazon");
            
            #line 62 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Client(AWSCredentials credentials, Amazon");
            
            #line 62 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Config clientConfig)\r\n            : base(credentials, clientConfig)\r\n        {\r\n " +
                    "       }\r\n\r\n        /// <summary>\r\n        /// Constructs Amazon");
            
            #line 68 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Client with AWS Access Key ID and AWS Secret Key\r\n        /// </summary>\r\n       " +
                    " /// <param name=\"awsAccessKeyId\">AWS Access Key ID</param>\r\n        /// <param " +
                    "name=\"awsSecretAccessKey\">AWS Secret Access Key</param>\r\n        public Amazon");
            
            #line 72 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Client(string awsAccessKeyId, string awsSecretAccessKey)\r\n            : this(awsA" +
                    "ccessKeyId, awsSecretAccessKey, new Amazon");
            
            #line 73 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Config())\r\n        {\r\n        }\r\n\r\n        /// <summary>\r\n        /// Constructs " +
                    "Amazon");
            
            #line 78 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write(@"Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name=""awsAccessKeyId"">AWS Access Key ID</param>
        /// <param name=""awsSecretAccessKey"">AWS Secret Access Key</param>
        /// <param name=""region"">The region to connect.</param>
        public Amazon");
            
            #line 83 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)\r\n" +
                    "            : this(awsAccessKeyId, awsSecretAccessKey, new Amazon");
            
            #line 84 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Config() {RegionEndpoint=region})\r\n        {\r\n        }\r\n\r\n        /// <summary>\r" +
                    "\n        /// Constructs Amazon");
            
            #line 89 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Client with AWS Access Key ID, AWS Secret Key and an\r\n        /// Amazon");
            
            #line 90 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Client Configuration object. \r\n        /// </summary>\r\n        /// <param name=\"a" +
                    "wsAccessKeyId\">AWS Access Key ID</param>\r\n        /// <param name=\"awsSecretAcce" +
                    "ssKey\">AWS Secret Access Key</param>\r\n        /// <param name=\"clientConfig\">The" +
                    " Amazon");
            
            #line 94 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Client Configuration Object</param>\r\n        public Amazon");
            
            #line 95 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Client(string awsAccessKeyId, string awsSecretAccessKey, Amazon");
            
            #line 95 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Config clientConfig)\r\n            : base(awsAccessKeyId, awsSecretAccessKey, clie" +
                    "ntConfig)\r\n        {\r\n        }\r\n\r\n        /// <summary>\r\n        /// Constructs" +
                    " Amazon");
            
            #line 101 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write(@"Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name=""awsAccessKeyId"">AWS Access Key ID</param>
        /// <param name=""awsSecretAccessKey"">AWS Secret Access Key</param>
        /// <param name=""awsSessionToken"">AWS Session Token</param>
        public Amazon");
            
            #line 106 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)\r" +
                    "\n            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new Ama" +
                    "zon");
            
            #line 107 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Config())\r\n        {\r\n        }\r\n\r\n        /// <summary>\r\n        /// Constructs " +
                    "Amazon");
            
            #line 112 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write(@"Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name=""awsAccessKeyId"">AWS Access Key ID</param>
        /// <param name=""awsSecretAccessKey"">AWS Secret Access Key</param>
        /// <param name=""awsSessionToken"">AWS Session Token</param>
        /// <param name=""region"">The region to connect.</param>
        public Amazon");
            
            #line 118 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, " +
                    "RegionEndpoint region)\r\n            : this(awsAccessKeyId, awsSecretAccessKey, a" +
                    "wsSessionToken, new Amazon");
            
            #line 119 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Config{RegionEndpoint = region})\r\n        {\r\n        }\r\n\r\n        /// <summary>\r\n" +
                    "        /// Constructs Amazon");
            
            #line 124 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Client with AWS Access Key ID, AWS Secret Key and an\r\n        /// Amazon");
            
            #line 125 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write(@"Client Configuration object. 
        /// </summary>
        /// <param name=""awsAccessKeyId"">AWS Access Key ID</param>
        /// <param name=""awsSecretAccessKey"">AWS Secret Access Key</param>
        /// <param name=""awsSessionToken"">AWS Session Token</param>
        /// <param name=""clientConfig"">The Amazon");
            
            #line 130 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Client Configuration Object</param>\r\n        public Amazon");
            
            #line 131 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, " +
                    "Amazon");
            
            #line 131 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Config clientConfig)\r\n            : base(awsAccessKeyId, awsSecretAccessKey, awsS" +
                    "essionToken, clientConfig)\r\n        {\r\n        }\r\n\r\n        #endregion\r\n");
            
            #line 137 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"

    }

            
            #line default
            #line hidden
            this.Write("\r\n        #region Overrides\r\n\r\n\t\t/// <summary>\r\n        /// Creates the signer fo" +
                    "r the service.\r\n        /// </summary>\r\n        protected override AbstractAWSSi" +
                    "gner CreateSigner()\r\n        {\r\n            return new ");
            
            #line 148 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratorHelpers.DetermineSigner(this.Config.ServiceModel.SignatureVersion, this.Config.BaseName)));
            
            #line default
            #line hidden
            this.Write("();\r\n        } \r\n\r\n");
            
            #line 151 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"

    // Generates overrides for the pipeline if specified in the customizations file
        if(this.Config.ServiceModel.Customizations.PipelineOverride != null)
        {

            
            #line default
            #line hidden
            this.Write(@"		/// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name=""pipeline"">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
");
            
            #line 162 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"

            var pipelineOverrides = this.Config.ServiceModel.Customizations.PipelineOverride;
            foreach(var o in pipelineOverrides.Overrides )
            {
                if(o.OverrideMethod == "remove")
                {

            
            #line default
            #line hidden
            this.Write("            pipeline.");
            
            #line 169 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(o.FormattedOverrideMethod));
            
            #line default
            #line hidden
            this.Write("();\r\n");
            
            #line 170 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"

                }
                else
                {

            
            #line default
            #line hidden
            this.Write("            pipeline.");
            
            #line 175 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(o.FormattedOverrideMethod));
            
            #line default
            #line hidden
            this.Write("(new ");
            
            #line 175 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(o.NewType));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 175 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(o.ConstructorInput));
            
            #line default
            #line hidden
            this.Write("));\r\n");
            
            #line 176 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"

                }
            }

            
            #line default
            #line hidden
            this.Write("        }\r\n");
            
            #line 181 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"

        }

            
            #line default
            #line hidden
            this.Write(@"
        #endregion

        #region Dispose

		/// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        ");
            
            #line 199 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"

    // Creates the method code for each operation in the model
        foreach(var operation in this.Config.ServiceModel.Operations)
        {
        
            
            #line default
            #line hidden
            this.Write("\r\n        #region  ");
            
            #line 205 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            
            #line 207 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"

        if (this.Config.ServiceModel.Customizations.CreateNoArgOverload(operation.Name))
        {

            
            #line default
            #line hidden
            this.Write("        internal ");
            
            #line 211 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response ");
            
            #line 211 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("()\r\n        {\r\n            return ");
            
            #line 213 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(new ");
            
            #line 213 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request());\r\n        }\r\n");
            
            #line 215 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"

        }

            
            #line default
            #line hidden
            this.Write("        internal ");
            
            #line 218 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response ");
            
            #line 218 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 218 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request request)\r\n        {\r\n            var marshaller = new ");
            
            #line 220 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("RequestMarshaller();\r\n            var unmarshaller = ");
            
            #line 221 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("ResponseUnmarshaller.Instance;\r\n\r\n            return Invoke<");
            
            #line 223 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request,");
            
            #line 223 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response>(request, marshaller, unmarshaller);\r\n        }\r\n\r\n");
            
            #line 226 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
AddAsyncDocumentation(operation.Name);
            
            #line default
            #line hidden
            this.Write("        ");
            
            #line 227 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.IsInternal ? "internal" : "public"));
            
            #line default
            #line hidden
            this.Write(" Task<");
            
            #line 227 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response> ");
            
            #line 227 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Async(");
            
            #line 227 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request request, System.Threading.CancellationToken cancellationToken = default(C" +
                    "ancellationToken))\r\n        {\r\n            var marshaller = new ");
            
            #line 229 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("RequestMarshaller();\r\n            var unmarshaller = ");
            
            #line 230 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("ResponseUnmarshaller.Instance;\r\n\r\n            return InvokeAsync<");
            
            #line 232 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request,");
            
            #line 232 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response>(request, marshaller, \r\n                unmarshaller, cancellationToken)" +
                    ";\r\n        }\r\n\r\n        #endregion\r\n        ");
            
            #line 237 "C:\dev\net\v3\XamarinSdk\generator\ServiceClientGeneratorLib\Generators\SourceFiles\ServiceClientsMobile.tt"

        }
        
            
            #line default
            #line hidden
            this.Write("\r\n    }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}