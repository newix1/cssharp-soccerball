using System.Drawing;
using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Commands;
using CounterStrikeSharp.API.Modules.Utils;

namespace Soccerball;
public class Soccerball : BasePlugin
{
    public override string ModuleName => "Soccerball by Newix";

    public override string ModuleVersion => "0.0.1";

    [ConsoleCommand("sb", "Spawn soccerball")]
    public void OnCommand(CCSPlayerController? player, CommandInfo command)
    {
        var entity = Utilities.CreateEntityByName<CPhysicsPropMultiplayer>("prop_physics_multiplayer");

        if (entity == null || !entity.IsValid)
        {
            return;
        }

        entity.Teleport(
            new Vector(
                player.PlayerPawn.Value!.AbsOrigin!.X,
                player.PlayerPawn.Value!.AbsOrigin!.Y,
                player.PlayerPawn.Value!.AbsOrigin!.Z
            ),
            player.PlayerPawn.Value!.EyeAngles,
            player.PlayerPawn.Value!.AbsVelocity
        );

        entity.SetModel("models/props/de_dust/hr_dust/dust_soccerball/dust_soccer_ball001.vmdl");

        entity.Render = Color.Red;

        entity.DispatchSpawn();
    }

}