﻿using Mono.Linker.Tests.Cases.Expectations.Assertions;
using Mono.Linker.Tests.Cases.Expectations.Metadata;
using Mono.Linker.Tests.Cases.Symbols.Dependencies;

namespace Mono.Linker.Tests.Cases.Symbols {
	[Reference ("LibraryWithPdb.dll")]
	[SandboxDependency ("Dependencies/LibraryWithPdb/LibraryWithPdb.dll", "input/LibraryWithPdb.dll")]
	[SandboxDependency ("Dependencies/LibraryWithPdb/LibraryWithPdb.pdb", "input/LibraryWithPdb.pdb")]
	[SetupLinkerLinkSymbols ("true")]
	[SetupLinkerAction ("copy", "LibraryWithPdb")]

	[KeptSymbols ("LibraryWithPdb.dll")]
	public class ReferenceWithPdbCopyActionAndSymbolLinkingEnabled {
		static void Main ()
		{
			LibraryWithPdb.SomeMethod ();
		}
	}
}