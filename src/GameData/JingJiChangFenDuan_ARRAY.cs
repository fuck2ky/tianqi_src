using ProtoBuf;
using System;
using System.Collections.Generic;

namespace GameData
{
	[ProtoContract(Name = "JingJiChangFenDuan_ARRAY")]
	[Serializable]
	public class JingJiChangFenDuan_ARRAY : IExtensible
	{
		private readonly List<JingJiChangFenDuan> _items = new List<JingJiChangFenDuan>();

		private IExtension extensionObject;

		[ProtoMember(1, Name = "items", DataFormat = DataFormat.Default)]
		public List<JingJiChangFenDuan> items
		{
			get
			{
				return this._items;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
