//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OpenNos.DAL.EF.MySQL.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Respawn
    {
        public long RespawnId { get; set; }
        public short X { get; set; }
        public short Y { get; set; }
        public short MapId { get; set; }
        public short TeleportType { get; set; }
        public long CharacterId { get; set; }
    
        public virtual Character character { get; set; }
    }
}
