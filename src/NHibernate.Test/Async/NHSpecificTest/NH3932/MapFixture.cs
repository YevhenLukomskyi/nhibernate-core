﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by AsyncGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


using NHibernate.Test.NHSpecificTest.NH3932.Model;

namespace NHibernate.Test.NHSpecificTest.NH3932
{
	using System.Threading.Tasks;
	public class MapFixtureAsync : FixtureAsync
	{
		protected override bool CareAboutOrder => false;

		protected override IParent CreateParent(int numberOfChildren)
		{
			var parent = new MapParent();
			for (var i = 0; i < numberOfChildren; i++)
			{
				parent.Children.Add(i, new Child{Name="child" + i});
			}
			return parent;
		}
	}
}