// <auto-generated>
// DO NOT EDIT
// </auto-generated>

using System.CodeDom.Compiler;
using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

namespace WowPacketParserModule.V11_0_0_55666.UpdateFields.V11_1_7_61491
{
    [GeneratedCode("UpdateFieldCodeGenerator.Formats.WowPacketParserHandler", "1.0.0.0")]
    public class ArenaCooldown : IArenaCooldown
    {
        public System.Nullable<int> SpellID { get; set; }
        public System.Nullable<int> Charges { get; set; }
        public System.Nullable<uint> Flags { get; set; }
        public System.Nullable<uint> StartTime { get; set; }
        public System.Nullable<uint> EndTime { get; set; }
        public System.Nullable<uint> NextChargeTime { get; set; }
        public System.Nullable<byte> MaxCharges { get; set; }
    }
}

