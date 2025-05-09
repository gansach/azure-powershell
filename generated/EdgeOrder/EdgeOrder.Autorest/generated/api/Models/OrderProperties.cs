// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Extensions;

    /// <summary>Represents order details.</summary>
    public partial class OrderProperties :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderProperties,
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderPropertiesInternal
    {

        /// <summary>Backing field for <see cref="CurrentStage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IStageDetails _currentStage;

        /// <summary>Order current status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IStageDetails CurrentStage { get => (this._currentStage = this._currentStage ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.StageDetails()); }

        /// <summary>Display name of the resource stage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public string CurrentStageDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IStageDetailsInternal)CurrentStage).DisplayName; }

        /// <summary>Stage name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public string CurrentStageName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IStageDetailsInternal)CurrentStage).StageName; }

        /// <summary>Stage start time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public global::System.DateTime? CurrentStageStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IStageDetailsInternal)CurrentStage).StartTime; }

        /// <summary>Stage status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Inlined)]
        public string CurrentStageStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IStageDetailsInternal)CurrentStage).StageStatus; }

        /// <summary>Internal Acessors for CurrentStage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IStageDetails Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderPropertiesInternal.CurrentStage { get => (this._currentStage = this._currentStage ?? new Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.StageDetails()); set { {_currentStage = value;} } }

        /// <summary>Internal Acessors for CurrentStageDisplayName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderPropertiesInternal.CurrentStageDisplayName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IStageDetailsInternal)CurrentStage).DisplayName; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IStageDetailsInternal)CurrentStage).DisplayName = value; }

        /// <summary>Internal Acessors for CurrentStageName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderPropertiesInternal.CurrentStageName { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IStageDetailsInternal)CurrentStage).StageName; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IStageDetailsInternal)CurrentStage).StageName = value; }

        /// <summary>Internal Acessors for CurrentStageStartTime</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderPropertiesInternal.CurrentStageStartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IStageDetailsInternal)CurrentStage).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IStageDetailsInternal)CurrentStage).StartTime = value; }

        /// <summary>Internal Acessors for CurrentStageStatus</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderPropertiesInternal.CurrentStageStatus { get => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IStageDetailsInternal)CurrentStage).StageStatus; set => ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IStageDetailsInternal)CurrentStage).StageStatus = value; }

        /// <summary>Internal Acessors for OrderItemId</summary>
        System.Collections.Generic.List<string> Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderPropertiesInternal.OrderItemId { get => this._orderItemId; set { {_orderItemId = value;} } }

        /// <summary>Internal Acessors for OrderStageHistory</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IStageDetails> Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IOrderPropertiesInternal.OrderStageHistory { get => this._orderStageHistory; set { {_orderStageHistory = value;} } }

        /// <summary>Backing field for <see cref="OrderItemId" /> property.</summary>
        private System.Collections.Generic.List<string> _orderItemId;

        /// <summary>List of order item ARM Ids which are part of an order.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> OrderItemId { get => this._orderItemId; }

        /// <summary>Backing field for <see cref="OrderStageHistory" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IStageDetails> _orderStageHistory;

        /// <summary>Order status history.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Origin(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IStageDetails> OrderStageHistory { get => this._orderStageHistory; }

        /// <summary>Creates an new <see cref="OrderProperties" /> instance.</summary>
        public OrderProperties()
        {

        }
    }
    /// Represents order details.
    public partial interface IOrderProperties :
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.IJsonSerializable
    {
        /// <summary>Display name of the resource stage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Display name of the resource stage.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string CurrentStageDisplayName { get;  }
        /// <summary>Stage name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Stage name",
        SerializedName = @"stageName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PSArgumentCompleterAttribute("Placed", "InReview", "Confirmed", "ReadyToShip", "Shipped", "Delivered", "InUse", "ReturnInitiated", "ReturnPickedUp", "ReturnedToMicrosoft", "ReturnCompleted", "Cancelled")]
        string CurrentStageName { get;  }
        /// <summary>Stage start time</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Stage start time",
        SerializedName = @"startTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CurrentStageStartTime { get;  }
        /// <summary>Stage status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Stage status.",
        SerializedName = @"stageStatus",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PSArgumentCompleterAttribute("None", "InProgress", "Succeeded", "Failed", "Cancelled", "Cancelling")]
        string CurrentStageStatus { get;  }
        /// <summary>List of order item ARM Ids which are part of an order.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"List of order item ARM Ids which are part of an order.",
        SerializedName = @"orderItemIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> OrderItemId { get;  }
        /// <summary>Order status history.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Order status history.",
        SerializedName = @"orderStageHistory",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IStageDetails) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IStageDetails> OrderStageHistory { get;  }

    }
    /// Represents order details.
    internal partial interface IOrderPropertiesInternal

    {
        /// <summary>Order current status.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IStageDetails CurrentStage { get; set; }
        /// <summary>Display name of the resource stage.</summary>
        string CurrentStageDisplayName { get; set; }
        /// <summary>Stage name</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PSArgumentCompleterAttribute("Placed", "InReview", "Confirmed", "ReadyToShip", "Shipped", "Delivered", "InUse", "ReturnInitiated", "ReturnPickedUp", "ReturnedToMicrosoft", "ReturnCompleted", "Cancelled")]
        string CurrentStageName { get; set; }
        /// <summary>Stage start time</summary>
        global::System.DateTime? CurrentStageStartTime { get; set; }
        /// <summary>Stage status.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.PSArgumentCompleterAttribute("None", "InProgress", "Succeeded", "Failed", "Cancelled", "Cancelling")]
        string CurrentStageStatus { get; set; }
        /// <summary>List of order item ARM Ids which are part of an order.</summary>
        System.Collections.Generic.List<string> OrderItemId { get; set; }
        /// <summary>Order status history.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.IStageDetails> OrderStageHistory { get; set; }

    }
}