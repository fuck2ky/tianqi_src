using NetWork.Utilities;
using ProtoBuf;
using System;

namespace Package
{
	[ForRecv(4496), ForSend(4496), ProtoContract(Name = "GetBossKilledLogReq")]
	[Serializable]
	public class GetBossKilledLogReq : IExtensible
	{
		public static readonly short OP = 4496;

		private int _labelId;

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "labelId", DataFormat = DataFormat.TwosComplement)]
		public int labelId
		{
			get
			{
				return this._labelId;
			}
			set
			{
				this._labelId = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
