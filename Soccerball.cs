using System.Drawing;
using CounterStrikeSharp.API;
using CounterStrikeSharp.API.Core;
using CounterStrikeSharp.API.Core.Attributes.Registration;
using CounterStrikeSharp.API.Modules.Admin;
using CounterStrikeSharp.API.Modules.Commands;
using CounterStrikeSharp.API.Modules.Utils;

namespace Soccerball;
public class Soccerball : BasePlugin
{
    public override string ModuleName => "Soccerball by Newix";

    public override string ModuleVersion => "0.0.2";


    [ConsoleCommand("sb_rgb", "Spawn soccerball from RGB color")]
    [RequiresPermissions("@css/root")]
    public void OnCommandCustom(CCSPlayerController? player, CommandInfo command)
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

        int r = Int32.Parse(command.ArgByIndex(1));
        int g = Int32.Parse(command.ArgByIndex(2));
        int b = Int32.Parse(command.ArgByIndex(3));

        entity.Render = Color.FromArgb(r, g, b);

        entity.DispatchSpawn();
    }

    [ConsoleCommand("sb", "Spawn soccerball")]
    [ConsoleCommand("sb1", "Spawn soccerball")]
    [RequiresPermissions("@css/root")]
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

    [ConsoleCommand("sb2", "Spawn soccerball with Aqua color")]
    [RequiresPermissions("@css/root")]
    public void OnCommand2(CCSPlayerController? player, CommandInfo command)
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

        entity.Render = Color.Aqua;

        entity.DispatchSpawn();
    }

    [ConsoleCommand("sb3", "Spawn soccerball")]
    public void OnCommand3(CCSPlayerController? player, CommandInfo command)
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

        entity.Render = Color.BlueViolet;

        entity.DispatchSpawn();
    }

    [ConsoleCommand("sb4", "Spawn soccerball")]
    public void OnCommand4(CCSPlayerController? player, CommandInfo command)
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

        entity.Render = Color.Blue;

        entity.CBodyComponent.SceneNode.GetSkeletonInstance().Scale = 20;

        entity.DispatchSpawn();
    }

    [ConsoleCommand("sb5", "Spawn soccerball")]
    public void OnCommand5(CCSPlayerController? player, CommandInfo command)
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

        entity.Render = Color.Gold;

        entity.DispatchSpawn();
    }

    [ConsoleCommand("sb6", "Spawn soccerball")]
    public void OnCommand6(CCSPlayerController? player, CommandInfo command)
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

        entity.Render = Color.Green;

        entity.DispatchSpawn();
    }

        [ConsoleCommand("sb7", "Spawn soccerball")]
    public void OnCommand7(CCSPlayerController? player, CommandInfo command)
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

        entity.Render = Color.Magenta;

        entity.DispatchSpawn();
    }

    [ConsoleCommand("sb8", "Spawn soccerball")]
    public void OnCommand8(CCSPlayerController? player, CommandInfo command)
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

        entity.Render = Color.Pink;

        entity.DispatchSpawn();
    }

    [ConsoleCommand("sb9", "Spawn soccerball")]
    public void OnCommand9(CCSPlayerController? player, CommandInfo command)
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

        entity.Render = Color.Orange;

        entity.DispatchSpawn();
    }

        [ConsoleCommand("sb10", "Spawn soccerball")]
    public void OnCommand10(CCSPlayerController? player, CommandInfo command)
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

        entity.Render = Color.Silver;

        entity.DispatchSpawn();
    }
}