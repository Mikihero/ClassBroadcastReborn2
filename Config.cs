using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using PlayerRoles;

namespace ClassBroadcast
{
    public class Config : IConfig
    {
        [Description("Is enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Show debug lines?")] 
        public bool Debug { get; set; } = false;

        [Description("Broadcast, Hint or Window (if not specified correctly, it will default to hint)")]
        public string BroadcastType { get; set; } = "Hint";

        [Description("Duration of the broadcast.")]
        public ushort BcTime { get; set; } = 7;

        [Description("Set broadcast text for different classes.")]
        public Dictionary<RoleTypeId, string> Class_Bc { get; set; } = new Dictionary<RoleTypeId, string>
        {
            [RoleTypeId.ClassD] = "<color=#EE7600>Dboiiiiii</color>",
            [RoleTypeId.Scp049] = "You are <color=#318504>Doctor</color>",
            [RoleTypeId.Scp173] = "Haha matthew goes brrrr",
        }; 
    }
}