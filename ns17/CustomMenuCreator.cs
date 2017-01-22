using ns16;
using ns18;
using ns19;
using ns20;
using ns21;
using System;

namespace ns17
{
	public class CustomMenuCreator : QbEditor
	{
		private zzPakNode2 zzQbPak;

		private bool created;

		private bool isGHA;

		public CustomMenuCreator(zzPakNode2 zzQbPak, bool isGHA)
		{
			this.zzQbPak = zzQbPak;
			this.isGHA = isGHA;
		}

		public override void CreateCustomMenu()
		{
			Console.WriteLine("-=- " + this.ToString() + " -=-");
			if (!this.created)
			{
				this.created = this.zzQbPak.zzQbFileExists("scripts\\guitar\\custom_menu\\guitar_custom_menu.qb");
			}
			if (!this.created)
			{
				Console.WriteLine("Creating Custom Menu.");
				this.zzQbPak.zzCreateQbFileFrom("scripts\\guitar\\custom_menu\\guitar_custom_menu.qb", zzEmbeddedResourceDB.unpackQbFile("guitar_custom_menu"));
				this.zzQbPak.zzCreateQbFileFrom("scripts\\guitar\\custom_menu\\guitar_custom_gem_scale.qb", zzEmbeddedResourceDB.unpackQbFile("guitar_custom_gem_scale"));
				this.zzQbPak.zzCreateQbFileFrom("scripts\\guitar\\custom_menu\\guitar_custom_menu_credits.qb", zzEmbeddedResourceDB.unpackQbFile("guitar_custom_menu_credits"));
				this.zzQbPak.zzCreateQbFileFrom("scripts\\guitar\\custom_menu\\guitar_custom_menu_cutoff_viewer.qb", zzEmbeddedResourceDB.unpackQbFile("guitar_custom_menu_cutoff_viewer"));
				this.zzQbPak.zzCreateQbFileFrom("scripts\\guitar\\custom_menu\\guitar_custom_menu_gfx_options.qb", zzEmbeddedResourceDB.unpackQbFile("guitar_custom_menu_gfx_options"));
				this.zzQbPak.zzCreateQbFileFrom("scripts\\guitar\\custom_menu\\guitar_custom_menu_setlist_switcher.qb", zzEmbeddedResourceDB.unpackQbFile("guitar_custom_menu_setlist_switcher"));
				zzGenericNode1 activeQbFile = this.zzQbPak.zzGetNode1(this.isGHA ? "scripts\\guitar\\menu\\menu_main.qb" : "scripts\\guitar\\guitar_menu.qb");
				zzEmbeddedResourceDB.unpackQbScriptTo(activeQbFile.zzFindNode<ScriptRootNode>(new ScriptRootNode("create_main_menu")));
				activeQbFile = this.zzQbPak.zzGetNode1("scripts\\guitar\\guitar_progression.qb");
				zzEmbeddedResourceDB.unpackQbScriptTo(activeQbFile.zzFindNode<ScriptRootNode>(new ScriptRootNode("get_progression_globals")));
				activeQbFile = this.zzQbPak.zzGetNode1("scripts\\guitar\\guitar_gems.qb");
				zzEmbeddedResourceDB.unpackQbScriptTo(activeQbFile.zzFindNode<ScriptRootNode>(new ScriptRootNode("load_venue")));
				zzEmbeddedResourceDB.unpackQbScriptTo(activeQbFile.zzFindNode<ScriptRootNode>(new ScriptRootNode("start_gem_scroller")));
				zzEmbeddedResourceDB.unpackQbScriptTo(activeQbFile.zzFindNode<ScriptRootNode>(new ScriptRootNode("kill_gem_scroller")));
				activeQbFile = this.zzQbPak.zzGetNode1("scripts\\guitar\\guitar_events.qb");
				zzEmbeddedResourceDB.unpackQbScriptTo(activeQbFile.zzFindNode<ScriptRootNode>(new ScriptRootNode("guitarevent_songwon_spawned")));
				activeQbFile = this.zzQbPak.zzGetNode1("scripts\\game\\net\\guitar_net.qb");
				zzEmbeddedResourceDB.unpackQbScriptTo(activeQbFile.zzFindNode<ScriptRootNode>(new ScriptRootNode("net_write_single_player_stats")));
				activeQbFile = this.zzQbPak.zzGetNode1("scripts\\guitar\\guitar_globaltags.qb");
				zzEmbeddedResourceDB.unpackQbScriptTo(activeQbFile.zzFindNode<ScriptRootNode>(new ScriptRootNode("setup_globaltags")));
				zzEmbeddedResourceDB.unpackQbScriptTo(activeQbFile.zzFindNode<ScriptRootNode>(new ScriptRootNode("setup_songtags")));
				zzEmbeddedResourceDB.unpackQbScriptTo(activeQbFile.zzFindNode<ScriptRootNode>(new ScriptRootNode("push_bandtags")));
				activeQbFile = this.zzQbPak.zzGetNode1("scripts\\guitar\\menu\\menu_credits.qb");
				zzEmbeddedResourceDB.unpackQbScriptTo(activeQbFile.zzFindNode<ScriptRootNode>(new ScriptRootNode("scrolling_list_add_item")));
				if (!this.isGHA)
				{
					zzEmbeddedResourceDB.unpackQbScriptTo(activeQbFile.zzFindNode<ScriptRootNode>(new ScriptRootNode("start_team_photos")));
				}
				if (this.isGHA)
				{
					activeQbFile = this.zzQbPak.zzGetNode1("scripts\\guitar\\custom_menu\\guitar_custom_menu_cutoff_viewer.qb");
					zzEmbeddedResourceDB.unpackQbScriptTo(activeQbFile.zzFindNode<ScriptRootNode>(new ScriptRootNode("custom_menu_cutoff_viewer_create_paper")));
					zzEmbeddedResourceDB.unpackQbScriptTo(activeQbFile.zzFindNode<ScriptRootNode>(new ScriptRootNode("custom_menu_cutoff_viewer_create_poster")));
				}
				activeQbFile = this.zzQbPak.zzGetNode1("scripts\\guitar\\menu\\main_menu_flow.qb");
				StructureHeaderNode customMenuFS = new StructureHeaderNode();
				customMenuFS.addChild(new StructItemQbKey("action", "select_custom_menu"));
				customMenuFS.addChild(new StructItemQbKey("flow_state", "custom_menu_fs"));
				customMenuFS.addChild(new StructItemQbKey(0, "transition_right"));
				activeQbFile.zzFindNode<StructurePointerRootNode>(new StructurePointerRootNode("main_menu_fs")).zzFindNode<ArrayPointerNode>(new ArrayPointerNode("actions")).GetFirstChild().addChild(customMenuFS);
			}
		}

		public override string ToString()
		{
			return "Create Custom Menu";
		}

		public override bool Equals(QbEditor other)
		{
			return other is CustomMenuCreator;
		}
	}
}
