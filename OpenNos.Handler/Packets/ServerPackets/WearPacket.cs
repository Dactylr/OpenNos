﻿/////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)
using OpenNos.Core;

namespace OpenNos.Handler.Packets.ServerPackets
{
    [Header("wear")]
    public class WearjPacket : PacketBase
    {
        #region Properties

        [PacketIndex(0)]
        public byte Inventory { get; set; }

        [PacketIndex(1)]
        public byte InventorySlot { get; set; }

        #endregion
    }
}
