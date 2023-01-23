<a href="https://github.com/Mikihero/ClassBroadcastReborn2/releases"><img src="https://img.shields.io/github/downloads/Mikihero/ClassBroadcastReborn2/total?label=Downloads" alt="Downloads"></a>
# ClassBcReborn2 v1.0.0
Send a broadcast or hint to chosen classes on spawn.

`Requires EXILED 6.0.0-beta.25`

# Default config:
```yml
class_broadcast:
  # Is enabled?
  is_enabled: true
  # Show debug lines?
  debug: false
  # Broadcast, Hint or Window (if not specified correctly, it will default to hint)
  broadcast_type: Window
  # Duration of the broadcast
  bc_time: 7
  # Set broadcast text for different classes.
  class_bc:
    ClassD: <color=#EE7600>Dboiiiiii</color>
    Scp049: You are <color=#318504>Doctor</color>
    Scp173: Haha matthew goes brrrr
```