using ns16;
using ns18;
using ns19;
using ns20;
using ns21;
using System;

namespace ns17
{

    //This is probably the "speed boost" part of GHTCP

	public class zzFxBoost : QbEditor
	{
		private zzPakNode2 class318_0;

		private bool bool_0;

		public zzFxBoost(zzPakNode2 class318_1)
		{
			this.class318_0 = class318_1;
			StructItemQbKey @class = ((StructureHeaderNode)this.class318_0.zzGetNode1("scripts\\guitar\\guitar_events.qb").zzFindNode<StructItemQbKey>(new StructItemQbKey("event", "star_power_on")).Parent).zzFindNode<StructItemQbKey>(new StructItemQbKey("scr"));
			this.bool_0 = (@class.method_8() == "guitarevent_starpoweron");
		}

		public override void CreateCustomMenu()
		{
			zzGenericNode1 @class = this.class318_0.zzGetNode1("scripts\\guitar\\guitar_events.qb");
			((StructureHeaderNode)@class.zzFindNode<StructItemQbKey>(new StructItemQbKey("event", "star_power_on")).Parent).zzFindNode<StructItemQbKey>(new StructItemQbKey("scr")).method_9(this.bool_0 ? "guitarevent_starpoweroff" : "guitarevent_starpoweron");
			if (!this.bool_0)
			{
				@class.zzFindNode<ScriptRootNode>(new ScriptRootNode("hit_note_fx")).int_0 = QbSongClass1.smethod_9("hit_note_fx_empty");
				@class.zzFindNode<ScriptRootNode>(new ScriptRootNode("guitarevent_starsequencebonus")).int_0 = QbSongClass1.smethod_9("guitarevent_starsequencebonus_empty");
				@class.zzFindNode<ScriptRootNode>(new ScriptRootNode("guitarevent_multiplier4xon_spawned")).int_0 = QbSongClass1.smethod_9("guitarevent_multiplier4xon_spawned_empty");
				@class.zzFindNode<ScriptRootNode>(new ScriptRootNode("first_gem_fx")).int_0 = QbSongClass1.smethod_9("first_gem_fx_empty");
				@class.zzFindNode<ScriptRootNode>(new ScriptRootNode("hit_note_fx_original")).int_0 = QbSongClass1.smethod_9("hit_note_fx");
				@class.zzFindNode<ScriptRootNode>(new ScriptRootNode("guitarevent_starsequencebonus_original")).int_0 = QbSongClass1.smethod_9("guitarevent_starsequencebonus");
				@class.zzFindNode<ScriptRootNode>(new ScriptRootNode("guitarevent_multiplier4xon_spawned_original")).int_0 = QbSongClass1.smethod_9("guitarevent_multiplier4xon_spawned");
				@class.zzFindNode<ScriptRootNode>(new ScriptRootNode("first_gem_fx_original")).int_0 = QbSongClass1.smethod_9("first_gem_fx");
				return;
			}
			@class.zzFindNode<ScriptRootNode>(new ScriptRootNode("hit_note_fx")).int_0 = QbSongClass1.smethod_9("hit_note_fx_original");
			@class.zzFindNode<ScriptRootNode>(new ScriptRootNode("guitarevent_starsequencebonus")).int_0 = QbSongClass1.smethod_9("guitarevent_starsequencebonus_original");
			@class.zzFindNode<ScriptRootNode>(new ScriptRootNode("guitarevent_multiplier4xon_spawned")).int_0 = QbSongClass1.smethod_9("guitarevent_multiplier4xon_spawned_original");
			@class.zzFindNode<ScriptRootNode>(new ScriptRootNode("first_gem_fx")).int_0 = QbSongClass1.smethod_9("first_gem_fx_original");
			ScriptRootNode class2 = @class.zzFindNode<ScriptRootNode>(new ScriptRootNode("hit_note_fx_empty"));
			if (class2 != null)
			{
				class2.int_0 = QbSongClass1.smethod_9("hit_note_fx");
			}
			else
			{
				@class.addChild(new ScriptRootNode("hit_note_fx", "scripts\\guitar\\guitar_events.qb", new QbScriptNode()));
			}
			class2 = @class.zzFindNode<ScriptRootNode>(new ScriptRootNode("guitarevent_starsequencebonus_empty"));
			if (class2 != null)
			{
				class2.int_0 = QbSongClass1.smethod_9("guitarevent_starsequencebonus");
			}
			else
			{
				@class.addChild(new ScriptRootNode("guitarevent_starsequencebonus", "scripts\\guitar\\guitar_events.qb", new QbScriptNode()));
			}
			class2 = @class.zzFindNode<ScriptRootNode>(new ScriptRootNode("guitarevent_multiplier4xon_spawned_empty"));
			if (class2 != null)
			{
				class2.int_0 = QbSongClass1.smethod_9("guitarevent_multiplier4xon_spawned");
			}
			else
			{
				@class.addChild(new ScriptRootNode("guitarevent_multiplier4xon_spawned", "scripts\\guitar\\guitar_events.qb", new QbScriptNode()));
			}
			class2 = @class.zzFindNode<ScriptRootNode>(new ScriptRootNode("first_gem_fx_empty"));
			if (class2 != null)
			{
				class2.int_0 = QbSongClass1.smethod_9("first_gem_fx");
				return;
			}
			@class.addChild(new ScriptRootNode("first_gem_fx", "scripts\\guitar\\guitar_events.qb", new QbScriptNode()));
		}

		public override string ToString()
		{
			return (this.bool_0 ? "Apply" : "Remove") + " Speed Boost";
		}

		public override bool Equals(QbEditor other)
		{
			return other is zzFxBoost && (other as zzFxBoost).bool_0 == this.bool_0;
		}
	}
}
