
#region ================== Copyright (c) 2007 Pascal vd Heiden

/*
 * Copyright (c) 2007 Pascal vd Heiden, www.codeimp.com
 * This program is released under GNU General Public License
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 */

#endregion

#region ================== Namespaces

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Drawing;
using System.ComponentModel;
using CodeImp.DoomBuilder.Map;
using SlimDX.Direct3D9;
using SlimDX;
using CodeImp.DoomBuilder.Geometry;
using System.Drawing.Imaging;
using CodeImp.DoomBuilder.Data;
using CodeImp.DoomBuilder.Editing;
using CodeImp.DoomBuilder.IO;
using CodeImp.DoomBuilder.Rendering;

#endregion

namespace CodeImp.DoomBuilder.VisualModes
{
	public abstract class VisualSidedef : VisualGeometry
	{
		#region ================== Constants

		#endregion

		#region ================== Variables

		// Original sidedef
		private Sidedef sidedef;

		// Intersection point for current pick test
		protected Vector3D pickintersect;
		protected float pickrayu;
		
		#endregion

		#region ================== Properties

		public Sidedef Sidedef { get { return sidedef; } }

		#endregion

		#region ================== Constructor / Disposer

		// Constructor
		public VisualSidedef(Sidedef sd)
		{
			// Initialize
			this.sidedef = sd;
		}
		
		#endregion

		#region ================== Methods
		
		// This keeps the results for a sidedef intersection
		internal override void SetPickResults(Vector3D intersect, float u)
		{
			this.pickintersect = intersect;
			this.pickrayu = u;
		}
		
		#endregion
	}
}