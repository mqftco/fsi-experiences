//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.CloudForFSI.OptionSets
{
    using Microsoft.CloudForFSI.Tables;

    [System.Runtime.Serialization.DataContractAttribute()]
	public enum EnvironmentVariableDefinition_Type
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Boolean", 2, "#0000ff")]
		Boolean = 100000002,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Data Source", 4, "#0000ff")]
		DataSource = 100000004,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("JSON", 3, "#0000ff")]
		JSON = 100000003,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Number", 1, "#0000ff")]
		Number = 100000001,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("Secret", 5, "#0000ff")]
		Secret = 100000005,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		[OptionSetMetadataAttribute("String", 0, "#0000ff")]
		String = 100000000,
	}
}