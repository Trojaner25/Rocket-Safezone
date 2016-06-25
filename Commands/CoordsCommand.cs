﻿using System.Collections.Generic;
using Rocket.API;
using Rocket.Unturned.Chat;
using Safezone.Util;
using UnityEngine;

namespace Safezone.Commands
{
    public class CoordsCommand : IRocketCommand
    {
        public void Execute(IRocketPlayer caller, string[] command)
        {
            var player = PlayerUtil.GetUnturnedPlayer(caller);
            var pos = player.Position;
            UnturnedChat.Say(caller, $"Position: X: {pos.x}, Y: {pos.y}, Z: {pos.z}; + Rotation: {player.Player.transform.rotation.eulerAngles.y}", Color.green);
        }

        public string Name => "coords";

        public string Help => "Shows your current position";

        public string Syntax => "";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "safezones.coords" };

        public AllowedCaller AllowedCaller => AllowedCaller.Player;
    }
}