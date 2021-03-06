using GuitarHero.Songlist;
using ns16;
using ns19;
using ns20;
using System;

namespace ns17
{
	public class UpdateSetlistSwitcher : QbEditor
	{
		private GH3Songlist gh3Songlist_0;

		private zzPakNode2 class318_0;

		private bool bool_0;

		public UpdateSetlistSwitcher(zzPakNode2 class318_1, GH3Songlist gh3Songlist_1, bool bool_1)
		{
			this.class318_0 = class318_1;
			this.gh3Songlist_0 = gh3Songlist_1;
			this.bool_0 = bool_1;
		}

		public override void CreateCustomMenu()
		{
			zzGenericNode1 @class = this.class318_0.zzGetNode1("scripts\\guitar\\custom_menu\\guitar_custom_menu_setlist_switcher.qb");
			@class.zzFindNode<ArrayPointerRootNode>(new ArrayPointerRootNode("custom_menu_setlist_switcher_progressions_" + (this.bool_0 ? "gha" : "gh3"))).method_8(this.gh3Songlist_0.method_7());
		}

		public override string ToString()
		{
			return "Update Setlist Switcher";
		}

		public override bool Equals(QbEditor other)
		{
			return other is UpdateSetlistSwitcher;
		}
	}
}
