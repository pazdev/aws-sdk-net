/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.ElasticBeanstalk
{

    /// <summary>
    /// Constants used for properties of type ConfigurationDeploymentStatus.
    /// </summary>
    public class ConfigurationDeploymentStatus : ConstantClass
    {

        /// <summary>
        /// Constant Deployed for ConfigurationDeploymentStatus
        /// </summary>
        public static readonly ConfigurationDeploymentStatus Deployed = new ConfigurationDeploymentStatus("deployed");
        /// <summary>
        /// Constant Failed for ConfigurationDeploymentStatus
        /// </summary>
        public static readonly ConfigurationDeploymentStatus Failed = new ConfigurationDeploymentStatus("failed");
        /// <summary>
        /// Constant Pending for ConfigurationDeploymentStatus
        /// </summary>
        public static readonly ConfigurationDeploymentStatus Pending = new ConfigurationDeploymentStatus("pending");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ConfigurationDeploymentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationDeploymentStatus FindValue(string value)
        {
            return FindValue<ConfigurationDeploymentStatus>(value);
        }

        public static implicit operator ConfigurationDeploymentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigurationOptionValueType.
    /// </summary>
    public class ConfigurationOptionValueType : ConstantClass
    {

        /// <summary>
        /// Constant List for ConfigurationOptionValueType
        /// </summary>
        public static readonly ConfigurationOptionValueType List = new ConfigurationOptionValueType("List");
        /// <summary>
        /// Constant Scalar for ConfigurationOptionValueType
        /// </summary>
        public static readonly ConfigurationOptionValueType Scalar = new ConfigurationOptionValueType("Scalar");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ConfigurationOptionValueType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigurationOptionValueType FindValue(string value)
        {
            return FindValue<ConfigurationOptionValueType>(value);
        }

        public static implicit operator ConfigurationOptionValueType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentHealth.
    /// </summary>
    public class EnvironmentHealth : ConstantClass
    {

        /// <summary>
        /// Constant Green for EnvironmentHealth
        /// </summary>
        public static readonly EnvironmentHealth Green = new EnvironmentHealth("Green");
        /// <summary>
        /// Constant Grey for EnvironmentHealth
        /// </summary>
        public static readonly EnvironmentHealth Grey = new EnvironmentHealth("Grey");
        /// <summary>
        /// Constant Red for EnvironmentHealth
        /// </summary>
        public static readonly EnvironmentHealth Red = new EnvironmentHealth("Red");
        /// <summary>
        /// Constant Yellow for EnvironmentHealth
        /// </summary>
        public static readonly EnvironmentHealth Yellow = new EnvironmentHealth("Yellow");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public EnvironmentHealth(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentHealth FindValue(string value)
        {
            return FindValue<EnvironmentHealth>(value);
        }

        public static implicit operator EnvironmentHealth(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentHealthAttribute.
    /// </summary>
    public class EnvironmentHealthAttribute : ConstantClass
    {

        /// <summary>
        /// Constant All for EnvironmentHealthAttribute
        /// </summary>
        public static readonly EnvironmentHealthAttribute All = new EnvironmentHealthAttribute("All");
        /// <summary>
        /// Constant ApplicationMetrics for EnvironmentHealthAttribute
        /// </summary>
        public static readonly EnvironmentHealthAttribute ApplicationMetrics = new EnvironmentHealthAttribute("ApplicationMetrics");
        /// <summary>
        /// Constant Causes for EnvironmentHealthAttribute
        /// </summary>
        public static readonly EnvironmentHealthAttribute Causes = new EnvironmentHealthAttribute("Causes");
        /// <summary>
        /// Constant Color for EnvironmentHealthAttribute
        /// </summary>
        public static readonly EnvironmentHealthAttribute Color = new EnvironmentHealthAttribute("Color");
        /// <summary>
        /// Constant HealthStatus for EnvironmentHealthAttribute
        /// </summary>
        public static readonly EnvironmentHealthAttribute HealthStatus = new EnvironmentHealthAttribute("HealthStatus");
        /// <summary>
        /// Constant InstancesHealth for EnvironmentHealthAttribute
        /// </summary>
        public static readonly EnvironmentHealthAttribute InstancesHealth = new EnvironmentHealthAttribute("InstancesHealth");
        /// <summary>
        /// Constant RefreshedAt for EnvironmentHealthAttribute
        /// </summary>
        public static readonly EnvironmentHealthAttribute RefreshedAt = new EnvironmentHealthAttribute("RefreshedAt");
        /// <summary>
        /// Constant Status for EnvironmentHealthAttribute
        /// </summary>
        public static readonly EnvironmentHealthAttribute Status = new EnvironmentHealthAttribute("Status");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public EnvironmentHealthAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentHealthAttribute FindValue(string value)
        {
            return FindValue<EnvironmentHealthAttribute>(value);
        }

        public static implicit operator EnvironmentHealthAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentHealthStatus.
    /// </summary>
    public class EnvironmentHealthStatus : ConstantClass
    {

        /// <summary>
        /// Constant Degraded for EnvironmentHealthStatus
        /// </summary>
        public static readonly EnvironmentHealthStatus Degraded = new EnvironmentHealthStatus("Degraded");
        /// <summary>
        /// Constant Info for EnvironmentHealthStatus
        /// </summary>
        public static readonly EnvironmentHealthStatus Info = new EnvironmentHealthStatus("Info");
        /// <summary>
        /// Constant NoData for EnvironmentHealthStatus
        /// </summary>
        public static readonly EnvironmentHealthStatus NoData = new EnvironmentHealthStatus("NoData");
        /// <summary>
        /// Constant Ok for EnvironmentHealthStatus
        /// </summary>
        public static readonly EnvironmentHealthStatus Ok = new EnvironmentHealthStatus("Ok");
        /// <summary>
        /// Constant Pending for EnvironmentHealthStatus
        /// </summary>
        public static readonly EnvironmentHealthStatus Pending = new EnvironmentHealthStatus("Pending");
        /// <summary>
        /// Constant Severe for EnvironmentHealthStatus
        /// </summary>
        public static readonly EnvironmentHealthStatus Severe = new EnvironmentHealthStatus("Severe");
        /// <summary>
        /// Constant Unknown for EnvironmentHealthStatus
        /// </summary>
        public static readonly EnvironmentHealthStatus Unknown = new EnvironmentHealthStatus("Unknown");
        /// <summary>
        /// Constant Warning for EnvironmentHealthStatus
        /// </summary>
        public static readonly EnvironmentHealthStatus Warning = new EnvironmentHealthStatus("Warning");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public EnvironmentHealthStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentHealthStatus FindValue(string value)
        {
            return FindValue<EnvironmentHealthStatus>(value);
        }

        public static implicit operator EnvironmentHealthStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentInfoType.
    /// </summary>
    public class EnvironmentInfoType : ConstantClass
    {

        /// <summary>
        /// Constant Bundle for EnvironmentInfoType
        /// </summary>
        public static readonly EnvironmentInfoType Bundle = new EnvironmentInfoType("bundle");
        /// <summary>
        /// Constant Tail for EnvironmentInfoType
        /// </summary>
        public static readonly EnvironmentInfoType Tail = new EnvironmentInfoType("tail");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public EnvironmentInfoType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentInfoType FindValue(string value)
        {
            return FindValue<EnvironmentInfoType>(value);
        }

        public static implicit operator EnvironmentInfoType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EnvironmentStatus.
    /// </summary>
    public class EnvironmentStatus : ConstantClass
    {

        /// <summary>
        /// Constant Launching for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus Launching = new EnvironmentStatus("Launching");
        /// <summary>
        /// Constant Ready for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus Ready = new EnvironmentStatus("Ready");
        /// <summary>
        /// Constant Terminated for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus Terminated = new EnvironmentStatus("Terminated");
        /// <summary>
        /// Constant Terminating for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus Terminating = new EnvironmentStatus("Terminating");
        /// <summary>
        /// Constant Updating for EnvironmentStatus
        /// </summary>
        public static readonly EnvironmentStatus Updating = new EnvironmentStatus("Updating");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public EnvironmentStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EnvironmentStatus FindValue(string value)
        {
            return FindValue<EnvironmentStatus>(value);
        }

        public static implicit operator EnvironmentStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EventSeverity.
    /// </summary>
    public class EventSeverity : ConstantClass
    {

        /// <summary>
        /// Constant DEBUG for EventSeverity
        /// </summary>
        public static readonly EventSeverity DEBUG = new EventSeverity("DEBUG");
        /// <summary>
        /// Constant ERROR for EventSeverity
        /// </summary>
        public static readonly EventSeverity ERROR = new EventSeverity("ERROR");
        /// <summary>
        /// Constant FATAL for EventSeverity
        /// </summary>
        public static readonly EventSeverity FATAL = new EventSeverity("FATAL");
        /// <summary>
        /// Constant INFO for EventSeverity
        /// </summary>
        public static readonly EventSeverity INFO = new EventSeverity("INFO");
        /// <summary>
        /// Constant TRACE for EventSeverity
        /// </summary>
        public static readonly EventSeverity TRACE = new EventSeverity("TRACE");
        /// <summary>
        /// Constant WARN for EventSeverity
        /// </summary>
        public static readonly EventSeverity WARN = new EventSeverity("WARN");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public EventSeverity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EventSeverity FindValue(string value)
        {
            return FindValue<EventSeverity>(value);
        }

        public static implicit operator EventSeverity(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstancesHealthAttribute.
    /// </summary>
    public class InstancesHealthAttribute : ConstantClass
    {

        /// <summary>
        /// Constant All for InstancesHealthAttribute
        /// </summary>
        public static readonly InstancesHealthAttribute All = new InstancesHealthAttribute("All");
        /// <summary>
        /// Constant ApplicationMetrics for InstancesHealthAttribute
        /// </summary>
        public static readonly InstancesHealthAttribute ApplicationMetrics = new InstancesHealthAttribute("ApplicationMetrics");
        /// <summary>
        /// Constant Causes for InstancesHealthAttribute
        /// </summary>
        public static readonly InstancesHealthAttribute Causes = new InstancesHealthAttribute("Causes");
        /// <summary>
        /// Constant Color for InstancesHealthAttribute
        /// </summary>
        public static readonly InstancesHealthAttribute Color = new InstancesHealthAttribute("Color");
        /// <summary>
        /// Constant HealthStatus for InstancesHealthAttribute
        /// </summary>
        public static readonly InstancesHealthAttribute HealthStatus = new InstancesHealthAttribute("HealthStatus");
        /// <summary>
        /// Constant LaunchedAt for InstancesHealthAttribute
        /// </summary>
        public static readonly InstancesHealthAttribute LaunchedAt = new InstancesHealthAttribute("LaunchedAt");
        /// <summary>
        /// Constant RefreshedAt for InstancesHealthAttribute
        /// </summary>
        public static readonly InstancesHealthAttribute RefreshedAt = new InstancesHealthAttribute("RefreshedAt");
        /// <summary>
        /// Constant System for InstancesHealthAttribute
        /// </summary>
        public static readonly InstancesHealthAttribute System = new InstancesHealthAttribute("System");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public InstancesHealthAttribute(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstancesHealthAttribute FindValue(string value)
        {
            return FindValue<InstancesHealthAttribute>(value);
        }

        public static implicit operator InstancesHealthAttribute(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationSeverity.
    /// </summary>
    public class ValidationSeverity : ConstantClass
    {

        /// <summary>
        /// Constant Error for ValidationSeverity
        /// </summary>
        public static readonly ValidationSeverity Error = new ValidationSeverity("error");
        /// <summary>
        /// Constant Warning for ValidationSeverity
        /// </summary>
        public static readonly ValidationSeverity Warning = new ValidationSeverity("warning");

        /// <summary>
        /// Default Constructor
        /// </summary>
        public ValidationSeverity(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationSeverity FindValue(string value)
        {
            return FindValue<ValidationSeverity>(value);
        }

        public static implicit operator ValidationSeverity(string value)
        {
            return FindValue(value);
        }
    }

}