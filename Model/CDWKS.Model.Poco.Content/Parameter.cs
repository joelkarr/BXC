//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;

namespace CDWKS.Model.Poco.Content
{
    [DataContract]
    public class Parameter
    {
        [DataMember]
        public  int Id
        {
            get;
            set;
        }
        [DataMember]
        public  bool Featured
        {
            get;
            set;
        }
        [DataMember]
        public  bool Hidden
        {
            get;
            set;
        }
        [DataMember]
        public Item Item { get; set; }
        [DataMember]
        public SearchName SearchName { get; set; }
        [DataMember]
        public SearchValue SearchValue { get; set; }
    	

       
    }
}