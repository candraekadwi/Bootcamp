using System.Runtime.Serialization;

namespace Day27_Json_DataContract;

[DataContract]
public class Car
{
	[DataMember]
	public int year;
	[DataMember]
	public string? brand{get; set;}
	[DataMember]
	private int x=3;
}
