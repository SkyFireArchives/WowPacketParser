﻿using System;
using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;

namespace WowPacketParserModule.V5_4_8_18291.Parsers
{
    public static class QuestHandler
    {
        [Parser(Opcode.CMSG_QUEST_POI_QUERY)]
        public static void HandleQuestPoiQuery(Packet packet)
        {
            if (packet.Direction == Direction.ClientToServer)
            {
                packet.ReadToEnd();
            }
            else
            {
                packet.WriteLine("              : SMSG_UNK_10C2");
                packet.ReadToEnd();
            }
        }

        [Parser(Opcode.CMSG_QUESTGIVER_QUERY_QUEST)]
        public static void HandleQuestgiverQueryQuest(Packet packet)
        {
            packet.ReadToEnd();
        }

        [Parser(Opcode.CMSG_QUESTLOG_REMOVE_QUEST)]
        public static void HandleQuestlogRemoveQuest(Packet packet)
        {
            packet.ReadByte("Slot");
        }

        [Parser(Opcode.CMSG_QUESTGIVER_STATUS_QUERY)]
        public static void HandleQuestgiverStatusQuery(Packet packet)
        {
            var guid = packet.StartBitStream(4, 3, 2, 1, 0, 5, 7, 6);
            packet.ParseBitStream(guid, 5, 7, 4, 0, 2, 1, 6, 3);

            packet.WriteGuid("NPC Guid", guid);
        }

        [Parser(Opcode.SMSG_QUEST_POI_QUERY_RESPONSE)]
        public static void HandleQuestPoiQueryResponse(Packet packet)
        {
            packet.ReadToEnd();
        }

        [Parser(Opcode.SMSG_QUEST_QUERY_RESPONSE)]
        public static void HandleQuestQueryResp(Packet packet)
        {
            if (packet.Direction == Direction.ServerToClient)
            {
                packet.ReadToEnd();
            }
            else
            {
                packet.WriteLine("              : CMSG_NULL_0276");
            }
        }


        [Parser(Opcode.CMSG_QUEST_QUERY)]
        [Parser(Opcode.CMSG_QUESTGIVER_ACCEPT_QUEST)]
        [Parser(Opcode.CMSG_QUESTGIVER_CHOOSE_REWARD)]
        [Parser(Opcode.CMSG_QUESTGIVER_COMPLETE_QUEST)]
        [Parser(Opcode.CMSG_QUESTGIVER_HELLO)]
        [Parser(Opcode.CMSG_QUESTGIVER_REQUEST_REWARD)]
        [Parser(Opcode.SMSG_QUEST_CONFIRM_ACCEPT)]
        [Parser(Opcode.SMSG_QUESTGIVER_OFFER_REWARD)]
        [Parser(Opcode.SMSG_QUESTGIVER_QUEST_COMPLETE)]
        [Parser(Opcode.SMSG_QUESTGIVER_QUEST_DETAILS)]
        [Parser(Opcode.SMSG_QUESTGIVER_QUEST_LIST)]
        [Parser(Opcode.SMSG_QUESTGIVER_REQUEST_ITEMS)]
        [Parser(Opcode.SMSG_QUESTGIVER_STATUS)]
        [Parser(Opcode.SMSG_QUESTGIVER_STATUS_MULTIPLE)]
        [Parser(Opcode.SMSG_QUESTLOG_FULL)]
        [Parser(Opcode.SMSG_QUESTUPDATE_ADD_KILL)]
        [Parser(Opcode.SMSG_QUESTUPDATE_COMPLETE)]
        public static void HandleQuestgiverStatus(Packet packet)
        {
            packet.ReadToEnd();
        }
    }
}
