﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PendingLeaveRequest
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", ConfigurationName="PendingLeaveRequest.pendingleaverequest_Port")]
    public interface pendingleaverequest_Port
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/pendingleaverequest:Read", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<PendingLeaveRequest.Read_Result> ReadAsync(PendingLeaveRequest.Read request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/pendingleaverequest:ReadByRecId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<PendingLeaveRequest.ReadByRecId_Result> ReadByRecIdAsync(PendingLeaveRequest.ReadByRecId request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/pendingleaverequest:ReadMultiple", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<PendingLeaveRequest.ReadMultiple_Result> ReadMultipleAsync(PendingLeaveRequest.ReadMultiple request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/pendingleaverequest:IsUpdated", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<PendingLeaveRequest.IsUpdated_Result> IsUpdatedAsync(PendingLeaveRequest.IsUpdated request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/pendingleaverequest:GetRecIdFromKey", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<PendingLeaveRequest.GetRecIdFromKey_Result> GetRecIdFromKeyAsync(PendingLeaveRequest.GetRecIdFromKey request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest")]
    public partial class pendingleaverequest
    {
        
        private string keyField;
        
        private string employee_NoField;
        
        private string full_NameField;
        
        private string recommender_NameField;
        
        private string leave_Type_CodeField;
        
        private string leave_DescriptionField;
        
        private Leave_Type leave_TypeField;
        
        private bool leave_TypeFieldSpecified;
        
        private string work_Shift_DescriptionField;
        
        private System.DateTime requested_DateField;
        
        private bool requested_DateFieldSpecified;
        
        private System.DateTime leave_Start_DateField;
        
        private bool leave_Start_DateFieldSpecified;
        
        private System.DateTime leave_End_DateField;
        
        private bool leave_End_DateFieldSpecified;
        
        private System.DateTime leave_Start_TimeField;
        
        private bool leave_Start_TimeFieldSpecified;
        
        private System.DateTime leave_End_TimeField;
        
        private bool leave_End_TimeFieldSpecified;
        
        private string fiscal_YearField;
        
        private string remarksField;
        
        private bool approvedField;
        
        private bool approvedFieldSpecified;
        
        private System.DateTime approval_DateField;
        
        private bool approval_DateFieldSpecified;
        
        private string approval_CommentField;
        
        private bool rejectedField;
        
        private bool rejectedFieldSpecified;
        
        private System.DateTime reject_DateField;
        
        private bool reject_DateFieldSpecified;
        
        private string rejection_RemarksField;
        
        private Leave_Status leave_StatusField;
        
        private bool leave_StatusFieldSpecified;
        
        private string leave_Request_NoField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Employee_No
        {
            get
            {
                return this.employee_NoField;
            }
            set
            {
                this.employee_NoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Full_Name
        {
            get
            {
                return this.full_NameField;
            }
            set
            {
                this.full_NameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Recommender_Name
        {
            get
            {
                return this.recommender_NameField;
            }
            set
            {
                this.recommender_NameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Leave_Type_Code
        {
            get
            {
                return this.leave_Type_CodeField;
            }
            set
            {
                this.leave_Type_CodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Leave_Description
        {
            get
            {
                return this.leave_DescriptionField;
            }
            set
            {
                this.leave_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public Leave_Type Leave_Type
        {
            get
            {
                return this.leave_TypeField;
            }
            set
            {
                this.leave_TypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Leave_TypeSpecified
        {
            get
            {
                return this.leave_TypeFieldSpecified;
            }
            set
            {
                this.leave_TypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string Work_Shift_Description
        {
            get
            {
                return this.work_Shift_DescriptionField;
            }
            set
            {
                this.work_Shift_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=8)]
        public System.DateTime Requested_Date
        {
            get
            {
                return this.requested_DateField;
            }
            set
            {
                this.requested_DateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Requested_DateSpecified
        {
            get
            {
                return this.requested_DateFieldSpecified;
            }
            set
            {
                this.requested_DateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=9)]
        public System.DateTime Leave_Start_Date
        {
            get
            {
                return this.leave_Start_DateField;
            }
            set
            {
                this.leave_Start_DateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Leave_Start_DateSpecified
        {
            get
            {
                return this.leave_Start_DateFieldSpecified;
            }
            set
            {
                this.leave_Start_DateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=10)]
        public System.DateTime Leave_End_Date
        {
            get
            {
                return this.leave_End_DateField;
            }
            set
            {
                this.leave_End_DateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Leave_End_DateSpecified
        {
            get
            {
                return this.leave_End_DateFieldSpecified;
            }
            set
            {
                this.leave_End_DateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time", Order=11)]
        public System.DateTime Leave_Start_Time
        {
            get
            {
                return this.leave_Start_TimeField;
            }
            set
            {
                this.leave_Start_TimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Leave_Start_TimeSpecified
        {
            get
            {
                return this.leave_Start_TimeFieldSpecified;
            }
            set
            {
                this.leave_Start_TimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time", Order=12)]
        public System.DateTime Leave_End_Time
        {
            get
            {
                return this.leave_End_TimeField;
            }
            set
            {
                this.leave_End_TimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Leave_End_TimeSpecified
        {
            get
            {
                return this.leave_End_TimeFieldSpecified;
            }
            set
            {
                this.leave_End_TimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string Fiscal_Year
        {
            get
            {
                return this.fiscal_YearField;
            }
            set
            {
                this.fiscal_YearField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string Remarks
        {
            get
            {
                return this.remarksField;
            }
            set
            {
                this.remarksField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public bool Approved
        {
            get
            {
                return this.approvedField;
            }
            set
            {
                this.approvedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ApprovedSpecified
        {
            get
            {
                return this.approvedFieldSpecified;
            }
            set
            {
                this.approvedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=16)]
        public System.DateTime Approval_Date
        {
            get
            {
                return this.approval_DateField;
            }
            set
            {
                this.approval_DateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Approval_DateSpecified
        {
            get
            {
                return this.approval_DateFieldSpecified;
            }
            set
            {
                this.approval_DateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public string Approval_Comment
        {
            get
            {
                return this.approval_CommentField;
            }
            set
            {
                this.approval_CommentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public bool Rejected
        {
            get
            {
                return this.rejectedField;
            }
            set
            {
                this.rejectedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RejectedSpecified
        {
            get
            {
                return this.rejectedFieldSpecified;
            }
            set
            {
                this.rejectedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=19)]
        public System.DateTime Reject_Date
        {
            get
            {
                return this.reject_DateField;
            }
            set
            {
                this.reject_DateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Reject_DateSpecified
        {
            get
            {
                return this.reject_DateFieldSpecified;
            }
            set
            {
                this.reject_DateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public string Rejection_Remarks
        {
            get
            {
                return this.rejection_RemarksField;
            }
            set
            {
                this.rejection_RemarksField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public Leave_Status Leave_Status
        {
            get
            {
                return this.leave_StatusField;
            }
            set
            {
                this.leave_StatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Leave_StatusSpecified
        {
            get
            {
                return this.leave_StatusFieldSpecified;
            }
            set
            {
                this.leave_StatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=22)]
        public string Leave_Request_No
        {
            get
            {
                return this.leave_Request_NoField;
            }
            set
            {
                this.leave_Request_NoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest")]
    public enum Leave_Type
    {
        
        /// <remarks/>
        _blank_,
        
        /// <remarks/>
        First_Half_Leave,
        
        /// <remarks/>
        Second_Half_Leave,
        
        /// <remarks/>
        Full_Day_Leave,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest")]
    public enum Leave_Status
    {
        
        /// <remarks/>
        Pending,
        
        /// <remarks/>
        Verified,
        
        /// <remarks/>
        Recommended,
        
        /// <remarks/>
        Approved,
        
        /// <remarks/>
        Rejected,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest")]
    public partial class pendingleaverequest_Filter
    {
        
        private pendingleaverequest_Fields fieldField;
        
        private string criteriaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public pendingleaverequest_Fields Field
        {
            get
            {
                return this.fieldField;
            }
            set
            {
                this.fieldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Criteria
        {
            get
            {
                return this.criteriaField;
            }
            set
            {
                this.criteriaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest")]
    public enum pendingleaverequest_Fields
    {
        
        /// <remarks/>
        Employee_No,
        
        /// <remarks/>
        Full_Name,
        
        /// <remarks/>
        Recommender_Name,
        
        /// <remarks/>
        Leave_Type_Code,
        
        /// <remarks/>
        Leave_Description,
        
        /// <remarks/>
        Leave_Type,
        
        /// <remarks/>
        Work_Shift_Description,
        
        /// <remarks/>
        Requested_Date,
        
        /// <remarks/>
        Leave_Start_Date,
        
        /// <remarks/>
        Leave_End_Date,
        
        /// <remarks/>
        Leave_Start_Time,
        
        /// <remarks/>
        Leave_End_Time,
        
        /// <remarks/>
        Fiscal_Year,
        
        /// <remarks/>
        Remarks,
        
        /// <remarks/>
        Approved,
        
        /// <remarks/>
        Approval_Date,
        
        /// <remarks/>
        Approval_Comment,
        
        /// <remarks/>
        Rejected,
        
        /// <remarks/>
        Reject_Date,
        
        /// <remarks/>
        Rejection_Remarks,
        
        /// <remarks/>
        Leave_Status,
        
        /// <remarks/>
        Leave_Request_No,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read", WrapperNamespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", IsWrapped=true)]
    public partial class Read
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", Order=0)]
        public string Employee_No;
        
        public Read()
        {
        }
        
        public Read(string Employee_No)
        {
            this.Employee_No = Employee_No;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", IsWrapped=true)]
    public partial class Read_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", Order=0)]
        public PendingLeaveRequest.pendingleaverequest pendingleaverequest;
        
        public Read_Result()
        {
        }
        
        public Read_Result(PendingLeaveRequest.pendingleaverequest pendingleaverequest)
        {
            this.pendingleaverequest = pendingleaverequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId", WrapperNamespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", IsWrapped=true)]
    public partial class ReadByRecId
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", Order=0)]
        public string recId;
        
        public ReadByRecId()
        {
        }
        
        public ReadByRecId(string recId)
        {
            this.recId = recId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", IsWrapped=true)]
    public partial class ReadByRecId_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", Order=0)]
        public PendingLeaveRequest.pendingleaverequest pendingleaverequest;
        
        public ReadByRecId_Result()
        {
        }
        
        public ReadByRecId_Result(PendingLeaveRequest.pendingleaverequest pendingleaverequest)
        {
            this.pendingleaverequest = pendingleaverequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple", WrapperNamespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", IsWrapped=true)]
    public partial class ReadMultiple
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("filter")]
        public PendingLeaveRequest.pendingleaverequest_Filter[] filter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", Order=1)]
        public string bookmarkKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", Order=2)]
        public int setSize;
        
        public ReadMultiple()
        {
        }
        
        public ReadMultiple(PendingLeaveRequest.pendingleaverequest_Filter[] filter, string bookmarkKey, int setSize)
        {
            this.filter = filter;
            this.bookmarkKey = bookmarkKey;
            this.setSize = setSize;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", IsWrapped=true)]
    public partial class ReadMultiple_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReadMultiple_Result", Namespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public PendingLeaveRequest.pendingleaverequest[] ReadMultiple_Result1;
        
        public ReadMultiple_Result()
        {
        }
        
        public ReadMultiple_Result(PendingLeaveRequest.pendingleaverequest[] ReadMultiple_Result1)
        {
            this.ReadMultiple_Result1 = ReadMultiple_Result1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated", WrapperNamespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", IsWrapped=true)]
    public partial class IsUpdated
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", Order=0)]
        public string Key;
        
        public IsUpdated()
        {
        }
        
        public IsUpdated(string Key)
        {
            this.Key = Key;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", IsWrapped=true)]
    public partial class IsUpdated_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IsUpdated_Result", Namespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", Order=0)]
        public bool IsUpdated_Result1;
        
        public IsUpdated_Result()
        {
        }
        
        public IsUpdated_Result(bool IsUpdated_Result1)
        {
            this.IsUpdated_Result1 = IsUpdated_Result1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey", WrapperNamespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", IsWrapped=true)]
    public partial class GetRecIdFromKey
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", Order=0)]
        public string Key;
        
        public GetRecIdFromKey()
        {
        }
        
        public GetRecIdFromKey(string Key)
        {
            this.Key = Key;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", IsWrapped=true)]
    public partial class GetRecIdFromKey_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRecIdFromKey_Result", Namespace="urn:microsoft-dynamics-schemas/page/pendingleaverequest", Order=0)]
        public string GetRecIdFromKey_Result1;
        
        public GetRecIdFromKey_Result()
        {
        }
        
        public GetRecIdFromKey_Result(string GetRecIdFromKey_Result1)
        {
            this.GetRecIdFromKey_Result1 = GetRecIdFromKey_Result1;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    public interface pendingleaverequest_PortChannel : PendingLeaveRequest.pendingleaverequest_Port, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    public partial class pendingleaverequest_PortClient : System.ServiceModel.ClientBase<PendingLeaveRequest.pendingleaverequest_Port>, PendingLeaveRequest.pendingleaverequest_Port
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public pendingleaverequest_PortClient() : 
                base(pendingleaverequest_PortClient.GetDefaultBinding(), pendingleaverequest_PortClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.pendingleaverequest_Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public pendingleaverequest_PortClient(EndpointConfiguration endpointConfiguration) : 
                base(pendingleaverequest_PortClient.GetBindingForEndpoint(endpointConfiguration), pendingleaverequest_PortClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public pendingleaverequest_PortClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(pendingleaverequest_PortClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public pendingleaverequest_PortClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(pendingleaverequest_PortClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public pendingleaverequest_PortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PendingLeaveRequest.Read_Result> PendingLeaveRequest.pendingleaverequest_Port.ReadAsync(PendingLeaveRequest.Read request)
        {
            return base.Channel.ReadAsync(request);
        }
        
        public System.Threading.Tasks.Task<PendingLeaveRequest.Read_Result> ReadAsync(string Employee_No)
        {
            PendingLeaveRequest.Read inValue = new PendingLeaveRequest.Read();
            inValue.Employee_No = Employee_No;
            return ((PendingLeaveRequest.pendingleaverequest_Port)(this)).ReadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PendingLeaveRequest.ReadByRecId_Result> PendingLeaveRequest.pendingleaverequest_Port.ReadByRecIdAsync(PendingLeaveRequest.ReadByRecId request)
        {
            return base.Channel.ReadByRecIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<PendingLeaveRequest.ReadByRecId_Result> ReadByRecIdAsync(string recId)
        {
            PendingLeaveRequest.ReadByRecId inValue = new PendingLeaveRequest.ReadByRecId();
            inValue.recId = recId;
            return ((PendingLeaveRequest.pendingleaverequest_Port)(this)).ReadByRecIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PendingLeaveRequest.ReadMultiple_Result> PendingLeaveRequest.pendingleaverequest_Port.ReadMultipleAsync(PendingLeaveRequest.ReadMultiple request)
        {
            return base.Channel.ReadMultipleAsync(request);
        }
        
        public System.Threading.Tasks.Task<PendingLeaveRequest.ReadMultiple_Result> ReadMultipleAsync(PendingLeaveRequest.pendingleaverequest_Filter[] filter, string bookmarkKey, int setSize)
        {
            PendingLeaveRequest.ReadMultiple inValue = new PendingLeaveRequest.ReadMultiple();
            inValue.filter = filter;
            inValue.bookmarkKey = bookmarkKey;
            inValue.setSize = setSize;
            return ((PendingLeaveRequest.pendingleaverequest_Port)(this)).ReadMultipleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PendingLeaveRequest.IsUpdated_Result> PendingLeaveRequest.pendingleaverequest_Port.IsUpdatedAsync(PendingLeaveRequest.IsUpdated request)
        {
            return base.Channel.IsUpdatedAsync(request);
        }
        
        public System.Threading.Tasks.Task<PendingLeaveRequest.IsUpdated_Result> IsUpdatedAsync(string Key)
        {
            PendingLeaveRequest.IsUpdated inValue = new PendingLeaveRequest.IsUpdated();
            inValue.Key = Key;
            return ((PendingLeaveRequest.pendingleaverequest_Port)(this)).IsUpdatedAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PendingLeaveRequest.GetRecIdFromKey_Result> PendingLeaveRequest.pendingleaverequest_Port.GetRecIdFromKeyAsync(PendingLeaveRequest.GetRecIdFromKey request)
        {
            return base.Channel.GetRecIdFromKeyAsync(request);
        }
        
        public System.Threading.Tasks.Task<PendingLeaveRequest.GetRecIdFromKey_Result> GetRecIdFromKeyAsync(string Key)
        {
            PendingLeaveRequest.GetRecIdFromKey inValue = new PendingLeaveRequest.GetRecIdFromKey();
            inValue.Key = Key;
            return ((PendingLeaveRequest.pendingleaverequest_Port)(this)).GetRecIdFromKeyAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.pendingleaverequest_Port))
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
            if ((endpointConfiguration == EndpointConfiguration.pendingleaverequest_Port))
            {
                return new System.ServiceModel.EndpointAddress("http://110.34.3.177:4047/MOBAPP/WS/Test Company/Page/pendingleaverequest");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return pendingleaverequest_PortClient.GetBindingForEndpoint(EndpointConfiguration.pendingleaverequest_Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return pendingleaverequest_PortClient.GetEndpointAddress(EndpointConfiguration.pendingleaverequest_Port);
        }
        
        public enum EndpointConfiguration
        {
            
            pendingleaverequest_Port,
        }
    }
}
