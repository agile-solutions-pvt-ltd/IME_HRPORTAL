﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecommendedSalaryAdvance
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", ConfigurationName="RecommendedSalaryAdvance.recommendedsalaryadvance_Port")]
    public interface recommendedsalaryadvance_Port
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance:Read", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<RecommendedSalaryAdvance.Read_Result> ReadAsync(RecommendedSalaryAdvance.Read request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance:ReadByRecId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<RecommendedSalaryAdvance.ReadByRecId_Result> ReadByRecIdAsync(RecommendedSalaryAdvance.ReadByRecId request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance:ReadMultiple", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<RecommendedSalaryAdvance.ReadMultiple_Result> ReadMultipleAsync(RecommendedSalaryAdvance.ReadMultiple request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance:IsUpdated", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<RecommendedSalaryAdvance.IsUpdated_Result> IsUpdatedAsync(RecommendedSalaryAdvance.IsUpdated request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance:GetRecIdFromKey", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<RecommendedSalaryAdvance.GetRecIdFromKey_Result> GetRecIdFromKeyAsync(RecommendedSalaryAdvance.GetRecIdFromKey request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance")]
    public partial class recommendedsalaryadvance
    {
        
        private string keyField;
        
        private string noField;
        
        private string employee_NoField;
        
        private string employee_NameField;
        
        private string departmentField;
        
        private string branchField;
        
        private string job_TitleField;
        
        private decimal claimed_AmountField;
        
        private bool claimed_AmountFieldSpecified;
        
        private System.DateTime requested_DateField;
        
        private bool requested_DateFieldSpecified;
        
        private Status statusField;
        
        private bool statusFieldSpecified;
        
        private string posted_byField;
        
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
        public string No
        {
            get
            {
                return this.noField;
            }
            set
            {
                this.noField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Employee_Name
        {
            get
            {
                return this.employee_NameField;
            }
            set
            {
                this.employee_NameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Department
        {
            get
            {
                return this.departmentField;
            }
            set
            {
                this.departmentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Branch
        {
            get
            {
                return this.branchField;
            }
            set
            {
                this.branchField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Job_Title
        {
            get
            {
                return this.job_TitleField;
            }
            set
            {
                this.job_TitleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public decimal Claimed_Amount
        {
            get
            {
                return this.claimed_AmountField;
            }
            set
            {
                this.claimed_AmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Claimed_AmountSpecified
        {
            get
            {
                return this.claimed_AmountFieldSpecified;
            }
            set
            {
                this.claimed_AmountFieldSpecified = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public Status Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string Posted_by
        {
            get
            {
                return this.posted_byField;
            }
            set
            {
                this.posted_byField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance")]
    public enum Status
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance")]
    public partial class recommendedsalaryadvance_Filter
    {
        
        private recommendedsalaryadvance_Fields fieldField;
        
        private string criteriaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public recommendedsalaryadvance_Fields Field
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance")]
    public enum recommendedsalaryadvance_Fields
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Employee_No,
        
        /// <remarks/>
        Employee_Name,
        
        /// <remarks/>
        Department,
        
        /// <remarks/>
        Branch,
        
        /// <remarks/>
        Job_Title,
        
        /// <remarks/>
        Claimed_Amount,
        
        /// <remarks/>
        Requested_Date,
        
        /// <remarks/>
        Status,
        
        /// <remarks/>
        Posted_by,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read", WrapperNamespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", IsWrapped=true)]
    public partial class Read
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", Order=0)]
        public string No;
        
        public Read()
        {
        }
        
        public Read(string No)
        {
            this.No = No;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", IsWrapped=true)]
    public partial class Read_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", Order=0)]
        public RecommendedSalaryAdvance.recommendedsalaryadvance recommendedsalaryadvance;
        
        public Read_Result()
        {
        }
        
        public Read_Result(RecommendedSalaryAdvance.recommendedsalaryadvance recommendedsalaryadvance)
        {
            this.recommendedsalaryadvance = recommendedsalaryadvance;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId", WrapperNamespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", IsWrapped=true)]
    public partial class ReadByRecId
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", IsWrapped=true)]
    public partial class ReadByRecId_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", Order=0)]
        public RecommendedSalaryAdvance.recommendedsalaryadvance recommendedsalaryadvance;
        
        public ReadByRecId_Result()
        {
        }
        
        public ReadByRecId_Result(RecommendedSalaryAdvance.recommendedsalaryadvance recommendedsalaryadvance)
        {
            this.recommendedsalaryadvance = recommendedsalaryadvance;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple", WrapperNamespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", IsWrapped=true)]
    public partial class ReadMultiple
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("filter")]
        public RecommendedSalaryAdvance.recommendedsalaryadvance_Filter[] filter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", Order=1)]
        public string bookmarkKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", Order=2)]
        public int setSize;
        
        public ReadMultiple()
        {
        }
        
        public ReadMultiple(RecommendedSalaryAdvance.recommendedsalaryadvance_Filter[] filter, string bookmarkKey, int setSize)
        {
            this.filter = filter;
            this.bookmarkKey = bookmarkKey;
            this.setSize = setSize;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", IsWrapped=true)]
    public partial class ReadMultiple_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReadMultiple_Result", Namespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public RecommendedSalaryAdvance.recommendedsalaryadvance[] ReadMultiple_Result1;
        
        public ReadMultiple_Result()
        {
        }
        
        public ReadMultiple_Result(RecommendedSalaryAdvance.recommendedsalaryadvance[] ReadMultiple_Result1)
        {
            this.ReadMultiple_Result1 = ReadMultiple_Result1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated", WrapperNamespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", IsWrapped=true)]
    public partial class IsUpdated
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", IsWrapped=true)]
    public partial class IsUpdated_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IsUpdated_Result", Namespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey", WrapperNamespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", IsWrapped=true)]
    public partial class GetRecIdFromKey
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", IsWrapped=true)]
    public partial class GetRecIdFromKey_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRecIdFromKey_Result", Namespace="urn:microsoft-dynamics-schemas/page/recommendedsalaryadvance", Order=0)]
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
    public interface recommendedsalaryadvance_PortChannel : RecommendedSalaryAdvance.recommendedsalaryadvance_Port, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30514-0828")]
    public partial class recommendedsalaryadvance_PortClient : System.ServiceModel.ClientBase<RecommendedSalaryAdvance.recommendedsalaryadvance_Port>, RecommendedSalaryAdvance.recommendedsalaryadvance_Port
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public recommendedsalaryadvance_PortClient() : 
                base(recommendedsalaryadvance_PortClient.GetDefaultBinding(), recommendedsalaryadvance_PortClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.recommendedsalaryadvance_Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public recommendedsalaryadvance_PortClient(EndpointConfiguration endpointConfiguration) : 
                base(recommendedsalaryadvance_PortClient.GetBindingForEndpoint(endpointConfiguration), recommendedsalaryadvance_PortClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public recommendedsalaryadvance_PortClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(recommendedsalaryadvance_PortClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public recommendedsalaryadvance_PortClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(recommendedsalaryadvance_PortClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public recommendedsalaryadvance_PortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RecommendedSalaryAdvance.Read_Result> RecommendedSalaryAdvance.recommendedsalaryadvance_Port.ReadAsync(RecommendedSalaryAdvance.Read request)
        {
            return base.Channel.ReadAsync(request);
        }
        
        public System.Threading.Tasks.Task<RecommendedSalaryAdvance.Read_Result> ReadAsync(string No)
        {
            RecommendedSalaryAdvance.Read inValue = new RecommendedSalaryAdvance.Read();
            inValue.No = No;
            return ((RecommendedSalaryAdvance.recommendedsalaryadvance_Port)(this)).ReadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RecommendedSalaryAdvance.ReadByRecId_Result> RecommendedSalaryAdvance.recommendedsalaryadvance_Port.ReadByRecIdAsync(RecommendedSalaryAdvance.ReadByRecId request)
        {
            return base.Channel.ReadByRecIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<RecommendedSalaryAdvance.ReadByRecId_Result> ReadByRecIdAsync(string recId)
        {
            RecommendedSalaryAdvance.ReadByRecId inValue = new RecommendedSalaryAdvance.ReadByRecId();
            inValue.recId = recId;
            return ((RecommendedSalaryAdvance.recommendedsalaryadvance_Port)(this)).ReadByRecIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RecommendedSalaryAdvance.ReadMultiple_Result> RecommendedSalaryAdvance.recommendedsalaryadvance_Port.ReadMultipleAsync(RecommendedSalaryAdvance.ReadMultiple request)
        {
            return base.Channel.ReadMultipleAsync(request);
        }
        
        public System.Threading.Tasks.Task<RecommendedSalaryAdvance.ReadMultiple_Result> ReadMultipleAsync(RecommendedSalaryAdvance.recommendedsalaryadvance_Filter[] filter, string bookmarkKey, int setSize)
        {
            RecommendedSalaryAdvance.ReadMultiple inValue = new RecommendedSalaryAdvance.ReadMultiple();
            inValue.filter = filter;
            inValue.bookmarkKey = bookmarkKey;
            inValue.setSize = setSize;
            return ((RecommendedSalaryAdvance.recommendedsalaryadvance_Port)(this)).ReadMultipleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RecommendedSalaryAdvance.IsUpdated_Result> RecommendedSalaryAdvance.recommendedsalaryadvance_Port.IsUpdatedAsync(RecommendedSalaryAdvance.IsUpdated request)
        {
            return base.Channel.IsUpdatedAsync(request);
        }
        
        public System.Threading.Tasks.Task<RecommendedSalaryAdvance.IsUpdated_Result> IsUpdatedAsync(string Key)
        {
            RecommendedSalaryAdvance.IsUpdated inValue = new RecommendedSalaryAdvance.IsUpdated();
            inValue.Key = Key;
            return ((RecommendedSalaryAdvance.recommendedsalaryadvance_Port)(this)).IsUpdatedAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<RecommendedSalaryAdvance.GetRecIdFromKey_Result> RecommendedSalaryAdvance.recommendedsalaryadvance_Port.GetRecIdFromKeyAsync(RecommendedSalaryAdvance.GetRecIdFromKey request)
        {
            return base.Channel.GetRecIdFromKeyAsync(request);
        }
        
        public System.Threading.Tasks.Task<RecommendedSalaryAdvance.GetRecIdFromKey_Result> GetRecIdFromKeyAsync(string Key)
        {
            RecommendedSalaryAdvance.GetRecIdFromKey inValue = new RecommendedSalaryAdvance.GetRecIdFromKey();
            inValue.Key = Key;
            return ((RecommendedSalaryAdvance.recommendedsalaryadvance_Port)(this)).GetRecIdFromKeyAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.recommendedsalaryadvance_Port))
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
            if ((endpointConfiguration == EndpointConfiguration.recommendedsalaryadvance_Port))
            {
                return new System.ServiceModel.EndpointAddress("http://110.34.3.177:4047/MOBAPP/WS/Test Company/Page/recommendedsalaryadvance");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return recommendedsalaryadvance_PortClient.GetBindingForEndpoint(EndpointConfiguration.recommendedsalaryadvance_Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return recommendedsalaryadvance_PortClient.GetEndpointAddress(EndpointConfiguration.recommendedsalaryadvance_Port);
        }
        
        public enum EndpointConfiguration
        {
            
            recommendedsalaryadvance_Port,
        }
    }
}
