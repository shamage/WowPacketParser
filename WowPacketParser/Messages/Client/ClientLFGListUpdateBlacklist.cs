using WowPacketParser.Messages.Submessages;

namespace WowPacketParser.Messages.Client
{
    public unsafe struct ClientLFGListUpdateBlacklist
    {
        public LFGListBlacklist Blacklist;
    }
}