using ProtoBuf;
using System;
using System.ComponentModel;

namespace GameData
{
	[ProtoContract(Name = "ShiTiPengZhuangBiao")]
	[Serializable]
	public class ShiTiPengZhuangBiao : IExtensible
	{
		private int _id;

		private int _layer;

		private IExtension extensionObject;

		[ProtoMember(2, IsRequired = true, Name = "id", DataFormat = DataFormat.TwosComplement)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}

		[ProtoMember(3, IsRequired = false, Name = "layer", DataFormat = DataFormat.TwosComplement), DefaultValue(0)]
		public int layer
		{
			get
			{
				return this._layer;
			}
			set
			{
				this._layer = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
