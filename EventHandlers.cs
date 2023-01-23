using MEC;
using Exiled.Events.EventArgs.Player;

namespace ClassBroadcast
{
    class EventHandlers
    {
        public void OnPlayerChangeRole(ChangingRoleEventArgs ev)
        {
            if (Plugin.Instance.Config.Class_Bc.TryGetValue(ev.NewRole, out string classBc))
            {
                if (Plugin.Instance.Config.BroadcastType.Contains("Broadcast"))
                {
                    ev.Player.Broadcast(Plugin.Instance.Config.BcTime, classBc);
                }
                else if (Plugin.Instance.Config.BroadcastType.Contains("Window"))
                {
                    Timing.CallDelayed(1f, () => ev.Player.OpenReportWindow(classBc));
                }
                else
                {
                    ev.Player.ShowHint(classBc, Plugin.Instance.Config.BcTime);
                }
            }
        }
    }
}
