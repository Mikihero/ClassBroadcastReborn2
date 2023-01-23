using Exiled.API.Features;
using System;

namespace ClassBroadcast
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "ClassBroadcastReborn2";
        public override string Author => "VersLugia, updated by Miki_hero";
        public override Version Version => new Version(1,2,0,0);
        public override Version RequiredExiledVersion => new Version(6, 0, 0,0);

        public static Plugin Instance;
        private EventHandlers _eventHandlers;

        public override void OnEnabled()
        {
            Instance = this;
            _eventHandlers = new EventHandlers();
            Exiled.Events.Handlers.Player.ChangingRole += _eventHandlers.OnPlayerChangeRole;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.ChangingRole -= _eventHandlers.OnPlayerChangeRole;
            _eventHandlers = null;
            Instance = null;
            base.OnDisabled();
        }
    }
}