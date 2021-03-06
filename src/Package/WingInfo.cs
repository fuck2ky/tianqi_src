using ProtoBuf;
using System;
using System.ComponentModel;

namespace Package
{
	[ProtoContract(Name = "WingInfo")]
	[Serializable]
	public class WingInfo : IExtensible
	{
		private int _cfgId;

		private int _lv;

		private int _overdueUtc;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "cfgId", DataFormat = DataFormat.TwosComplement)]
		public int cfgId
		{
			get
			{
				return this._cfgId;
			}
			set
			{
				this._cfgId = value;
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "lv", DataFormat = DataFormat.TwosComplement)]
		public int lv
		{
			get
			{
				return this._lv;
			}
			set
			{
				this._lv = value;
			}
		}

		[ProtoMember(3, IsRequired = false, Name = "overdueUtc", DataFormat = DataFormat.TwosComplement), DefaultValue(0)]
		public int overdueUtc
		{
			get
			{
				return this._overdueUtc;
			}
			set
			{
				this._overdueUtc = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
