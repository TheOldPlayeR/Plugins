using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Terraria;
using TerrariaApi.Server;
using TShockAPI;

namespace Suicide
{
	[ApiVersion(2,1)]
	
	public class Suicide : TerrariaPlugin
	{
		public override Version Version
		{
			get { return new Version(1,0); }
		}
		
		public override string Name
		{
			get { return "Suicide"; }
		}
		
		public override string Author
		{
			get { return "TheOldPlayeR"; }
		}
		
		public override string Description
		{
			get { return "A suicide plugin for those ragers"; }
		}
		
		public Suicide(Main game)
			: base(game)
		{
			Order = +4;
		}
		
		public override void Initialize()
		{
			Commands.ChatCommands.Add(new Command("suicide.suicide", suicide, "suicide", "die"));						
		}
		
		void suicide(CommandArgs args)
		{
			args.Player.KillPlayer();
		}
	}
}
		
