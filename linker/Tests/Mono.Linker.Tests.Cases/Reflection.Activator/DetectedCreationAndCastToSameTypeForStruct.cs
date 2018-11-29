using Mono.Linker.Tests.Cases.Expectations.Assertions;

namespace Mono.Linker.Tests.Cases.Reflection.Activator {
	public class DetectedCreationAndCastToSameTypeForStruct {
		public static void Main ()
		{
			var tmp = (Foo) System.Activator.CreateInstance (typeof (Foo));
			HereToUseCreatedInstance (tmp);
		}
		
		[Kept]
		static void HereToUseCreatedInstance (object arg)
		{
		}

		[Kept]
		[KeptMember (".ctor()")]
		struct Foo {
		}
	}
}