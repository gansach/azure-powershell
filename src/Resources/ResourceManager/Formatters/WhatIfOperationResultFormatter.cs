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

namespace Microsoft.Azure.Commands.ResourceManager.Cmdlets.Formatters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using NewComparers;
    using NewExtensions;
    using Extensions;
    using Microsoft.Azure.Management.Resources.Models;
    using Microsoft.WindowsAzure.Commands.Utilities.Common;
    using Newtonsoft.Json.Linq;
    using Properties;
    using SdkModels.Deployments;

    public class WhatIfOperationResultFormatter : WhatIfJsonFormatter
    {
        public WhatIfOperationResultFormatter(ColoredStringBuilder builder)
            : base(builder)
        {
        }

        public static string Format(PSWhatIfOperationResult result)
        {
            if (result == null)
            {
                return null;
            }

            var builder = new ColoredStringBuilder();
            var formatter = new WhatIfOperationResultFormatter(builder);

            formatter.FormatNoiseNotice();
            formatter.FormatLegend(result.Changes, result.PotentialChanges);
            formatter.FormatResourceChanges(result.Changes, true);
            formatter.FormatStats(result.Changes, true);
            formatter.FormatResourceChanges(result.PotentialChanges, false);
            formatter.FormatStats(result.PotentialChanges, false);
            formatter.FormatDiagnostics(result.Diagnostics, result.Changes, result.PotentialChanges);

            return builder.ToString();
        }

        private void FormatNoiseNotice()
        {
            this.Builder
                .AppendLine(Resources.WhatIfNoiseNotice)
                .AppendLine();
        }

        private static int GetMaxPathLength(IList<PSWhatIfPropertyChange> propertyChanges)
        {
            if (propertyChanges == null)
            {
                return 0;
            }

            return propertyChanges
                .Where(ShouldConsiderPathLength)
                .Select(pc => pc.Path.Length)
                .DefaultIfEmpty()
                .Max();
        }

        private static bool ShouldConsiderPathLength(PSWhatIfPropertyChange propertyChange)
        {
            switch (propertyChange.PropertyChangeType)
            {
                case PropertyChangeType.Create:
                case PropertyChangeType.NoEffect:
                    return propertyChange.After.IsLeaf();

                case PropertyChangeType.Delete:
                case PropertyChangeType.Modify:
                    return propertyChange.Before.IsLeaf();

                default:
                    return propertyChange.Children == null || propertyChange.Children.Count == 0;
            }
        }

        private void FormatStats(IList<PSWhatIfChange> resourceChanges, bool definiteChanges)
        {
            if (definiteChanges)
            {
                this.Builder.AppendLine().Append("Resource changes: ");
            }
            else if (resourceChanges != null && resourceChanges.Count != 0)
            {
                this.Builder.AppendLine().Append("Potential changes: ");
            } else
            {
                return;
            }

            if (resourceChanges == null || resourceChanges.Count == 0)
            {
                this.Builder.Append("no change");
            }
            else
            {
                IEnumerable<string> stats = resourceChanges
                    .OrderBy(rc => rc.ChangeType, new ChangeTypeComparer())
                    .GroupBy(rc => rc.ChangeType)
                    .Select(g => new { ChangeType = g.Key, Count = g.Count() })
                    .Where(x => x.Count != 0)
                    .Select(x => this.FormatChangeTypeCount(x.ChangeType, x.Count));

                this.Builder.Append(string.Join(", ", stats));
            }

            this.Builder.Append(".");
        }

        public void FormatDiagnostics(IList<DeploymentDiagnosticsDefinition> diagnostics, IList<PSWhatIfChange> changes, IList<PSWhatIfChange> potentialChanges)
        {
            if (changes != null)
            {
                var unsupportedChanges = changes
                    .Where(c => c.ChangeType == ChangeType.Unsupported)
                    .ToList();

                if (diagnostics == null)
                {
                    diagnostics = new List<DeploymentDiagnosticsDefinition>();
                }
                foreach (var change in unsupportedChanges)
                {
                    diagnostics.Add(new DeploymentDiagnosticsDefinition(level: Level.Warning, code: "Unsupported", message: change.UnsupportedReason, target: change.FullyQualifiedResourceId));
                }
            }

            if (potentialChanges != null)
            {
                var unsupportedChanges = potentialChanges
                    .Where(c => c.ChangeType == ChangeType.Unsupported)
                    .ToList();

                if (diagnostics == null)
                {
                    diagnostics = new List<DeploymentDiagnosticsDefinition>();
                }
                foreach (var change in unsupportedChanges)
                {
                    diagnostics.Add(new DeploymentDiagnosticsDefinition(level: Level.Warning, code: "Unsupported", message: change.UnsupportedReason, target: change.FullyQualifiedResourceId));
                }
            }


            if (diagnostics == null || diagnostics.Count == 0)
            {
                return;
            }

            this.Builder.AppendLine().AppendLine();

            this.Builder.Append($"Diagnostics ({diagnostics.Count}): ").AppendLine();
            
            diagnostics.ForEach(d =>
            {
                using (this.Builder.NewColorScope(DiagnosticExtensions.ToColor(d.Level)))
                {
                    this.Builder.Append($"({d.Target})").Append(Symbol.WhiteSpace);
                    this.Builder.Append(d.Message).Append(Symbol.WhiteSpace);
                    this.Builder.Append($"({d.Code})");
                    this.Builder.AppendLine();
                }
            });
        }

        private string FormatChangeTypeCount(ChangeType changeType, int count)
        {
            switch (changeType)
            {
                case ChangeType.Create:
                    return $"{count} to create";
                case ChangeType.Delete:
                    return $"{count} to delete";
                case ChangeType.Deploy:
                    return $"{count} to deploy";
                case ChangeType.Modify:
                    return $"{count} to modify";
                case ChangeType.Ignore:
                    return $"{count} to ignore";
                case ChangeType.NoChange:
                    return $"{count} no change";
                case ChangeType.Unsupported:
                    return $"{count} unsupported";
                default:
                    throw new ArgumentOutOfRangeException(nameof(changeType), changeType, null);
            }
        }

        private void FormatLegend(IList<PSWhatIfChange> changes, IList<PSWhatIfChange> potentialChanges)
        {
            var resourceChanges = changes ?? new List<PSWhatIfChange>();

            if (potentialChanges != null && potentialChanges.Count > 0)
            {
                resourceChanges = resourceChanges.Concat(potentialChanges).ToList();
            }

            if (resourceChanges == null || resourceChanges.Count == 0)
            {
                return;
            }
            var psChangeTypeSet = new HashSet<PSChangeType>();

            void PopulateChangeTypeSet(IList<PSWhatIfPropertyChange> propertyChanges)
            {
                propertyChanges?.ForEach(propertyChange =>
                {
                    psChangeTypeSet.Add(propertyChange.PropertyChangeType.ToPSChangeType());
                    PopulateChangeTypeSet(propertyChange.Children);
                });
            }

            foreach (PSWhatIfChange resourceChange in resourceChanges)
            {
                psChangeTypeSet.Add(resourceChange.ChangeType.ToPSChangeType());
                PopulateChangeTypeSet(resourceChange.Delta);
            }

            this.Builder
                .Append("Resource and property changes are indicated with ")
                .AppendLine(psChangeTypeSet.Count == 1 ? "this symbol:" : "these symbols:");

            psChangeTypeSet
                .OrderBy(x => x, new PSChangeTypeComparer())
                .ForEach(x => this.Builder
                    .Append(Indent())
                    .Append(x.ToSymbol(), x.ToColor())
                    .Append(Symbol.WhiteSpace)
                    .Append(x)
                    .AppendLine());
        }

        private void FormatResourceChanges(IList<PSWhatIfChange> resourceChanges, bool definiteChanges)
        {
            if (resourceChanges == null || resourceChanges.Count == 0)
            {
                return;
            }

            int scopeCount = resourceChanges.Select(rc => rc.Scope.ToUpperInvariant()).Distinct().Count();

            if (definiteChanges)
            {
                this.Builder
                    .AppendLine()
                    .Append("The deployment will update the following ")
                    .AppendLine(scopeCount == 1 ? "scope:" : "scopes:");
            } else
            {
                this.Builder
                    .AppendLine()
                    .AppendLine()
                    .AppendLine()
                    .Append("The following change MAY OR MAY NOT be deployed to the following ")
                    .AppendLine(scopeCount == 1 ? "scope:" : "scopes:");
            }

            

            resourceChanges
                .OrderBy(rc => rc.Scope.ToUpperInvariant())
                .GroupBy(rc => rc.Scope.ToUpperInvariant())
                .ToDictionary(g => g.Key, g => g.ToList())
                .ForEach(kvp => FormatResourceChangesInScope(kvp.Value[0].Scope, kvp.Value));
        }

        private void FormatResourceChangesInScope(string scope, IList<PSWhatIfChange> resourceChanges)
        {
            // Scope.
            this.Builder
                .AppendLine()
                .AppendLine($"Scope: {scope}");

            // Resource changes.
            List<PSWhatIfChange> sortedResourceChanges = resourceChanges
                .OrderBy(rc => rc.ChangeType, new ChangeTypeComparer())
                .ThenBy(rc => rc.RelativeResourceId)
                .ToList();

            sortedResourceChanges
                .GroupBy(rc => rc.ChangeType)
                .ToDictionary(g => g.Key, g => g.ToList())
                .ForEach(kvp =>
                {
                    using (this.Builder.NewColorScope(kvp.Key.ToColor()))
                    {
                        kvp.Value.ForEach(rc => this.FormatResourceChange(rc, rc == sortedResourceChanges.Last()));
                    }
                });
        }

        private void FormatResourceChange(PSWhatIfChange resourceChange, bool isLast)
        {
            this.Builder.AppendLine();
            this.FormatResourceChangePath(
                resourceChange.ChangeType,
                resourceChange.RelativeResourceId,
                resourceChange.ApiVersion);

            switch (resourceChange.ChangeType)
            {
                case ChangeType.Create when resourceChange.After != null:
                    this.FormatJson(resourceChange.After, indentLevel: 2);

                    return;

                case ChangeType.Delete when resourceChange.Before != null:
                    this.FormatJson(resourceChange.Before, indentLevel: 2);

                    return;

                default:
                    if (resourceChange.Delta?.Count > 0)
                    {
                        using (this.Builder.NewColorScope(Color.Reset))
                        {
                            IList<PSWhatIfPropertyChange> propertyChanges = resourceChange.Delta
                                .OrderBy(pc => pc.PropertyChangeType, new PropertyChangeTypeComparer())
                                .ThenBy(pc => pc.Path)
                                .ToList();

                            this.Builder.AppendLine();
                            this.FormatPropertyChanges(propertyChanges);
                        }

                        return;
                    }

                    if (isLast)
                    {
                        this.Builder.AppendLine();
                    }

                    return;
            }
        }

        private void FormatResourceChangePath(ChangeType changeType, string relativeResourceId, string apiVersion)
        {
            this.FormatPath(
                relativeResourceId,
                0,
                1,
                () => this.Builder.Append(changeType.ToSymbol()).Append(Symbol.WhiteSpace),
                () => this.FormatResourceChangeApiVersion(apiVersion));
        }

        private void FormatResourceChangeApiVersion(string apiVersion)
        {
            if (string.IsNullOrEmpty(apiVersion))
            {
                return;
            }

            using (this.Builder.NewColorScope(Color.Reset))
            {
                this.Builder
                    .Append(Symbol.WhiteSpace)
                    .Append(Symbol.LeftSquareBracket)
                    .Append(apiVersion)
                    .Append(Symbol.RightSquareBracket);
            }
        }

        private void FormatPropertyChanges(IList<PSWhatIfPropertyChange> propertyChanges, int indentLevel = 2)
        {
            int maxPathLength = GetMaxPathLength(propertyChanges);
            propertyChanges.ForEach(pc =>
            {
                this.FormatPropertyChange(pc, maxPathLength, indentLevel);
                this.Builder.AppendLine();
            });
        }

        private void FormatPropertyChange(PSWhatIfPropertyChange propertyChange, int maxPathLength, int indentLevel)
        {
            //this.FormatHead(propertyChange, maxPathLength, indentLevel);

            PropertyChangeType propertyChangeType = propertyChange.PropertyChangeType;
            string path = propertyChange.Path;
            JToken before = propertyChange.Before;
            JToken after = propertyChange.After;
            IList<PSWhatIfPropertyChange> children = propertyChange.Children;

            switch (propertyChange.PropertyChangeType)
            {
                case PropertyChangeType.Create:
                    this.FormatPropertyChangePath(propertyChangeType, path, after, children, maxPathLength, indentLevel);
                    this.FormatPropertyCreate(after, indentLevel + 1);
                    break;

                case PropertyChangeType.Delete:
                    this.FormatPropertyChangePath(propertyChangeType, path, before, children, maxPathLength, indentLevel);
                    this.FormatPropertyDelete(before, indentLevel + 1);
                    break;

                case PropertyChangeType.Modify:
                    this.FormatPropertyChangePath(propertyChangeType, path, before, children, maxPathLength, indentLevel);
                    this.FormatPropertyModify(propertyChange, indentLevel + 1);
                    break;

                case PropertyChangeType.Array:
                    this.FormatPropertyChangePath(propertyChangeType, path, null, children, maxPathLength, indentLevel);
                    this.FormatPropertyArrayChange(propertyChange, propertyChange.Children, indentLevel + 1);
                    break;

                case PropertyChangeType.NoEffect:
                    this.FormatPropertyChangePath(propertyChangeType, path, after, children, maxPathLength, indentLevel);
                    this.FormatPropertyNoEffect(after, indentLevel + 1);
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void FormatPropertyChangePath(
            PropertyChangeType propertyChangeType,
            string path,
            JToken valueAfterPath,
            IList<PSWhatIfPropertyChange> children,
            int maxPathLength,
            int indentLevel)
        {
            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            int paddingWidth = maxPathLength - path.Length + 1;
            bool hasChildren = children != null && children.Count > 0;

            if (valueAfterPath.IsNonEmptyArray() || (propertyChangeType == PropertyChangeType.Array && hasChildren))
            {
                paddingWidth = 1;
            }
            if (valueAfterPath.IsNonEmptyObject())
            {
                paddingWidth = 0;
            }
            if (propertyChangeType == PropertyChangeType.Modify && hasChildren)
            {
                paddingWidth = 0;
            }

            this.FormatPath(
                path,
                paddingWidth,
                indentLevel,
                () => this.FormatPropertyChangeType(propertyChangeType),
                this.FormatColon);
        }

        private void FormatPropertyChangeType(PropertyChangeType propertyChangeType)
        {
            this.Builder
                .Append(propertyChangeType.ToSymbol(), propertyChangeType.ToColor())
                .Append(Symbol.WhiteSpace);
        }

        private void FormatPropertyCreate(JToken value, int indentLevel)
        {
            using (this.Builder.NewColorScope(Color.Green))
            {
                this.FormatJson(value, indentLevel: indentLevel);
            }
        }

        private void FormatPropertyDelete(JToken value, int indentLevel)
        {
            using (this.Builder.NewColorScope(Color.Orange))
            {
                this.FormatJson(value, indentLevel: indentLevel);
            }
        }

        private void FormatPropertyModify(PSWhatIfPropertyChange propertyChange, int indentLevel)
        {
            if (propertyChange.Children != null)
            {
                // Has nested changes.
                this.Builder.AppendLine().AppendLine();
                this.FormatPropertyChanges(propertyChange.Children
                        .OrderBy(pc => pc.PropertyChangeType, new PropertyChangeTypeComparer())
                        .ThenBy(pc => pc.Path)
                        .ToList(),
                    indentLevel);
            }
            else
            {
                JToken before = propertyChange.Before;
                JToken after = propertyChange.After;

                // The before value.
                this.FormatPropertyDelete(before, indentLevel);

                // Space before =>
                if (before.IsNonEmptyObject())
                {
                    this.Builder
                        .AppendLine()
                        .Append(Indent(indentLevel));
                }
                else
                {
                    this.Builder.Append(Symbol.WhiteSpace);
                }

                // =>
                this.Builder.Append("=>");

                // Space after =>
                if (!after.IsNonEmptyObject())
                {
                    this.Builder.Append(Symbol.WhiteSpace);
                }

                // The after value.
                this.FormatPropertyCreate(after, indentLevel);

                if (!before.IsLeaf() && after.IsLeaf())
                {
                    this.Builder.AppendLine();
                }
            }
        }

        private void FormatPropertyArrayChange(PSWhatIfPropertyChange parentPropertyChange, IList<PSWhatIfPropertyChange> propertyChanges, int indentLevel)
        {
            if (string.IsNullOrEmpty(parentPropertyChange.Path))
            {
                // The parent change doesn't have a path, which means the current
                // array change is a nested change. We need to decrease indent_level
                // and print indentation before printing "[".
                indentLevel--;
                FormatIndent(indentLevel);
            }

            if (propertyChanges.Count == 0)
            {
                this.Builder.AppendLine("[]");
                return;
            }

            // [
            this.Builder
                .Append(Symbol.LeftSquareBracket)
                .AppendLine();

            this.FormatPropertyChanges(propertyChanges
                    .OrderBy(pc => int.Parse(pc.Path))
                    .ThenBy(pc => pc.PropertyChangeType, new PropertyChangeTypeComparer())
                    .ToList(),
                indentLevel);

            // ]
            this.Builder
                .Append(Indent(indentLevel))
                .Append(Symbol.RightSquareBracket);
        }

        private void FormatPropertyNoEffect(JToken value, int indentLevel)
        {
            using (this.Builder.NewColorScope(Color.Gray))
            {
                this.FormatJson(value, indentLevel: indentLevel);
            }
        }
    }
}

