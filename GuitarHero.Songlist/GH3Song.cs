using ns15;
using ns18;
using ns19;
using ns20;
using ns21;
using System;
using System.Globalization;

namespace GuitarHero.Songlist
{
	[Serializable]
	public class GH3Song : Interface16
	{
		public bool editable;

		public bool visible = true;

		public bool leaderboard;

		public bool original_artist;

		public bool not_bass;

		public bool no_rhythm_track;

		public bool use_coop_notetracks;

		public bool keyboard;

		public float band_vol;

		public float guitar_vol;

		public float hammer_on;

		public int gem_offset;

		public int fretbar_offset;

		public int input_offset;

		public int version = 3;

		public string name = "";

		public string title = "";

		public string artist = "";

		public string year = "";

		public string countoff = "sticks_tiny";

		public string bassist = "Generic Bassist";

		public string singer = "";

		public string boss = "";

		public object artist_text = true;

		[NonSerialized]
		public static bool bool_0;

		public GH3Song()
		{
		}

		public GH3Song(StructurePointerNode class302_0)
		{
			this.vmethod_4(class302_0);
		}

		public GH3Song(string string_0)
		{
			this.title = string_0;
			this.name = string_0;
			this.leaderboard = true;
			this.editable = true;
		}

		public virtual void vmethod_0(Interface16 interface16_0)
		{
			if (interface16_0 is GH3Song)
			{
				GH3Song gH3Song = interface16_0 as GH3Song;
				this.original_artist = gH3Song.original_artist;
				this.not_bass = gH3Song.not_bass;
				this.no_rhythm_track = gH3Song.no_rhythm_track;
				this.use_coop_notetracks = gH3Song.use_coop_notetracks;
				this.keyboard = gH3Song.keyboard;
				this.band_vol = gH3Song.band_vol;
				this.guitar_vol = gH3Song.guitar_vol;
				this.hammer_on = gH3Song.hammer_on;
				this.gem_offset = gH3Song.gem_offset;
				this.fretbar_offset = gH3Song.fretbar_offset;
				this.input_offset = gH3Song.input_offset;
				this.version = gH3Song.version;
				this.title = gH3Song.title;
				this.artist = gH3Song.artist;
				this.year = gH3Song.year;
				this.countoff = gH3Song.countoff;
				this.bassist = gH3Song.bassist;
				this.singer = gH3Song.singer;
				this.boss = gH3Song.boss;
				this.artist_text = gH3Song.artist_text;
			}
		}

		public bool isEditable()
		{
			return this.editable;
		}

		public void setEditable(bool bool_1)
		{
			this.editable = bool_1;
		}

		public bool isVisible()
		{
			return this.visible;
		}

		public void setVisible(bool bool_1)
		{
			this.visible = bool_1;
		}

		public string getSongName()
		{
			return this.name;
		}

		public override string ToString()
		{
			if (GH3Song.bool_0 && this.title != null)
			{
				return this.title;
			}
			return this.name;
		}

		public virtual void vmethod_4(StructurePointerNode class302_0)
		{
			this.name = class302_0.zzFindNode<AsciiStructureNode>(new AsciiStructureNode("name")).method_8().ToLower();
			if (this.name != null && !this.name.Equals(""))
			{
				UnicodeStructureNode @class;
				this.title = (((@class = class302_0.zzFindNode<UnicodeStructureNode>(new UnicodeStructureNode("title"))) != null) ? @class.method_8() : "");
				this.artist = (((@class = class302_0.zzFindNode<UnicodeStructureNode>(new UnicodeStructureNode("artist"))) != null) ? @class.method_8() : "");
				this.year = (((@class = class302_0.zzFindNode<UnicodeStructureNode>(new UnicodeStructureNode("year"))) != null) ? @class.method_8() : "");
				this.bassist = (((@class = class302_0.zzFindNode<UnicodeStructureNode>(new UnicodeStructureNode("bassist"))) != null) ? CultureInfo.CurrentCulture.TextInfo.ToTitleCase(@class.method_8()) : "Generic Bassist");
				AsciiStructureNode class2;
				this.countoff = (((class2 = class302_0.zzFindNode<AsciiStructureNode>(new AsciiStructureNode("countoff"))) != null) ? class2.method_8() : "");
				FloatStructureNode class3;
				this.band_vol = (((class3 = class302_0.zzFindNode<FloatStructureNode>(new FloatStructureNode("band_playback_volume"))) != null) ? class3.method_8() : 0f);
				this.guitar_vol = (((class3 = class302_0.zzFindNode<FloatStructureNode>(new FloatStructureNode("guitar_playback_volume"))) != null) ? class3.method_8() : 0f);
				this.hammer_on = (((class3 = class302_0.zzFindNode<FloatStructureNode>(new FloatStructureNode("hammer_on_measure_scale"))) != null) ? class3.method_8() : 0f);
				IntegerStructureNode class4;
				this.gem_offset = (((class4 = class302_0.zzFindNode<IntegerStructureNode>(new IntegerStructureNode("gem_offset"))) != null) ? class4.method_8() : 0);
				this.fretbar_offset = (((class4 = class302_0.zzFindNode<IntegerStructureNode>(new IntegerStructureNode("fretbar_offset"))) != null) ? class4.method_8() : 0);
				this.input_offset = (((class4 = class302_0.zzFindNode<IntegerStructureNode>(new IntegerStructureNode("input_offset"))) != null) ? class4.method_8() : 0);
				this.original_artist = ((class4 = class302_0.zzFindNode<IntegerStructureNode>(new IntegerStructureNode("original_artist"))) != null && class4.method_8() == 1);
				this.leaderboard = ((class4 = class302_0.zzFindNode<IntegerStructureNode>(new IntegerStructureNode("leaderboard"))) != null && class4.method_8() == 1);
				this.not_bass = ((class4 = class302_0.zzFindNode<IntegerStructureNode>(new IntegerStructureNode("rhythm_track"))) != null && class4.method_8() == 1);
				StructItemQbKey class5;
				this.keyboard = ((class5 = class302_0.zzFindNode<StructItemQbKey>(new StructItemQbKey("keyboard"))) != null && class5.method_8() == "true");
				this.singer = (((class5 = class302_0.zzFindNode<StructItemQbKey>(new StructItemQbKey("singer"))) != null) ? class5.method_8() : "");
				this.boss = (((class5 = class302_0.zzFindNode<StructItemQbKey>(new StructItemQbKey("boss"))) != null) ? class5.method_8() : "");
				this.version = (((class5 = class302_0.zzFindNode<StructItemQbKey>(new StructItemQbKey("version"))) != null) ? Convert.ToInt32(string.Concat(class5.method_8()[2])) : 3);
				this.use_coop_notetracks = (class302_0.zzFindNode<StructItemQbKey>(new StructItemQbKey(0, "use_coop_notetracks")) != null);
				this.no_rhythm_track = (class302_0.zzFindNode<StructItemQbKey>(new StructItemQbKey(0, "no_rhythm_track")) != null);
				try
				{
					this.artist_text = class302_0.zzFindNode<FileTagStructureNode>(new FileTagStructureNode("artist_text")).method_8().Equals("artist_text_by");
					return;
				}
				catch
				{
					this.artist_text = (((@class = class302_0.zzFindNode<UnicodeStructureNode>(new UnicodeStructureNode("artist_text"))) != null) ? @class.method_8() : "by");
					return;
				}
			}
			throw new Exception("songlist.qb");
		}

		public virtual StructurePointerNode vmethod_5()
		{
			StructureHeaderNode @class = new StructureHeaderNode();
			@class.addChild(new StructItemQbKey("checksum", this.name));
			@class.addChild(new AsciiStructureNode("name", this.name));
			@class.addChild(new UnicodeStructureNode("title", this.title));
			@class.addChild(new UnicodeStructureNode("artist", this.artist.Equals("") ? " " : this.artist));
			@class.addChild(new UnicodeStructureNode("year", this.year.Equals("") ? " " : this.year));
			if (this.artist_text is bool)
			{
				@class.addChild(new FileTagStructureNode("artist_text", ((bool)this.artist_text) ? "artist_text_by" : "artist_text_as_made_famous_by"));
			}
			else if (this.artist_text is string)
			{
				@class.addChild(new UnicodeStructureNode("artist_text", (string)this.artist_text));
			}
			@class.addChild(new IntegerStructureNode("original_artist", this.original_artist ? 1 : 0));
			if (this.version == 0)
			{
				this.version = 3;
			}
			@class.addChild(new StructItemQbKey("version", "gh" + this.version));
			@class.addChild(new IntegerStructureNode("leaderboard", this.leaderboard ? 1 : 0));
			if (this.gem_offset != 0)
			{
				@class.addChild(new IntegerStructureNode("gem_offset", this.gem_offset));
			}
			if (this.fretbar_offset != 0)
			{
				@class.addChild(new IntegerStructureNode("fretbar_offset", this.fretbar_offset));
			}
			if (this.input_offset != 0)
			{
				@class.addChild(new IntegerStructureNode("input_offset", this.input_offset));
			}
			if (!this.singer.Equals(""))
			{
				@class.addChild(new StructItemQbKey("singer", this.singer));
			}
			if (!this.boss.Equals(""))
			{
				@class.addChild(new StructItemQbKey("boss", this.boss));
			}
			if (!this.keyboard)
			{
				@class.addChild(new StructItemQbKey("keyboard", "false"));
			}
			if (!this.bassist.Equals("Generic Bassist"))
			{
				@class.addChild(new UnicodeStructureNode("bassist", this.bassist));
			}
			if (!this.countoff.Equals(""))
			{
				@class.addChild(new AsciiStructureNode("countoff", this.countoff));
			}
			@class.addChild(new IntegerStructureNode("rhythm_track", this.not_bass ? 1 : 0));
			if (this.band_vol != 0f)
			{
				@class.addChild(new FloatStructureNode("band_playback_volume", this.band_vol));
			}
			if (this.guitar_vol != 0f)
			{
				@class.addChild(new FloatStructureNode("guitar_playback_volume", this.guitar_vol));
			}
			if (this.hammer_on != 0f)
			{
				@class.addChild(new FloatStructureNode("hammer_on_measure_scale", this.hammer_on));
			}
			if (this.use_coop_notetracks)
			{
				@class.addChild(new StructItemQbKey(0, "use_coop_notetracks"));
			}
			if (this.no_rhythm_track)
			{
				@class.addChild(new StructItemQbKey(0, "no_rhythm_track"));
			}
			return new StructurePointerNode(this.name, @class);
		}
	}
}
