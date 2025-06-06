using WowPacketParser.Misc;
using WowPacketParser.SQL;

namespace WowPacketParser.Store.Objects
{
    [Hotfix]
    [DBTableName("barber_shop_style")]
    public sealed record BarberShopStyleHotfix340: IDataModel
    {
        [DBFieldName("DisplayName")]
        public string DisplayName;

        [DBFieldName("Description")]
        public string Description;

        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("Type")]
        public byte? Type;

        [DBFieldName("CostModifier")]
        public float? CostModifier;

        [DBFieldName("Race")]
        public byte? Race;

        [DBFieldName("Sex")]
        public byte? Sex;

        [DBFieldName("Data")]
        public byte? Data;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }

    [Hotfix]
    [DBTableName("barber_shop_style_locale")]
    public sealed record BarberShopStyleLocaleHotfix340: IDataModel
    {
        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("locale", true)]
        public string Locale = ClientLocale.PacketLocaleString;

        [DBFieldName("DisplayName_lang")]
        public string DisplayNameLang;

        [DBFieldName("Description_lang")]
        public string DescriptionLang;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
    [Hotfix]
    [DBTableName("barber_shop_style")]
    public sealed record BarberShopStyleHotfix344: IDataModel
    {
        [DBFieldName("DisplayName")]
        public string DisplayName;

        [DBFieldName("Description")]
        public string Description;

        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("Type")]
        public byte? Type;

        [DBFieldName("CostModifier")]
        public float? CostModifier;

        [DBFieldName("Race")]
        public sbyte? Race;

        [DBFieldName("Sex")]
        public sbyte? Sex;

        [DBFieldName("Data")]
        public byte? Data;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }

    [Hotfix]
    [DBTableName("barber_shop_style_locale")]
    public sealed record BarberShopStyleLocaleHotfix344: IDataModel
    {
        [DBFieldName("ID", true)]
        public uint? ID;

        [DBFieldName("locale", true)]
        public string Locale = ClientLocale.PacketLocaleString;

        [DBFieldName("DisplayName_lang")]
        public string DisplayNameLang;

        [DBFieldName("Description_lang")]
        public string DescriptionLang;

        [DBFieldName("VerifiedBuild")]
        public int? VerifiedBuild = ClientVersion.BuildInt;
    }
}
