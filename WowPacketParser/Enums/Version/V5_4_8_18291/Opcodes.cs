using WowPacketParser.Misc;

namespace WowPacketParser.Enums.Version.V5_4_8_18291
{
    public static class Opcodes_5_4_8
    {
        public static BiDictionary<Opcode, int> Opcodes()
        {
            return Opcs;
        }

        private static readonly BiDictionary<Opcode, int> Opcs = new BiDictionary<Opcode, int>
        {
            {Opcode.CMSG_AREATRIGGER, 0x1C44}, // 18291
            {Opcode.CMSG_AUCTION_HELLO, 0x0379}, // 18291
            {Opcode.CMSG_AUTH_SESSION, 0x00B2}, // 18291
            {Opcode.CMSG_BANKER_ACTIVATE, 0x02E9}, // 18291
            {Opcode.CMSG_BUY_BANK_SLOT, 0x12F2}, // 18291
            {Opcode.CMSG_GAMEOBJ_REPORT_USE, 0x6D9}, // 18291
            {Opcode.CMSG_GAMEOBJ_USE, 0x6D8}, // 18291
            {Opcode.CMSG_GOSSIP_HELLO, 0x12F3}, // 18291
            {Opcode.CMSG_LIST_INVENTORY, 0x02D8}, // 18291
            {Opcode.CMSG_RANDOMIZE_CHAR_NAME, 0x0B1C}, // 18414
            {Opcode.CMSG_CHAR_CREATE, 0x0F1D}, // 18414
            {Opcode.CMSG_READY_FOR_ACCOUNT_DATA_TIMES, 0x031C}, // 18414
            {Opcode.CMSG_CHAR_ENUM, 0x00E0}, // 18414
			
            {Opcode.SMSG_AUCTION_HELLO, 0x10A7}, // 18291
            {Opcode.SMSG_AUTH_CHALLENGE, 0x0949}, // 18291
            {Opcode.SMSG_AUTH_RESPONSE, 0x0ABA}, // 18291
            {Opcode.SMSG_CREATURE_QUERY_RESPONSE, 0x048B}, // 18291
            {Opcode.SMSG_DESTROY_OBJECT, 0x14C2}, // 18291
            {Opcode.SMSG_GAMEOBJECT_QUERY_RESPONSE, 0x06BF}, // 18291
            {Opcode.SMSG_GOSSIP_POI, 0x0785}, // 18291
            {Opcode.SMSG_INITIAL_SPELLS, 0x045A}, // 18291
            {Opcode.SMSG_LOGIN_VERIFY_WORLD, 0x1C0F}, // 18291
            {Opcode.SMSG_SHOW_BANK, 0x0007}, // 18291
            {Opcode.SMSG_NEW_WORLD, 0x1C3B},  // 18291
            {Opcode.SMSG_TRANSFER_PENDING, 0x061B}, // 18291
            {Opcode.SMSG_UPDATE_OBJECT, 0x1792}, // 18291
            {Opcode.SMSG_RANDOMIZE_CHAR_NAME, 0x169F}, // 18414
            {Opcode.SMSG_CHAR_CREATE, 0x1CAA}, // 18414
            {Opcode.SMSG_ACCOUNT_DATA_TIMES, 0x162B}, //18414
            {Opcode.SMSG_SET_TIMEZONE_INFORMATION, 0x19C1}, // 18414
            {Opcode.SMSG_CHAR_ENUM, 0x11C3}, // 18414
			
        };
    }
}
