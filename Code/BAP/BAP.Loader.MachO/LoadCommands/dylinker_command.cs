﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BAP.Loader.MachO.LoadCommands
{
	/// <summary>
	/// https://developer.apple.com/library/mac/documentation/DeveloperTools/Conceptual/MachORuntime/Reference/reference.html#//apple_ref/c/tag/dylinker_command
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct dylinker_command : ILoadCommand
	{
		[FieldOffset(0)]
		public LC cmd;

		[FieldOffset(4)]
		public UInt32 cmdsize;

		[FieldOffset(8)]
		public lc_str name;
	}
}
