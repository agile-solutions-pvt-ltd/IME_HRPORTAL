﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Companies
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/page/companies", ConfigurationName="Companies.companies_Port")]
    public interface companies_Port
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/companies:Read", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Companies.Read_Result> ReadAsync(Companies.Read request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/companies:ReadByRecId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Companies.ReadByRecId_Result> ReadByRecIdAsync(Companies.ReadByRecId request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/companies:ReadMultiple", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Companies.ReadMultiple_Result> ReadMultipleAsync(Companies.ReadMultiple request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/companies:IsUpdated", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Companies.IsUpdated_Result> IsUpdatedAsync(Companies.IsUpdated request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/companies:GetRecIdFromKey", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Companies.GetRecIdFromKey_Result> GetRecIdFromKeyAsync(Companies.GetRecIdFromKey request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/companies:Create", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Companies.Create_Result> CreateAsync(Companies.Create request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/companies:CreateMultiple", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Companies.CreateMultiple_Result> CreateMultipleAsync(Companies.CreateMultiple request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/companies:Update", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Companies.Update_Result> UpdateAsync(Companies.Update request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/companies:UpdateMultiple", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Companies.UpdateMultiple_Result> UpdateMultipleAsync(Companies.UpdateMultiple request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/companies:Delete", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Companies.Delete_Result> DeleteAsync(Companies.Delete request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/companies")]
    public partial class companies
    {
        
        private string keyField;
        
        private string nameField;
        
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
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/companies")]
    public partial class companies_Filter
    {
        
        private companies_Fields fieldField;
        
        private string criteriaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public companies_Fields Field
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/companies")]
    public enum companies_Fields
    {
        
        /// <remarks/>
        Name,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read", WrapperNamespace="urn:microsoft-dynamics-schemas/page/companies", IsWrapped=true)]
    public partial class Read
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/companies", Order=0)]
        public string Name;
        
        public Read()
        {
        }
        
        public Read(string Name)
        {
            this.Name = Name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/companies", IsWrapped=true)]
    public partial class Read_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/companies", Order=0)]
        public Companies.companies companies;
        
        public Read_Result()
        {
        }
        
        public Read_Result(Companies.companies companies)
        {
            this.companies = companies;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId", WrapperNamespace="urn:microsoft-dynamics-schemas/page/companies", IsWrapped=true)]
    public partial class ReadByRecId
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/companies", Order=0)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/companies", IsWrapped=true)]
    public partial class ReadByRecId_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/companies", Order=0)]
        public Companies.companies companies;
        
        public ReadByRecId_Result()
        {
        }
        
        public ReadByRecId_Result(Companies.companies companies)
        {
            this.companies = companies;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple", WrapperNamespace="urn:microsoft-dynamics-schemas/page/companies", IsWrapped=true)]
    public partial class ReadMultiple
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/companies", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("filter")]
        public Companies.companies_Filter[] filter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/companies", Order=1)]
        public string bookmarkKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/companies", Order=2)]
        public int setSize;
        
        public ReadMultiple()
        {
        }
        
        public ReadMultiple(Companies.companies_Filter[] filter, string bookmarkKey, int setSize)
        {
            this.filter = filter;
            this.bookmarkKey = bookmarkKey;
            this.setSize = setSize;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/companies", IsWrapped=true)]
    public partial class ReadMultiple_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReadMultiple_Result", Namespace="urn:microsoft-dynamics-schemas/page/companies", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Companies.companies[] ReadMultiple_Result1;
        
        public ReadMultiple_Result()
        {
        }
        
        public ReadMultiple_Result(Companies.companies[] ReadMultiple_Result1)
        {
            this.ReadMultiple_Result1 = ReadMultiple_Result1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated", WrapperNamespace="urn:microsoft-dynamics-schemas/page/companies", IsWrapped=true)]
    public partial class IsUpdated
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/companies", Order=0)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/companies", IsWrapped=true)]
    public partial class IsUpdated_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IsUpdated_Result", Namespace="urn:microsoft-dynamics-schemas/page/companies", Order=0)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey", WrapperNamespace="urn:microsoft-dynamics-schemas/page/companies", IsWrapped=true)]
    public partial class GetRecIdFromKey
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/companies", Order=0)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/companies", IsWrapped=true)]
    public partial class GetRecIdFromKey_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetRecIdFromKey_Result", Namespace="urn:microsoft-dynamics-schemas/page/companies", Order=0)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Create", WrapperNamespace="urn:microsoft-dynamics-schemas/page/companies", IsWrapped=true)]
    public partial class Create
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/companies", Order=0)]
        public Companies.companies companies;
        
        public Create()
        {
        }
        
        public Create(Companies.companies companies)
        {
            this.companies = companies;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Create_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/companies", IsWrapped=true)]
    public partial class Create_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/companies", Order=0)]
        public Companies.companies companies;
        
        public Create_Result()
        {
        }
        
        public Create_Result(Companies.companies companies)
        {
            this.companies = companies;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateMultiple", WrapperNamespace="urn:microsoft-dynamics-schemas/page/companies", IsWrapped=true)]
    public partial class CreateMultiple
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/companies", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Companies.companies[] companies_List;
        
        public CreateMultiple()
        {
        }
        
        public CreateMultiple(Companies.companies[] companies_List)
        {
            this.companies_List = companies_List;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateMultiple_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/companies", IsWrapped=true)]
    public partial class CreateMultiple_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/companies", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Companies.companies[] companies_List;
        
        public CreateMultiple_Result()
        {
        }
        
        public CreateMultiple_Result(Companies.companies[] companies_List)
        {
            this.companies_List = companies_List;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Update", WrapperNamespace="urn:microsoft-dynamics-schemas/page/companies", IsWrapped=true)]
    public partial class Update
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/companies", Order=0)]
        public Companies.companies companies;
        
        public Update()
        {
        }
        
        public Update(Companies.companies companies)
        {
            this.companies = companies;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Update_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/companies", IsWrapped=true)]
    public partial class Update_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/companies", Order=0)]
        public Companies.companies companies;
        
        public Update_Result()
        {
        }
        
        public Update_Result(Companies.companies companies)
        {
            this.companies = companies;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateMultiple", WrapperNamespace="urn:microsoft-dynamics-schemas/page/companies", IsWrapped=true)]
    public partial class UpdateMultiple
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/companies", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Companies.companies[] companies_List;
        
        public UpdateMultiple()
        {
        }
        
        public UpdateMultiple(Companies.companies[] companies_List)
        {
            this.companies_List = companies_List;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateMultiple_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/companies", IsWrapped=true)]
    public partial class UpdateMultiple_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/companies", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Companies.companies[] companies_List;
        
        public UpdateMultiple_Result()
        {
        }
        
        public UpdateMultiple_Result(Companies.companies[] companies_List)
        {
            this.companies_List = companies_List;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Delete", WrapperNamespace="urn:microsoft-dynamics-schemas/page/companies", IsWrapped=true)]
    public partial class Delete
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/companies", Order=0)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Delete_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/companies", IsWrapped=true)]
    public partial class Delete_Result
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Delete_Result", Namespace="urn:microsoft-dynamics-schemas/page/companies", Order=0)]
        public bool Delete_Result1;
        
        public Delete_Result()
        {
        }
        
        public Delete_Result(bool Delete_Result1)
        {
            this.Delete_Result1 = Delete_Result1;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    public interface companies_PortChannel : Companies.companies_Port, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.1-preview-30422-0661")]
    public partial class companies_PortClient : System.ServiceModel.ClientBase<Companies.companies_Port>, Companies.companies_Port
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public companies_PortClient() : 
                base(companies_PortClient.GetDefaultBinding(), companies_PortClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.companies_Port.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public companies_PortClient(EndpointConfiguration endpointConfiguration) : 
                base(companies_PortClient.GetBindingForEndpoint(endpointConfiguration), companies_PortClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public companies_PortClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(companies_PortClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public companies_PortClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(companies_PortClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public companies_PortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Companies.Read_Result> Companies.companies_Port.ReadAsync(Companies.Read request)
        {
            return base.Channel.ReadAsync(request);
        }
        
        public System.Threading.Tasks.Task<Companies.Read_Result> ReadAsync(string Name)
        {
            Companies.Read inValue = new Companies.Read();
            inValue.Name = Name;
            return ((Companies.companies_Port)(this)).ReadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Companies.ReadByRecId_Result> Companies.companies_Port.ReadByRecIdAsync(Companies.ReadByRecId request)
        {
            return base.Channel.ReadByRecIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<Companies.ReadByRecId_Result> ReadByRecIdAsync(string recId)
        {
            Companies.ReadByRecId inValue = new Companies.ReadByRecId();
            inValue.recId = recId;
            return ((Companies.companies_Port)(this)).ReadByRecIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Companies.ReadMultiple_Result> Companies.companies_Port.ReadMultipleAsync(Companies.ReadMultiple request)
        {
            return base.Channel.ReadMultipleAsync(request);
        }
        
        public System.Threading.Tasks.Task<Companies.ReadMultiple_Result> ReadMultipleAsync(Companies.companies_Filter[] filter, string bookmarkKey, int setSize)
        {
            Companies.ReadMultiple inValue = new Companies.ReadMultiple();
            inValue.filter = filter;
            inValue.bookmarkKey = bookmarkKey;
            inValue.setSize = setSize;
            return ((Companies.companies_Port)(this)).ReadMultipleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Companies.IsUpdated_Result> Companies.companies_Port.IsUpdatedAsync(Companies.IsUpdated request)
        {
            return base.Channel.IsUpdatedAsync(request);
        }
        
        public System.Threading.Tasks.Task<Companies.IsUpdated_Result> IsUpdatedAsync(string Key)
        {
            Companies.IsUpdated inValue = new Companies.IsUpdated();
            inValue.Key = Key;
            return ((Companies.companies_Port)(this)).IsUpdatedAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Companies.GetRecIdFromKey_Result> Companies.companies_Port.GetRecIdFromKeyAsync(Companies.GetRecIdFromKey request)
        {
            return base.Channel.GetRecIdFromKeyAsync(request);
        }
        
        public System.Threading.Tasks.Task<Companies.GetRecIdFromKey_Result> GetRecIdFromKeyAsync(string Key)
        {
            Companies.GetRecIdFromKey inValue = new Companies.GetRecIdFromKey();
            inValue.Key = Key;
            return ((Companies.companies_Port)(this)).GetRecIdFromKeyAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Companies.Create_Result> CreateAsync(Companies.Create request)
        {
            return base.Channel.CreateAsync(request);
        }
        
        public System.Threading.Tasks.Task<Companies.CreateMultiple_Result> CreateMultipleAsync(Companies.CreateMultiple request)
        {
            return base.Channel.CreateMultipleAsync(request);
        }
        
        public System.Threading.Tasks.Task<Companies.Update_Result> UpdateAsync(Companies.Update request)
        {
            return base.Channel.UpdateAsync(request);
        }
        
        public System.Threading.Tasks.Task<Companies.UpdateMultiple_Result> UpdateMultipleAsync(Companies.UpdateMultiple request)
        {
            return base.Channel.UpdateMultipleAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Companies.Delete_Result> Companies.companies_Port.DeleteAsync(Companies.Delete request)
        {
            return base.Channel.DeleteAsync(request);
        }
        
        public System.Threading.Tasks.Task<Companies.Delete_Result> DeleteAsync(string Key)
        {
            Companies.Delete inValue = new Companies.Delete();
            inValue.Key = Key;
            return ((Companies.companies_Port)(this)).DeleteAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.companies_Port))
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
            if ((endpointConfiguration == EndpointConfiguration.companies_Port))
            {
                return new System.ServiceModel.EndpointAddress("http://110.34.3.177:4047/MOBAPP/WS/Test Company/Page/companies");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return companies_PortClient.GetBindingForEndpoint(EndpointConfiguration.companies_Port);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return companies_PortClient.GetEndpointAddress(EndpointConfiguration.companies_Port);
        }
        
        public enum EndpointConfiguration
        {
            
            companies_Port,
        }
    }
}
