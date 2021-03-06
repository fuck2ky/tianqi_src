using ProtoBuf;
using System;
using System.Collections.Generic;

namespace GameData
{
	[ProtoContract(Name = "TeShuWuPin_ARRAY")]
	[Serializable]
	public class TeShuWuPin_ARRAY : IExtensible
	{
		private readonly List<TeShuWuPin> _items = new List<TeShuWuPin>();

		private IExtension extensionObject;

		[ProtoMember(1, Name = "items", DataFormat = DataFormat.Default)]
		public List<TeShuWuPin> items
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
