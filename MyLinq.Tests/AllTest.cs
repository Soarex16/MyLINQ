using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace MyLinq.Tests {
    [TestFixture]
    public class AllTest {

        [Test]
        public void All_Empty_False() {
            int[] arr = {};
            Func<int, bool> predicate = x => x > 0;

            bool res = arr.All(predicate);

            Assert.That(res, Is.True);
        }

        [Test]
        public void All_StringList_True() {
            List<string> strList = new List<string>() {
                "test method",
                "test",
                "testing",
                "tested"
            };
            Func<string, bool> predicate = s => s.StartsWith("test");

            bool res = strList.All(predicate);

            Assert.That(res, Is.True);
        }

        [Test]
        public void All_StringList_False() {
            List<string> strList = new List<string>() {
                "test method",
                "test",
                "abc",
                "testing",
                "tested"
            };
            Func<string, bool> predicate = s => s.StartsWith("test");

            bool res = strList.All(predicate);

            Assert.That(res, Is.False);
        }
    }
}