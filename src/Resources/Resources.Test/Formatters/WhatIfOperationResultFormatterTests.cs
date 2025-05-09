﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Resources.Test.Formatters
{
    using Management.Resources.Models;
    using ResourceManager.Cmdlets.Formatters;
    using ResourceManager.Cmdlets.SdkModels.Deployments;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using WindowsAzure.Commands.ScenarioTest;
    using Xunit;

    public class WhatIfOperationResultFormatterTests
    {
        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void Format_EmptyResourceChanges_ReturnsNoChangeInfo()
        {
            // Arrange.
            var psWhatIfOperationResult = new PSWhatIfOperationResult(new WhatIfOperationResult());
            string noChangeInfo = new ColoredStringBuilder()
                .AppendLine()
                .Append("Resource changes: no change.")
                .ToString();

            // Act.
            string result = WhatIfOperationResultFormatter.Format(psWhatIfOperationResult);

            // Assert.
            Assert.Contains(noChangeInfo, result);
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void Format_NonEmptyResourceChanges_AddsLegendAtTheBeginning()
        {
            // Arrange.
            var resourceChanges = new List<WhatIfChange>
            {
                new WhatIfChange
                {
                    ResourceId = "",
                    ChangeType = ChangeType.Deploy
                },
                new WhatIfChange
                {
                    ResourceId = "",
                    ChangeType = ChangeType.Create
                },
                new WhatIfChange
                {
                    ResourceId = "",
                    ChangeType = ChangeType.Ignore
                },
                new WhatIfChange
                {
                    ResourceId = "",
                    ChangeType = ChangeType.Create
                }
            };

            var psWhatIfOperationResult =
                new PSWhatIfOperationResult(new WhatIfOperationResult(changes: resourceChanges));

            string legend = @"Resource and property changes are indicated with these symbols:
  + Create
  ! Deploy
  * Ignore
"
                .Replace("+", new ColoredStringBuilder().Append("+", Color.Green).ToString())
                .Replace("!", new ColoredStringBuilder().Append("!", Color.Blue).ToString())
                .Replace("*", new ColoredStringBuilder().Append("*", Color.Gray).ToString())
                .Replace("\r\n", Environment.NewLine);

            // Act.
            string result = WhatIfOperationResultFormatter.Format(psWhatIfOperationResult);

            // Assert.
            Assert.Contains(legend, result);
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void Format_NonEmptyResourceChanges_AddsStatsAtTheEnd()
        {
            // Arrange.
            var whatIfChanges = new List<WhatIfChange>
            {
                new WhatIfChange
                {
                    ResourceId = "",
                    ChangeType = ChangeType.Create
                },
                new WhatIfChange
                {
                    ResourceId = "",
                    ChangeType = ChangeType.Create
                },
                new WhatIfChange
                {
                    ResourceId = "",
                    ChangeType = ChangeType.Modify
                },
                new WhatIfChange
                {
                    ResourceId = "",
                    ChangeType = ChangeType.Delete
                }
            };

            string stats = new ColoredStringBuilder()
                .AppendLine()
                .Append("Resource changes: 1 to delete, 2 to create, 1 to modify.")
                .ToString();

            // Act.
            string result = WhatIfOperationResultFormatter.Format(
                new PSWhatIfOperationResult(new WhatIfOperationResult(changes: whatIfChanges)));

            // Assert.
            Assert.EndsWith(stats, result);
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void Format_NonEmptyResourceChanges_ExtractApiVersion()
        {
            // Arrange.
            var whatIfChanges = new List<WhatIfChange>
            {
                new WhatIfChange
                {
                    ResourceId = "/subscriptions/00000000-0000-0000-0000-000000000002/resourceGroups/rg1/providers/p2/foo",
                    ChangeType = ChangeType.Modify,
                    Before = new { apiVersion = "2018-07-01" },
                    After = new { apiVersion = "2018-07-01" }
                },
            };

            string changesInfo = $@"
Scope: /subscriptions/00000000-0000-0000-0000-000000000002/resourceGroups/rg1
{Color.Purple}
  ~ p2/foo{Color.Reset} [2018-07-01]{Color.Purple}
{Color.Reset}"
                .Replace("\r\n", Environment.NewLine);

            // Act.
            string result = WhatIfOperationResultFormatter.Format(
                new PSWhatIfOperationResult(new WhatIfOperationResult(changes: whatIfChanges)));

            // Assert.
            Assert.Contains(changesInfo, result);
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void Format_NonEmptyResourceChanges_SortsAndGroupsByScopeAndChangeType()
        {
            // Arrange.
            var whatIfChanges = new List<WhatIfChange>
            {
                new WhatIfChange
                {
                    ResourceId = "/Subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/RG1/providers/p1/foo1",
                    ChangeType = ChangeType.Create
                },
                new WhatIfChange
                {
                    ResourceId = "/Subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/rg1/providers/p2/bar",
                    ChangeType = ChangeType.Create
                },
                new WhatIfChange
                {
                    ResourceId = "/subscriptions/00000000-0000-0000-0000-000000000002/resourceGroups/rg2/providers/p1/foo2",
                    ChangeType = ChangeType.Modify
                },
                new WhatIfChange
                {
                    ResourceId = "/SUBSCRIPTIONS/00000000-0000-0000-0000-000000000002/providers/p3/foobar1",
                    ChangeType = ChangeType.Ignore
                },
                new WhatIfChange
                {
                    ResourceId = "/subscriptions/00000000-0000-0000-0000-000000000002/providers/p3/foobar2",
                    ChangeType = ChangeType.Delete
                },
                new WhatIfChange
                {
                    ResourceId = "/subscriptions/00000000-0000-0000-0000-000000000002/resourceGroups/rg3",
                    ChangeType = ChangeType.Delete
                }
            };

            string changesInfo = $@"
Scope: /subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/RG1
{Color.Green}
  + p1/foo1
  + p2/bar
{Color.Reset}
Scope: /subscriptions/00000000-0000-0000-0000-000000000002
{Color.Orange}
  - p3/foobar2
  - resourceGroups/rg3{Color.Reset}{Color.Gray}
  * p3/foobar1
{Color.Reset}
Scope: /subscriptions/00000000-0000-0000-0000-000000000002/resourceGroups/rg2
{Color.Purple}
  ~ p1/foo2
{Color.Reset}"
                .Replace("\r\n", Environment.NewLine);

            // Act.
            string result = WhatIfOperationResultFormatter.Format(
                new PSWhatIfOperationResult(new WhatIfOperationResult(changes: whatIfChanges)));

            // Assert.
            Assert.Contains(changesInfo, result);
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void Format_ResourceIdOnly_SortsAndGroupsByShortResourceId()
        {
            // Arrange.
            var whatIfChanges = new List<WhatIfChange>
            {
                new WhatIfChange
                {
                    ResourceId = "/subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/rg1/providers/p0/foo",
                    ChangeType = ChangeType.Unsupported,
                },
                new WhatIfChange
                {
                    ResourceId = "/subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/rg1/providers/p1/foo",
                    ChangeType = ChangeType.Ignore,
                },
                new WhatIfChange
                {
                    ResourceId = "/subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/rg1/providers/p2/foo",
                    ChangeType = ChangeType.Create,
                },
                new WhatIfChange
                {
                    ResourceId = "/subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/rg1/providers/p3/foo",
                    ChangeType = ChangeType.NoChange,
                },
                new WhatIfChange
                {
                    ResourceId = "/subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/rg1/providers/p4/foo",
                    ChangeType = ChangeType.Deploy,
                },
                new WhatIfChange
                {
                    ResourceId = "/subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/rg1/providers/p5/foo",
                    ChangeType = ChangeType.Delete,
                },
                new WhatIfChange
                {
                    ResourceId = "/subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/rg1/providers/p6/foo",
                    ChangeType = ChangeType.Delete,
                }
            };

            string shortResourceIds = $@"
{Color.Orange}
  - p5/foo
  - p6/foo{Color.Reset}{Color.Green}
  + p2/foo{Color.Reset}{Color.Blue}
  ! p4/foo{Color.Reset}{Color.Gray}
  x p0/foo{Color.Reset}{Color.Reset}
  = p3/foo{Color.Reset}{Color.Gray}
  * p1/foo
{Color.Reset}
"
                .Replace("\r\n", Environment.NewLine);

            // Act.
            string result = WhatIfOperationResultFormatter.Format(
                new PSWhatIfOperationResult(new WhatIfOperationResult(changes: whatIfChanges)));

            // Assert.
            Assert.Contains(shortResourceIds, result);
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void Format_ChangeTypeDelete_FormatsBeforeValue()
        {
            // Arrange.
            var whatIfChanges = new List<WhatIfChange>
            {
                new WhatIfChange
                {
                    ResourceId = "/subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/rg1/providers/p1/foo",
                    ChangeType = ChangeType.Delete,
                    Before = new
                    {
                        numberValue = 1.2,
                        booleanValue = true,
                        stringValue = "str",
                    }
                }
            };

            string colon = $"{Color.Reset}:{Color.Orange}";
            string beforeValue = @"

      numberValue:  1.2
      booleanValue: true
      stringValue:  ""str""
"
                .Replace(":", colon)
                .Replace("\r\n", Environment.NewLine);

            // Act.
            string result = WhatIfOperationResultFormatter.Format(
                new PSWhatIfOperationResult(new WhatIfOperationResult(changes: whatIfChanges)));

            // Assert.
            Assert.Contains(beforeValue, result);
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void Format_ChangeTypeCreate_FormatsAfterValue()
        {
            // Arrange.
            var whatIfChanges = new List<WhatIfChange>
            {
                new WhatIfChange
                {
                    ResourceId = "/subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/rg1/providers/p1/foo",
                    ChangeType = ChangeType.Create,
                    After = new
                    {
                        numberValue = 1.2,
                        booleanValue = true,
                        stringValue = "str",
                    }
                }
            };

            string colon = $"{Color.Reset}:{Color.Green}";
            string afterValue = $@"

      numberValue:  1.2
      booleanValue: true
      stringValue:  ""str""
"
                .Replace(":", colon)
                .Replace("\r\n", Environment.NewLine);

            // Act.
            string result = WhatIfOperationResultFormatter.Format(
                new PSWhatIfOperationResult(new WhatIfOperationResult(changes: whatIfChanges)));

            // Assert.
            Assert.Contains(afterValue, result);
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void Format_ChangeTypeModify_FormatsPropertyChanges()
        {
            // Arrange.
            var whatIfChanges = new List<WhatIfChange>
            {
                new WhatIfChange
                {
                    ResourceId = "/subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/rg1/providers/p1/foo",
                    ChangeType = ChangeType.Modify,
                    Delta = new List<WhatIfPropertyChange>
                    {
                        new WhatIfPropertyChange
                        {
                            Path = "path.to.property.change",
                            PropertyChangeType = PropertyChangeType.Modify,
                            Before = "foo",
                            After = "bar"
                        },
                        new WhatIfPropertyChange
                        {
                            Path = "path.to.property.change2",
                            PropertyChangeType = PropertyChangeType.NoEffect,
                            Before = "no",
                            After = "yes"
                        },
                        new WhatIfPropertyChange
                        {
                            Path = "path.to.array.change",
                            PropertyChangeType = PropertyChangeType.Array,
                            Children = new List<WhatIfPropertyChange>
                            {
                                new WhatIfPropertyChange
                                {
                                    Path = "1",
                                    PropertyChangeType = PropertyChangeType.Modify,
                                    Before = "foo",
                                    After = "bar"
                                }
                            }
                        },
                    }
                }
            };

            string foo = $@"{Color.Orange}""foo""{Color.Reset}";
            string bar = $@"{Color.Green}""bar""{Color.Reset}";
            string yes = $@"{Color.Gray}""yes""{Color.Reset}";
            string expected = $@"
Scope: /subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/rg1
{Color.Purple}
  ~ p1/foo{Color.Reset}
    {Color.Purple}~{Color.Reset} path.to.array.change{Color.Reset}:{Color.Reset} [
      {Color.Purple}~{Color.Reset} 1{Color.Reset}:{Color.Reset} ""foo"" => ""bar""
      ]
    {Color.Purple}~{Color.Reset} path.to.property.change{Color.Reset}:{Color.Reset}  ""foo"" => ""bar""
    {Color.Gray}x{Color.Reset} path.to.property.change2{Color.Reset}:{Color.Reset} ""yes""
"
                .Replace(@"""foo""", foo)
                .Replace(@"""bar""", bar)
                .Replace(@"""yes""", yes)
                .Replace("\r\n", Environment.NewLine);

            // Act.
            string result = WhatIfOperationResultFormatter.Format(
                new PSWhatIfOperationResult(new WhatIfOperationResult(changes: whatIfChanges)));

            // Assert.
            Assert.Contains(expected, result);
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void Format_FormatsDiagnosticsAndUnsupportedChanges()
        {
            var whatIfChanges = new List<WhatIfChange>
            {
                new WhatIfChange
                {
                    ResourceId = "/subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/rg1/providers/p0/foo",
                    ChangeType = ChangeType.Unsupported,
                    UnsupportedReason = "Unable to determine the source."
                }
            };

            var diagnostics = new List<DeploymentDiagnosticsDefinition>
            {
                new DeploymentDiagnosticsDefinition("Warning", "Code", "Nested Deployment Skipped.", "resource1")
            };

            string expected = $@"Diagnostics (2): 
{Color.DarkYellow}(resource1) Nested Deployment Skipped. (Code)
{Color.Reset}{Color.DarkYellow}(/subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/rg1/providers/p0/foo) Unable to determine the source. (Unsupported)
{Color.Reset}"
            .Replace("\r\n", Environment.NewLine);

            // Act.
            string result = WhatIfOperationResultFormatter.Format(
                new PSWhatIfOperationResult(new WhatIfOperationResult(changes: whatIfChanges, diagnostics: diagnostics)));

            // Assert.
            Assert.Contains(expected, result);
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void Format_FormatsDiagnosticsAndUnsupportedChangesAndPotentialChanges()
        {
            var whatIfChanges = new List<WhatIfChange>
            {
                new WhatIfChange
                {
                    ResourceId = "/subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/rg1/providers/p0/foo",
                    ChangeType = ChangeType.Unsupported,
                    UnsupportedReason = "Unable to determine the source."
                }
            };

            var potentialChanges = new List<WhatIfChange>
            {
                new WhatIfChange
                {
                    ResourceId = "/subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/rg1/providers/p0/foo2",
                    ChangeType = ChangeType.Create,
                    UnsupportedReason = "Unable to determine the source."
                }
            };

            var diagnostics = new List<DeploymentDiagnosticsDefinition>
            {
                new DeploymentDiagnosticsDefinition("Warning", "Code", "Nested Deployment Skipped.", "resource1")
            };

            string expected = $@"Resource and property changes are indicated with these symbols:
  [38;5;77m+[0m Create
  [38;5;246mx[0m Unsupported

The deployment will update the following scope:

Scope: /subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/rg1
[38;5;246m
  x p0/foo
[0m
Resource changes: 1 unsupported.


The following change MAY OR MAY NOT be deployed to the following scope:

Scope: /subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/rg1
[38;5;77m
  + p0/foo2
[0m
Potential changes: 1 to create.

Diagnostics (2): 
[38;5;136m(resource1) Nested Deployment Skipped. (Code)
[0m[38;5;136m(/subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/rg1/providers/p0/foo) Unable to determine the source. (Unsupported)
[0m".Replace("\r\n", Environment.NewLine);

            // Act.
            string result = WhatIfOperationResultFormatter.Format(
                new PSWhatIfOperationResult(new WhatIfOperationResult(changes: whatIfChanges, potentialChanges: potentialChanges, diagnostics: diagnostics)));

            // Assert.
            Assert.Contains(expected, result);
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void Format_FormatsDiagnostics()
        {
            var diagnostics = new List<DeploymentDiagnosticsDefinition>
            {
                new DeploymentDiagnosticsDefinition("Warning", "Code", "Nested Deployment Skipped.", "resource1")
            };

            string expected = $@"Diagnostics (1): 
{Color.DarkYellow}(resource1) Nested Deployment Skipped. (Code)
{Color.Reset}"
            .Replace("\r\n", Environment.NewLine); 

            // Act.
            string result = WhatIfOperationResultFormatter.Format(
                new PSWhatIfOperationResult(new WhatIfOperationResult(diagnostics: diagnostics)));

            // Assert.
            Assert.Contains(expected, result);
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void Format_FormatsUnsupportedChanges()
        {
            var whatIfChanges = new List<WhatIfChange>
            {
                new WhatIfChange
                {
                    ResourceId = "/subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/rg1/providers/p0/foo",
                    ChangeType = ChangeType.Unsupported,
                    UnsupportedReason = "Unable to determine the source."
                }
            };

            string expected = $@"Diagnostics (1): 
{Color.DarkYellow}(/subscriptions/00000000-0000-0000-0000-000000000001/resourceGroups/rg1/providers/p0/foo) Unable to determine the source. (Unsupported)
{Color.Reset}"
            .Replace("\r\n", Environment.NewLine);

            // Act.
            string result = WhatIfOperationResultFormatter.Format(
                new PSWhatIfOperationResult(new WhatIfOperationResult(changes: whatIfChanges)));

            // Assert.
            Assert.Contains(expected, result);
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void Format_nested_array_changes_does_not_throw()
        {
            // Arrange.
            var whatIfChanges = new List<WhatIfChange>
            {
                new WhatIfChange
                {
                    ResourceId = "/subscriptions/00000000-0000-0000-0000-000000000004/resourceGroups/rg4/providers/Microsoft.DocumentDB/databaseAccounts/myaccount/sqlDatabases/accesscontrol/containers/workflows",
                    ChangeType = ChangeType.Modify,
                    Delta = new List<WhatIfPropertyChange>
                    {
                        new WhatIfPropertyChange
                        {
                            Path = "properties.resource.indexingPolicy.compositeIndexes",
                            PropertyChangeType = PropertyChangeType.Array,
                            Children = new List<WhatIfPropertyChange>
                            {
                                new WhatIfPropertyChange
                                {
                                    Path = "0",
                                    PropertyChangeType = PropertyChangeType.Modify,
                                    Children = new List<WhatIfPropertyChange>
                                    {
                                        new WhatIfPropertyChange
                                        {
                                            Path = null,
                                            PropertyChangeType = PropertyChangeType.Array,
                                            Children = new List<WhatIfPropertyChange>
                                            {
                                                new WhatIfPropertyChange
                                                {
                                                    Path = "0",
                                                    PropertyChangeType = PropertyChangeType.Modify,
                                                    Children = new List<WhatIfPropertyChange>
                                                    {
                                                        new WhatIfPropertyChange
                                                        {
                                                            Path = "order",
                                                            PropertyChangeType = PropertyChangeType.Delete,
                                                            Before = "ascending",
                                                        }
                                                    }
                                                },
                                                new WhatIfPropertyChange
                                                {
                                                    Path = "1",
                                                    PropertyChangeType = PropertyChangeType.Modify,
                                                    Children = new List<WhatIfPropertyChange>
                                                    {
                                                        new WhatIfPropertyChange
                                                        {
                                                            Path = "order",
                                                            PropertyChangeType = PropertyChangeType.Delete,
                                                            Before = "ascending",
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        },
                    }
                }
            };

            string expected = $@"
Scope: /subscriptions/00000000-0000-0000-0000-000000000004/resourceGroups/rg4
{Color.Purple}
  ~ Microsoft.DocumentDB/databaseAccounts/myaccount/sqlDatabases/accesscontrol/containers/workflows{Color.Reset}
    {Color.Purple}~{Color.Reset} properties.resource.indexingPolicy.compositeIndexes{Color.Reset}:{Color.Reset} [
      {Color.Purple}~{Color.Reset} 0{Color.Reset}:{Color.Reset}

        [
        {Color.Purple}~{Color.Reset} 0{Color.Reset}:{Color.Reset}

          {Color.Orange}-{Color.Reset} order{Color.Reset}:{Color.Reset} {Color.Orange}""ascending""{Color.Reset}

        {Color.Purple}~{Color.Reset} 1{Color.Reset}:{Color.Reset}

          {Color.Orange}-{Color.Reset} order{Color.Reset}:{Color.Reset} {Color.Orange}""ascending""{Color.Reset}

        ]

      ]
".Replace("\r\n", Environment.NewLine);

            // Act.
            string result = WhatIfOperationResultFormatter.Format(
                new PSWhatIfOperationResult(new WhatIfOperationResult(changes: whatIfChanges)));

            // Assert.
            Assert.Contains(expected, result);
        }
    }
}

