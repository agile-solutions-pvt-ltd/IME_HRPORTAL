﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeaveBalance
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", ConfigurationName="LeaveBalance.leavebalance_Port")]
    public interface leavebalance_Port
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/leavebalance:Read", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<LeaveBalance.Read_Result> ReadAsync(LeaveBalance.Read request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/leavebalance:ReadByRecId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<LeaveBalance.ReadByRecId_Result> ReadByRecIdAsync(LeaveBalance.ReadByRecId request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/leavebalance:ReadMultiple", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<LeaveBalance.ReadMultiple_Result> ReadMultipleAsync(LeaveBalance.ReadMultiple request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/leavebalance:IsUpdated", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<LeaveBalance.IsUpdated_Result> IsUpdatedAsync(LeaveBalance.IsUpdated request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/leavebalance:GetRecIdFromKey", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<LeaveBalance.GetRecIdFromKey_Result> GetRecIdFromKeyAsync(LeaveBalance.GetRecIdFromKey request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/leavebalance:Create", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<LeaveBalance.Create_Result> CreateAsync(LeaveBalance.Create request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/leavebalance:CreateMultiple", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<LeaveBalance.CreateMultiple_Result> CreateMultipleAsync(LeaveBalance.CreateMultiple request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/leavebalance:Update", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<LeaveBalance.Update_Result> UpdateAsync(LeaveBalance.Update request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/leavebalance:UpdateMultiple", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<LeaveBalance.UpdateMultiple_Result> UpdateMultipleAsync(LeaveBalance.UpdateMultiple request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/leavebalance:Delete", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<LeaveBalance.Delete_Result> DeleteAsync(LeaveBalance.Delete request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance")]
    public partial class leavebalance
    {
        
        private string keyField;
        
        private string employee_CodeField;
        
        private string leave_DescriptionField;
        
        private string leave_TypeField;
        
        private decimal balance_DaysField;
        
        private bool balance_DaysFieldSpecified;
        
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
        public string Employee_Code
        {
            get
            {
                return this.employee_CodeField;
            }
            set
            {
                this.employee_CodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Leave_Type
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
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public decimal Balance_Days
        {
            get
            {
                return this.balance_DaysField;
            }
            set
            {
                this.balance_DaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Balance_DaysSpecified
        {
            get
            {
                return this.balance_DaysFieldSpecified;
            }
            set
            {
                this.balance_DaysFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance")]
    public partial class leavebalance_Filter
    {
        
        private leavebalance_Fields fieldField;
        
        private string criteriaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public leavebalance_Fields Field
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance")]
    public enum leavebalance_Fields
    {
        
        /// <remarks/>
        Employee_Code,
        
        /// <remarks/>
        Leave_Description,
        
        /// <remarks/>
        Leave_Type,
        
        /// <remarks/>
        Balance_Days,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read", WrapperNamespace="urn:microsoft-dynamics-schemas/page/leavebalance", IsWrapped=true)]
    public partial class Read
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=0)]
        public string Employee_Code;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=1)]
        public string Leave_Type;
        
        public Read()
        {
        }
        
        public Read(string Employee_Code, string Leave_Type)
        {
            this.Employee_Code = Employee_Code;
            this.Leave_Type = Leave_Type;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/leavebalance", IsWrapped=true)]
    public partial class Read_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=0)]
        public LeaveBalance.leavebalance leavebalance;
        
        public Read_Result()
        {
        }
        
        public Read_Result(LeaveBalance.leavebalance leavebalance)
        {
            this.leavebalance = leavebalance;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId", WrapperNamespace="urn:microsoft-dynamics-schemas/page/leavebalance", IsWrapped=true)]
    public partial class ReadByRecId
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/leavebalance", IsWrapped=true)]
    public partial class ReadByRecId_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=0)]
        public LeaveBalance.leavebalance leavebalance;
        
        public ReadByRecId_Result()
        {
        }
        
        public ReadByRecId_Result(LeaveBalance.leavebalance leavebalance)
        {
            this.leavebalance = leavebalance;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple", WrapperNamespace="urn:microsoft-dynamics-schemas/page/leavebalance", IsWrapped=true)]
    public partial class ReadMultiple
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("filter")]
        public LeaveBalance.leavebalance_Filter[] filter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=1)]
        public string bookmarkKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=2)]
        public int setSize;
        
        public ReadMultiple()
        {
        }
        
        public ReadMultiple(LeaveBalance.leavebalance_Filter[] filter, string bookmarkKey, int setSize)
        {
            this.filter = filter;
            this.bookmarkKey = bookmarkKey;
            this.setSize = setSize;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/leavebalance", IsWrapped=true)]
    public partial class ReadMultiple_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReadMultiple_Result", Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public LeaveBalance.leavebalance[] ReadMultiple_Result1;
        
        public ReadMultiple_Result()
        {
        }
        
        public ReadMultiple_Result(LeaveBalance.leavebalance[] ReadMultiple_Result1)
        {
            this.ReadMultiple_Result1 = ReadMultiple_Result1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated", WrapperNamespace="urn:microsoft-dynamics-schemas/page/leavebalance", IsWrapped=true)]
    public partial class IsUpdated
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/leavebalance", IsWrapped=true)]
    public partial class IsUpdated_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IsUpdated_Result", Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey", WrapperNamespace="urn:microsoft-dynamics-schemas/page/leavebalance", IsWrapped=true)]
    public partial class GetRecIdFromKey
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/leavebalance", IsWrapped=true)]
    public partial class GetRecIdFromKey_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRecIdFromKey_Result", Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=0)]
        public string GetRecIdFromKey_Result1;
        
        public GetRecIdFromKey_Result()
        {
        }
        
        public GetRecIdFromKey_Result(string GetRecIdFromKey_Result1)
        {
            this.GetRecIdFromKey_Result1 = GetRecIdFromKey_Result1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Create", WrapperNamespace="urn:microsoft-dynamics-schemas/page/leavebalance", IsWrapped=true)]
    public partial class Create
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=0)]
        public LeaveBalance.leavebalance leavebalance;
        
        public Create()
        {
        }
        
        public Create(LeaveBalance.leavebalance leavebalance)
        {
            this.leavebalance = leavebalance;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Create_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/leavebalance", IsWrapped=true)]
    public partial class Create_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=0)]
        public LeaveBalance.leavebalance leavebalance;
        
        public Create_Result()
        {
        }
        
        public Create_Result(LeaveBalance.leavebalance leavebalance)
        {
            this.leavebalance = leavebalance;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateMultiple", WrapperNamespace="urn:microsoft-dynamics-schemas/page/leavebalance", IsWrapped=true)]
    public partial class CreateMultiple
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public LeaveBalance.leavebalance[] leavebalance_List;
        
        public CreateMultiple()
        {
        }
        
        public CreateMultiple(LeaveBalance.leavebalance[] leavebalance_List)
        {
            this.leavebalance_List = leavebalance_List;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateMultiple_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/leavebalance", IsWrapped=true)]
    public partial class CreateMultiple_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public LeaveBalance.leavebalance[] leavebalance_List;
        
        public CreateMultiple_Result()
        {
        }
        
        public CreateMultiple_Result(LeaveBalance.leavebalance[] leavebalance_List)
        {
            this.leavebalance_List = leavebalance_List;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Update", WrapperNamespace="urn:microsoft-dynamics-schemas/page/leavebalance", IsWrapped=true)]
    public partial class Update
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=0)]
        public LeaveBalance.leavebalance leavebalance;
        
        public Update()
        {
        }
        
        public Update(LeaveBalance.leavebalance leavebalance)
        {
            this.leavebalance = leavebalance;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Update_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/leavebalance", IsWrapped=true)]
    public partial class Update_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=0)]
        public LeaveBalance.leavebalance leavebalance;
        
        public Update_Result()
        {
        }
        
        public Update_Result(LeaveBalance.leavebalance leavebalance)
        {
            this.leavebalance = leavebalance;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateMultiple", WrapperNamespace="urn:microsoft-dynamics-schemas/page/leavebalance", IsWrapped=true)]
    public partial class UpdateMultiple
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public LeaveBalance.leavebalance[] leavebalance_List;
        
        public UpdateMultiple()
        {
        }
        
        public UpdateMultiple(LeaveBalance.leavebalance[] leavebalance_List)
        {
            this.leavebalance_List = leavebalance_List;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateMultiple_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/leavebalance", IsWrapped=true)]
    public partial class UpdateMultiple_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public LeaveBalance.leavebalance[] leavebalance_List;
        
        public UpdateMultiple_Result()
        {
        }
        
        public UpdateMultiple_Result(LeaveBalance.leavebalance[] leavebalance_List)
        {
            this.leavebalance_List = leavebalance_List;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Delete", WrapperNamespace="urn:microsoft-dynamics-schemas/page/leavebalance", IsWrapped=true)]
    public partial class Delete
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=0)]
        public string Key;
        
        public Delete()
        {
        }
        
        public Delete(string Key)
        {
            this.Key = Key;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Delete_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/leavebalance", IsWrapped=true)]
    public partial class Delete_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Delete_Result", Namespace="urn:microsoft-dynamics-schemas/page/leavebalance", Order=0)]
        public bool Delete_Result1;
        
        public Delete_Result()
        {
        }
        
        public Delete_Result(bool Delete_Result1)
        {
            this.Delete_Result1 = Delete_Result1;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    public interface leavebalance_PortChannel : LeaveBalance.leavebalance_Port, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    public partial class leavebalance_PortClient : System.ServiceModel.ClientBase<LeaveBalance.leavebalance_Port>, LeaveBalance.leavebalance_Port
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public leavebalance_PortClient() : 
                base(leavebalance_PortClient.GetDefaultBinding(), leavebalance_PortClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.leavebalance_Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public leavebalance_PortClient(EndpointConfiguration endpointConfiguration) : 
                base(leavebalance_PortClient.GetBindingForEndpoint(endpointConfiguration), leavebalance_PortClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public leavebalance_PortClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(leavebalance_PortClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public leavebalance_PortClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(leavebalance_PortClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public leavebalance_PortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LeaveBalance.Read_Result> LeaveBalance.leavebalance_Port.ReadAsync(LeaveBalance.Read request)
        {
            return base.Channel.ReadAsync(request);
        }
        
        public System.Threading.Tasks.Task<LeaveBalance.Read_Result> ReadAsync(string Employee_Code, string Leave_Type)
        {
            LeaveBalance.Read inValue = new LeaveBalance.Read();
            inValue.Employee_Code = Employee_Code;
            inValue.Leave_Type = Leave_Type;
            return ((LeaveBalance.leavebalance_Port)(this)).ReadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LeaveBalance.ReadByRecId_Result> LeaveBalance.leavebalance_Port.ReadByRecIdAsync(LeaveBalance.ReadByRecId request)
        {
            return base.Channel.ReadByRecIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<LeaveBalance.ReadByRecId_Result> ReadByRecIdAsync(string recId)
        {
            LeaveBalance.ReadByRecId inValue = new LeaveBalance.ReadByRecId();
            inValue.recId = recId;
            return ((LeaveBalance.leavebalance_Port)(this)).ReadByRecIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LeaveBalance.ReadMultiple_Result> LeaveBalance.leavebalance_Port.ReadMultipleAsync(LeaveBalance.ReadMultiple request)
        {
            return base.Channel.ReadMultipleAsync(request);
        }
        
        public System.Threading.Tasks.Task<LeaveBalance.ReadMultiple_Result> ReadMultipleAsync(LeaveBalance.leavebalance_Filter[] filter, string bookmarkKey, int setSize)
        {
            LeaveBalance.ReadMultiple inValue = new LeaveBalance.ReadMultiple();
            inValue.filter = filter;
            inValue.bookmarkKey = bookmarkKey;
            inValue.setSize = setSize;
            return ((LeaveBalance.leavebalance_Port)(this)).ReadMultipleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LeaveBalance.IsUpdated_Result> LeaveBalance.leavebalance_Port.IsUpdatedAsync(LeaveBalance.IsUpdated request)
        {
            return base.Channel.IsUpdatedAsync(request);
        }
        
        public System.Threading.Tasks.Task<LeaveBalance.IsUpdated_Result> IsUpdatedAsync(string Key)
        {
            LeaveBalance.IsUpdated inValue = new LeaveBalance.IsUpdated();
            inValue.Key = Key;
            return ((LeaveBalance.leavebalance_Port)(this)).IsUpdatedAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LeaveBalance.GetRecIdFromKey_Result> LeaveBalance.leavebalance_Port.GetRecIdFromKeyAsync(LeaveBalance.GetRecIdFromKey request)
        {
            return base.Channel.GetRecIdFromKeyAsync(request);
        }
        
        public System.Threading.Tasks.Task<LeaveBalance.GetRecIdFromKey_Result> GetRecIdFromKeyAsync(string Key)
        {
            LeaveBalance.GetRecIdFromKey inValue = new LeaveBalance.GetRecIdFromKey();
            inValue.Key = Key;
            return ((LeaveBalance.leavebalance_Port)(this)).GetRecIdFromKeyAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<LeaveBalance.Create_Result> CreateAsync(LeaveBalance.Create request)
        {
            return base.Channel.CreateAsync(request);
        }
        
        public System.Threading.Tasks.Task<LeaveBalance.CreateMultiple_Result> CreateMultipleAsync(LeaveBalance.CreateMultiple request)
        {
            return base.Channel.CreateMultipleAsync(request);
        }
        
        public System.Threading.Tasks.Task<LeaveBalance.Update_Result> UpdateAsync(LeaveBalance.Update request)
        {
            return base.Channel.UpdateAsync(request);
        }
        
        public System.Threading.Tasks.Task<LeaveBalance.UpdateMultiple_Result> UpdateMultipleAsync(LeaveBalance.UpdateMultiple request)
        {
            return base.Channel.UpdateMultipleAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LeaveBalance.Delete_Result> LeaveBalance.leavebalance_Port.DeleteAsync(LeaveBalance.Delete request)
        {
            return base.Channel.DeleteAsync(request);
        }
        
        public System.Threading.Tasks.Task<LeaveBalance.Delete_Result> DeleteAsync(string Key)
        {
            LeaveBalance.Delete inValue = new LeaveBalance.Delete();
            inValue.Key = Key;
            return ((LeaveBalance.leavebalance_Port)(this)).DeleteAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.leavebalance_Port))
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
            if ((endpointConfiguration == EndpointConfiguration.leavebalance_Port))
            {
                return new System.ServiceModel.EndpointAddress("http://110.34.3.177:4047/MOBAPP/WS/Test Company/Page/leavebalance");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return leavebalance_PortClient.GetBindingForEndpoint(EndpointConfiguration.leavebalance_Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return leavebalance_PortClient.GetEndpointAddress(EndpointConfiguration.leavebalance_Port);
        }
        
        public enum EndpointConfiguration
        {
            
            leavebalance_Port,
        }
    }
}