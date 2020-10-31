using System;
using System.Collections;
using System.Collections.Generic;

namespace Phyros.Athena.Model.ProcessItems
{
	public interface IProcessItem
	{
		string ProcessItemId { get; }
		IReadOnlyDictionary<string, object> Data { get; }
	}
}
