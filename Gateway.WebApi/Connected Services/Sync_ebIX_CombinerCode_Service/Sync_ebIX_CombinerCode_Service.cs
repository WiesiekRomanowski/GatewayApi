﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gateway.WebApi.Sync_ebIX_CombinerCode_Service
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://sos.energa.pl/osd/sos/kmd/ebIX_CombinerCode", ConfigurationName="Gateway.WebApi.Sync_ebIX_CombinerCode_Service.ebIX_CombinerCode_PortType")]
    public interface ebIX_CombinerCode_PortType
    {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MessageResponse_Type))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MessageRequest_Type))]
        System.Threading.Tasks.Task CreateAsync(Gateway.WebApi.Sync_ebIX_CombinerCode_Service.Create_input request);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="NotifyRequestMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MessageResponse_Type))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MessageRequest_Type))]
        System.Threading.Tasks.Task NotifyAsync(Gateway.WebApi.Sync_ebIX_CombinerCode_Service.Notify_input request);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="RejectRequestMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MessageResponse_Type))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MessageRequest_Type))]
        System.Threading.Tasks.Task RejectAsync(Gateway.WebApi.Sync_ebIX_CombinerCode_Service.Reject_input request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sos.energa.pl/osd/sos/kmd/ebIX_CombinerCode/Create/xsd")]
    public partial class CreateRequest_Type : MessageRequest_Type
    {
        
        private DataArea_Type dataAreaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public DataArea_Type DataArea
        {
            get
            {
                return this.dataAreaField;
            }
            set
            {
                this.dataAreaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sos.energa.pl/osd/sos/kmd/ebIX_CombinerCode/Create/xsd")]
    public partial class DataArea_Type
    {
        
        private CreateRequest createRequestField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public CreateRequest CreateRequest
        {
            get
            {
                return this.createRequestField;
            }
            set
            {
                this.createRequestField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://energa.pl/sos/eop/service/ebIX_CombinerCode")]
    public partial class CreateRequest
    {
        
        private Header headerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Header header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://energa.pl/sos/eop/service/ebIX_CombinerCodeCreateRequest")]
    public partial class Header
    {
        
        private string balanceSupplierNoField;
        
        private string documentBusinessIdentificatorField;
        
        private string[] meteringPointComponentField;
        
        private Party partyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string balanceSupplierNo
        {
            get
            {
                return this.balanceSupplierNoField;
            }
            set
            {
                this.balanceSupplierNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string documentBusinessIdentificator
        {
            get
            {
                return this.documentBusinessIdentificatorField;
            }
            set
            {
                this.documentBusinessIdentificatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("mpComponentNumber", IsNullable=false)]
        public string[] meteringPointComponent
        {
            get
            {
                return this.meteringPointComponentField;
            }
            set
            {
                this.meteringPointComponentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public Party party
        {
            get
            {
                return this.partyField;
            }
            set
            {
                this.partyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://energa.pl/sos/eop/service/ebIX_CombinerCodeCreateRequest")]
    public partial class Party
    {
        
        private string partyIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string partyID
        {
            get
            {
                return this.partyIDField;
            }
            set
            {
                this.partyIDField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="Header", Namespace="http://energa.pl/sos/eop/service/ebIX_CombinerCodeRejectRequest")]
    public partial class Header2
    {
        
        private RejectionReasonDict rejectionReasonField;
        
        private string rejectionReasonDescriptionField;
        
        private string documentBusinessIdentificatorField;
        
        private string referenceDocumentBusinessIdentificatorField;
        
        private string balanceSupplierNoField;
        
        private string[] meteringPointComponentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public RejectionReasonDict rejectionReason
        {
            get
            {
                return this.rejectionReasonField;
            }
            set
            {
                this.rejectionReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string rejectionReasonDescription
        {
            get
            {
                return this.rejectionReasonDescriptionField;
            }
            set
            {
                this.rejectionReasonDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string documentBusinessIdentificator
        {
            get
            {
                return this.documentBusinessIdentificatorField;
            }
            set
            {
                this.documentBusinessIdentificatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string referenceDocumentBusinessIdentificator
        {
            get
            {
                return this.referenceDocumentBusinessIdentificatorField;
            }
            set
            {
                this.referenceDocumentBusinessIdentificatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string balanceSupplierNo
        {
            get
            {
                return this.balanceSupplierNoField;
            }
            set
            {
                this.balanceSupplierNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("mpComponentNumber", IsNullable=false)]
        public string[] meteringPointComponent
        {
            get
            {
                return this.meteringPointComponentField;
            }
            set
            {
                this.meteringPointComponentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://energa.pl/sos/eop/service/ebIX_CombinerCodeRejectRequest")]
    public enum RejectionReasonDict
    {
        
        /// <remarks/>
        E10,
        
        /// <remarks/>
        E14,
        
        /// <remarks/>
        E16,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://energa.pl/sos/eop/service/ebIX_CombinerCode")]
    public partial class RejectRequest
    {
        
        private Header2 headerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Header2 header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="DataArea_Type", Namespace="http://sos.energa.pl/osd/sos/kmd/ebIX_CombinerCode/Reject/xsd")]
    public partial class DataArea_Type2
    {
        
        private RejectRequest rejectRequestField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public RejectRequest RejectRequest
        {
            get
            {
                return this.rejectRequestField;
            }
            set
            {
                this.rejectRequestField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://energa.pl/sos/eop/service/ebIX_CombinerCodeNotifyRequest")]
    public partial class MeteringPointCombiner
    {
        
        private string mpCombinerCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string mpCombinerCode
        {
            get
            {
                return this.mpCombinerCodeField;
            }
            set
            {
                this.mpCombinerCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="Header", Namespace="http://energa.pl/sos/eop/service/ebIX_CombinerCodeNotifyRequest")]
    public partial class Header1
    {
        
        private string balanceSupplierNoField;
        
        private string documentBusinessIdentificatorField;
        
        private string referenceDocumentBusinessIdentificatorField;
        
        private string[] meteringPointComponentField;
        
        private MeteringPointCombiner meteringPointCombinerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string balanceSupplierNo
        {
            get
            {
                return this.balanceSupplierNoField;
            }
            set
            {
                this.balanceSupplierNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string documentBusinessIdentificator
        {
            get
            {
                return this.documentBusinessIdentificatorField;
            }
            set
            {
                this.documentBusinessIdentificatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string referenceDocumentBusinessIdentificator
        {
            get
            {
                return this.referenceDocumentBusinessIdentificatorField;
            }
            set
            {
                this.referenceDocumentBusinessIdentificatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("mpComponentNumber", IsNullable=false)]
        public string[] meteringPointComponent
        {
            get
            {
                return this.meteringPointComponentField;
            }
            set
            {
                this.meteringPointComponentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public MeteringPointCombiner meteringPointCombiner
        {
            get
            {
                return this.meteringPointCombinerField;
            }
            set
            {
                this.meteringPointCombinerField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://energa.pl/sos/eop/service/ebIX_CombinerCode")]
    public partial class NotifyRequest
    {
        
        private Header1 headerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Header1 header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="DataArea_Type", Namespace="http://sos.energa.pl/osd/sos/kmd/ebIX_CombinerCode/Notify/xsd")]
    public partial class DataArea_Type1
    {
        
        private NotifyRequest notifyRequestField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public NotifyRequest NotifyRequest
        {
            get
            {
                return this.notifyRequestField;
            }
            set
            {
                this.notifyRequestField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ksd.energa.pl/xsd")]
    public partial class Reply_Type
    {
        
        private string replyCodeField;
        
        private string replyDescriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ReplyCode
        {
            get
            {
                return this.replyCodeField;
            }
            set
            {
                this.replyCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ReplyDescription
        {
            get
            {
                return this.replyDescriptionField;
            }
            set
            {
                this.replyDescriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RejectRequest_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NotifyRequest_Type))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ksd.energa.pl/xsd")]
    public partial class MessageResponse_Type
    {
        
        private ApplicationArea_Type applicationAreaField;
        
        private Reply_Type replyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ApplicationArea_Type ApplicationArea
        {
            get
            {
                return this.applicationAreaField;
            }
            set
            {
                this.applicationAreaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Reply_Type Reply
        {
            get
            {
                return this.replyField;
            }
            set
            {
                this.replyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ksd.energa.pl/xsd")]
    public partial class ApplicationArea_Type
    {
        
        private Sender_Type senderField;
        
        private System.DateTime creationDateTimeField;
        
        private string bODIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Sender_Type Sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime CreationDateTime
        {
            get
            {
                return this.creationDateTimeField;
            }
            set
            {
                this.creationDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string BODId
        {
            get
            {
                return this.bODIdField;
            }
            set
            {
                this.bODIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ksd.energa.pl/xsd")]
    public partial class Sender_Type
    {
        
        private string logicalIdField;
        
        private string componentField;
        
        private string taskField;
        
        private string referenceIdField;
        
        private string confirmationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string LogicalId
        {
            get
            {
                return this.logicalIdField;
            }
            set
            {
                this.logicalIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Component
        {
            get
            {
                return this.componentField;
            }
            set
            {
                this.componentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Task
        {
            get
            {
                return this.taskField;
            }
            set
            {
                this.taskField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string ReferenceId
        {
            get
            {
                return this.referenceIdField;
            }
            set
            {
                this.referenceIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Confirmation
        {
            get
            {
                return this.confirmationField;
            }
            set
            {
                this.confirmationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sos.energa.pl/osd/sos/kmd/ebIX_CombinerCode/Reject/xsd")]
    public partial class RejectRequest_Type : MessageResponse_Type
    {
        
        private DataArea_Type2 dataAreaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public DataArea_Type2 DataArea
        {
            get
            {
                return this.dataAreaField;
            }
            set
            {
                this.dataAreaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://sos.energa.pl/osd/sos/kmd/ebIX_CombinerCode/Notify/xsd")]
    public partial class NotifyRequest_Type : MessageResponse_Type
    {
        
        private DataArea_Type1 dataAreaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public DataArea_Type1 DataArea
        {
            get
            {
                return this.dataAreaField;
            }
            set
            {
                this.dataAreaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreateRequest_Type))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ksd.energa.pl/xsd")]
    public partial class MessageRequest_Type
    {
        
        private ApplicationArea_Type applicationAreaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ApplicationArea_Type ApplicationArea
        {
            get
            {
                return this.applicationAreaField;
            }
            set
            {
                this.applicationAreaField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Create_input
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sos.energa.pl/osd/sos/kmd/ebIX_CombinerCode/Create/xsd", Order=0)]
        public Gateway.WebApi.Sync_ebIX_CombinerCode_Service.CreateRequest_Type CreateRequestMessage;
        
        public Create_input()
        {
        }
        
        public Create_input(Gateway.WebApi.Sync_ebIX_CombinerCode_Service.CreateRequest_Type CreateRequestMessage)
        {
            this.CreateRequestMessage = CreateRequestMessage;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Notify_input
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sos.energa.pl/osd/sos/kmd/ebIX_CombinerCode/Notify/xsd", Order=0)]
        public Gateway.WebApi.Sync_ebIX_CombinerCode_Service.NotifyRequest_Type NotifyRequestMessage;
        
        public Notify_input()
        {
        }
        
        public Notify_input(Gateway.WebApi.Sync_ebIX_CombinerCode_Service.NotifyRequest_Type NotifyRequestMessage)
        {
            this.NotifyRequestMessage = NotifyRequestMessage;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Reject_input
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://sos.energa.pl/osd/sos/kmd/ebIX_CombinerCode/Reject/xsd", Order=0)]
        public Gateway.WebApi.Sync_ebIX_CombinerCode_Service.RejectRequest_Type RejectRequestMessage;
        
        public Reject_input()
        {
        }
        
        public Reject_input(Gateway.WebApi.Sync_ebIX_CombinerCode_Service.RejectRequest_Type RejectRequestMessage)
        {
            this.RejectRequestMessage = RejectRequestMessage;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    public interface ebIX_CombinerCode_PortTypeChannel : Gateway.WebApi.Sync_ebIX_CombinerCode_Service.ebIX_CombinerCode_PortType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "1.0.0")]
    public partial class ebIX_CombinerCode_PortTypeClient : System.ServiceModel.ClientBase<Gateway.WebApi.Sync_ebIX_CombinerCode_Service.ebIX_CombinerCode_PortType>, Gateway.WebApi.Sync_ebIX_CombinerCode_Service.ebIX_CombinerCode_PortType
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ebIX_CombinerCode_PortTypeClient() : 
                base(ebIX_CombinerCode_PortTypeClient.GetDefaultBinding(), ebIX_CombinerCode_PortTypeClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.ebIX_CombinerCode_HTTPSPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ebIX_CombinerCode_PortTypeClient(EndpointConfiguration endpointConfiguration) : 
                base(ebIX_CombinerCode_PortTypeClient.GetBindingForEndpoint(endpointConfiguration), ebIX_CombinerCode_PortTypeClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ebIX_CombinerCode_PortTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ebIX_CombinerCode_PortTypeClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ebIX_CombinerCode_PortTypeClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ebIX_CombinerCode_PortTypeClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ebIX_CombinerCode_PortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task Gateway.WebApi.Sync_ebIX_CombinerCode_Service.ebIX_CombinerCode_PortType.CreateAsync(Gateway.WebApi.Sync_ebIX_CombinerCode_Service.Create_input request)
        {
            return base.Channel.CreateAsync(request);
        }
        
        public System.Threading.Tasks.Task CreateAsync(Gateway.WebApi.Sync_ebIX_CombinerCode_Service.CreateRequest_Type CreateRequestMessage)
        {
            Gateway.WebApi.Sync_ebIX_CombinerCode_Service.Create_input inValue = new Gateway.WebApi.Sync_ebIX_CombinerCode_Service.Create_input();
            inValue.CreateRequestMessage = CreateRequestMessage;
            return ((Gateway.WebApi.Sync_ebIX_CombinerCode_Service.ebIX_CombinerCode_PortType)(this)).CreateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task Gateway.WebApi.Sync_ebIX_CombinerCode_Service.ebIX_CombinerCode_PortType.NotifyAsync(Gateway.WebApi.Sync_ebIX_CombinerCode_Service.Notify_input request)
        {
            return base.Channel.NotifyAsync(request);
        }
        
        public System.Threading.Tasks.Task NotifyAsync(Gateway.WebApi.Sync_ebIX_CombinerCode_Service.NotifyRequest_Type NotifyRequestMessage)
        {
            Gateway.WebApi.Sync_ebIX_CombinerCode_Service.Notify_input inValue = new Gateway.WebApi.Sync_ebIX_CombinerCode_Service.Notify_input();
            inValue.NotifyRequestMessage = NotifyRequestMessage;
            return ((Gateway.WebApi.Sync_ebIX_CombinerCode_Service.ebIX_CombinerCode_PortType)(this)).NotifyAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task Gateway.WebApi.Sync_ebIX_CombinerCode_Service.ebIX_CombinerCode_PortType.RejectAsync(Gateway.WebApi.Sync_ebIX_CombinerCode_Service.Reject_input request)
        {
            return base.Channel.RejectAsync(request);
        }
        
        public System.Threading.Tasks.Task RejectAsync(Gateway.WebApi.Sync_ebIX_CombinerCode_Service.RejectRequest_Type RejectRequestMessage)
        {
            Gateway.WebApi.Sync_ebIX_CombinerCode_Service.Reject_input inValue = new Gateway.WebApi.Sync_ebIX_CombinerCode_Service.Reject_input();
            inValue.RejectRequestMessage = RejectRequestMessage;
            return ((Gateway.WebApi.Sync_ebIX_CombinerCode_Service.ebIX_CombinerCode_PortType)(this)).RejectAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ebIX_CombinerCode_HTTPSPort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.ebIX_CombinerCode_HTTPSPort))
            {
                return new System.ServiceModel.EndpointAddress("http://ob-dev-i1.grupaenerga-ivmx.loc:7900/ws/sos/osd/async");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ebIX_CombinerCode_PortTypeClient.GetBindingForEndpoint(EndpointConfiguration.ebIX_CombinerCode_HTTPSPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ebIX_CombinerCode_PortTypeClient.GetEndpointAddress(EndpointConfiguration.ebIX_CombinerCode_HTTPSPort);
        }
        
        public enum EndpointConfiguration
        {
            
            ebIX_CombinerCode_HTTPSPort,
        }
    }
}
