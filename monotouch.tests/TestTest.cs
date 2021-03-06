//
// Copyright 2011-2012 Xamarin Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using NUnit.Framework;

namespace MonoTouchFixtures.Test {
	
	[TestFixture]
	[Preserve (AllMembers = true)]
	public class Test {
		
		[Test]
		public void Ok ()
		{
			Assert.Null (null);
			Assert.True (true);
			Assert.False (false);
		}

		[Test]
		[ExpectedException (typeof (NullReferenceException))]
		public void ExpectedExceptionException ()
		{
			string s = null;
			Assert.That (s.Length, Is.EqualTo (0), "Length");
		}
		
		[Test]
		[Ignore ("don't even execute this one")]
		public void IgnoredByAttribute ()
		{
			throw new NotImplementedException ();
		}

		[Test]
		public void IgnoreInCode ()
		{
			Assert.Ignore ("let's forget about this one");
			throw new NotImplementedException ();
		}

		[Test]
		public void InconclusiveInCode ()
		{
			Assert.Inconclusive ("it did not mean anything");
			throw new NotImplementedException ();
		}
		
		[Test]
		public void FailInCode ()
		{
			Assert.Fail ("that won't do it");
			throw new NotImplementedException ();
		}

		[Test]
		public void PassInCode ()
		{
			Assert.Pass ("good enough");
			throw new NotImplementedException ();
		}

		[Test]
		[ExpectedException (typeof (NullReferenceException))]
		public void IgnoredExpectedException ()
		{
			Assert.Ignore ("ignore [ExpectedException]");
		}

		[Test]
		[ExpectedException (typeof (NullReferenceException))]
		public void InconclusiveExpectedException ()
		{
			Assert.Inconclusive ("inconclusive [ExpectedException]");
		}

		[Test]
		[ExpectedException (typeof (NullReferenceException))]
		public void PassExpectedException ()
		{
			Assert.Pass ("pass [ExpectedException]");
		}
	}
}