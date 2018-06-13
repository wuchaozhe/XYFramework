using System;

namespace XYFramework.Data
{
	public interface IEntityFactory
	{
		object Create(Type type);
	}
}
